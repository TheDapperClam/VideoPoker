using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glide;

namespace VideoPoker {
    public partial class PokerForm : Form {
        public const int DRAW_LIMIT = 2;
        public const int HAND_SIZE = 5;
        public const int STARTING_CREDITS = 20;
        public const int BET_1_PAYOUT_MULTIPLIER = 1;
        public const int BET_3_PAYOUT_MULTIPLIER = 4;
        public const int BET_5_PAYOUT_MULTIPLIER = 6;

        public int Credits {
            get { return credits; }
            private set {
                credits = value;
                creditsLabel.Text = "Credits: " + credits;
            }
        }
        private int credits;

        private readonly Random rng = new Random ();
        private readonly Tweener tweener = new Tweener ();
        private readonly Stopwatch timeStopwatch = new Stopwatch ();
        private readonly SoundPlayer flipSound = new SoundPlayer ( Properties.Resources.card_flip );
        private readonly SoundPlayer fanfareSound = new SoundPlayer ( Properties.Resources.fanfare );
        private readonly SoundPlayer fanfareRoyalSound = new SoundPlayer ( Properties.Resources.fanfare_royal );

        private Card[] cards = new Card[ Card.SUIT_COUNT * Card.RANK_COUNT ];
        private Card[] hand = new Card[ HAND_SIZE ];
        private List<PictureBox> flippingPictures = new List<PictureBox> ();
        private int drawCardOffset;
        private int drawCount;
        private int betAmount = 1;

        private void ClearHolds () {
            holdCheckBox1.Checked = false;
            holdCheckBox2.Checked = false;
            holdCheckBox3.Checked = false;
            holdCheckBox4.Checked = false;
            holdCheckBox5.Checked = false;
        }

        private async Task Deal () {
            if ( drawCount >= DRAW_LIMIT ) {
                drawCount = 0;
                drawCardOffset = 0;
            }

            if ( drawCount <= 0 ) {
                int newCredits = Credits - betAmount;

                if ( newCredits < 0 )
                    return;

                Credits = newCredits;
                ShuffleCards ();
                ClearHolds ();
                SetHoldButtons ( true );
                SetBetButtons ( false );
            }

            handLabel.Visible = false;
            drawCount++;
            DrawCards ();

            if ( drawCount == DRAW_LIMIT ) {
                while ( flippingPictures.Count > 0 )
                    await Task.Delay ( 25 );

                SetHoldButtons ( false );
                SetBetButtons ( true );
                Hands finalHand = GetHand ( hand );
                bool hasHand = finalHand != Hands.None;
                handLabel.Text = hasHand ? finalHand.ToString ().Replace ( '_', ' ' ) : "Try Again";
                handLabel.Visible = true;

                switch ( betAmount ) {
                    case 1:
                        Credits += (int) finalHand * BET_1_PAYOUT_MULTIPLIER;
                        break;
                    case 3:
                        Credits += (int) finalHand * BET_3_PAYOUT_MULTIPLIER;
                        break;
                    case 5:
                        Credits += (int) finalHand * BET_5_PAYOUT_MULTIPLIER;
                        break;
                }

                if ( hasHand ) {
                    switch ( finalHand ) {
                        default:
                            fanfareSound.Play ();
                            break;
                        case Hands.Royal_Flush:
                            fanfareRoyalSound.Play ();
                            break;
                    }
                }
            }
        }

        private void DrawCard ( PictureBox pictureBox, int offset = 0 ) {
            if ( pictureBox == null )
                return;

            int defaultWidth = pictureBox.Width;
            int defaultX = pictureBox.Left;
            int centerX = pictureBox.Left + defaultWidth / 2;
            Card c = GetCard ( drawCardOffset + offset );
            hand[ offset ] = c;
            flippingPictures.Add ( pictureBox );

            tweener.Tween ( pictureBox, new { Width = 1, Left = centerX }, 0.1f ).OnComplete ( () => {
                pictureBox.Image = c.Sprite;
                tweener.Tween ( pictureBox, new { Width = defaultWidth, Left = defaultX }, 0.1f ).OnComplete ( () => {
                    flippingPictures.Remove ( pictureBox );
                } );
            } );
        }

        private void DrawCards () {
            if ( flippingPictures.Count > 0 )
                return;

            bool playFlipSound = false;

            if ( !holdCheckBox1.Checked ) {
                DrawCard ( cardPictureBox1 );
                playFlipSound = true;
            }

            if ( !holdCheckBox2.Checked ) {
                DrawCard ( cardPictureBox2, 1 );
                playFlipSound = true;
            }

            if ( !holdCheckBox3.Checked ) {
                DrawCard ( cardPictureBox3, 2 );
                playFlipSound = true;
            }

            if ( !holdCheckBox4.Checked ) {
                DrawCard ( cardPictureBox4, 3 );
                playFlipSound = true;
            }

            if ( !holdCheckBox5.Checked ) {
                DrawCard ( cardPictureBox5, 4 );
                playFlipSound = true;
            }

            drawCardOffset += HAND_SIZE;

            if ( playFlipSound )
                flipSound.Play ();
        }

        private Card GetCard ( int index ) {
            if ( index < 0 || index >= Card.SUIT_COUNT * Card.RANK_COUNT )
                return null;

            return cards[ index ];
        }

        private Hands GetHand ( Card[] hand ) {
            if ( hand.Length <= 0 )
                return Hands.None;

            hand = hand.OrderBy ( c => c.Rank ).ToArray ();
            Dictionary<int, int> pairs = new Dictionary<int, int> ();
            int firstRank = hand[ 0 ].Rank;
            int firstSuit = hand[ 0 ].Suit;
            bool straight = true;
            bool flush = true;

            for ( int i = 0; i < hand.Length; i++ ) {
                int currentRank = hand[ i ].Rank;
                int currentSuit = hand[ i ].Suit;

                if ( currentSuit != firstSuit )
                    flush = false;

                if ( i > 0 && currentRank - 1 != hand[ i - 1 ].Rank )
                    straight = false;

                if ( pairs.ContainsKey ( currentRank ) )
                    pairs[ currentRank ]++;
                else
                    pairs.Add ( currentRank, 1 );
            }
            pairs = pairs.Where ( p => p.Value > 1 ).ToDictionary ( p => p.Key, p => p.Value );
            int biggestPair = pairs.Count > 0 ? pairs.Values.Max () : 0;

            if ( firstRank == 8 && straight && flush )
                return Hands.Royal_Flush;

            if ( straight && flush )
                return Hands.Straight_Flush;

            if ( biggestPair == 4 )
                return Hands.Four_of_a_Kind;

            if ( biggestPair == 3 && pairs.Count == 2 )
                return Hands.Full_House;

            if ( flush )
                return Hands.Flush;

            if ( straight )
                return Hands.Straight;

            if ( biggestPair == 3 )
                return Hands.Three_of_a_Kind;

            if ( pairs.Count == 2 )
                return Hands.Two_Pair;

            if ( pairs.Count == 1 && pairs.Keys.Min () >= 9 )
                return Hands.Jacks_or_Better;

            return Hands.None;
        }

        private void LoadCards () {
            for ( int y = 0; y < Card.SUIT_COUNT; y++ )
                for ( int x = 0; x < Card.RANK_COUNT; x++ )
                    cards[ y * Card.RANK_COUNT + x ] = new Card ( x, y );
        }

        private void LoadHandPayouts () {
            Array hands = Enum.GetValues ( typeof ( Hands ) );
            Array.Reverse ( hands );

            foreach ( object hand in hands ) {
                string name = hand.ToString ().Replace ( '_', ' ' );
                int value = (int) hand;
                
                if ( value <= 0 )
                    continue;

                int index = payoutDataGridView.Rows.Add ();
                payoutDataGridView.Rows[ index ].Cells[ 0 ].Value = name;
                payoutDataGridView.Rows[ index ].Cells[ 1 ].Value = value * BET_1_PAYOUT_MULTIPLIER;
                payoutDataGridView.Rows[ index ].Cells[ 2 ].Value = value * BET_3_PAYOUT_MULTIPLIER;
                payoutDataGridView.Rows[ index ].Cells[ 3 ].Value = value * BET_5_PAYOUT_MULTIPLIER;
            }
        }

        private void SetBetAmount ( int amount ) {
            betAmount = amount;

            switch ( betAmount ) {
                case 1:
                    betButton3.Checked = false;
                    betButton5.Checked = false;
                    break;
                case 3:
                    betButton1.Checked = false;
                    betButton5.Checked = false;
                    break;
                case 5:
                    betButton1.Checked = false;
                    betButton3.Checked = false;
                    break;
            }
        }

        private void SetBetButtons ( bool enabled ) {
            betButton1.Enabled = enabled;
            betButton3.Enabled = enabled;
            betButton5.Enabled = enabled;
        }

        private void SetHoldButtons ( bool enabled ) {
            holdCheckBox1.Enabled = enabled;
            holdCheckBox2.Enabled = enabled;
            holdCheckBox3.Enabled = enabled;
            holdCheckBox4.Enabled = enabled;
            holdCheckBox5.Enabled = enabled;
            cardPictureBox1.Enabled = enabled;
            cardPictureBox2.Enabled = enabled;
            cardPictureBox3.Enabled = enabled;
            cardPictureBox4.Enabled = enabled;
            cardPictureBox5.Enabled = enabled;
        }

        private void ShuffleCards () {
            cards = cards.OrderBy ( x => rng.Next () ).ToArray ();
        }

        public PokerForm () {
            InitializeComponent ();
        }

        private void PokerForm_Load ( object sender, EventArgs e ) {
            betButton1.Checked = true;
            Credits = STARTING_CREDITS;
            LoadHandPayouts ();
            LoadCards ();
        }

        private void dealButton_Click ( object sender, EventArgs e ) {
            Deal ();
        }

        private void holdCheckBox1_CheckedChanged ( object sender, EventArgs e ) {
            holdCheckBox1.BackColor = holdCheckBox1.Checked ? Color.Lime : Color.Red;
        }

        private void holdCheckBox2_CheckedChanged ( object sender, EventArgs e ) {
            holdCheckBox2.BackColor = holdCheckBox2.Checked ? Color.Lime : Color.Red;
        }

        private void holdCheckBox3_CheckedChanged ( object sender, EventArgs e ) {
            holdCheckBox3.BackColor = holdCheckBox3.Checked ? Color.Lime : Color.Red;
        }

        private void holdCheckBox4_CheckedChanged ( object sender, EventArgs e ) {
            holdCheckBox4.BackColor = holdCheckBox4.Checked ? Color.Lime : Color.Red;
        }

        private void holdCheckBox5_CheckedChanged ( object sender, EventArgs e ) {
            holdCheckBox5.BackColor = holdCheckBox5.Checked ? Color.Lime : Color.Red;
        }

        private void cardPictureBox1_Click ( object sender, EventArgs e ) {
            holdCheckBox1.Checked = !holdCheckBox1.Checked;
        }

        private void cardPictureBox2_Click ( object sender, EventArgs e ) {
            holdCheckBox2.Checked = !holdCheckBox2.Checked;
        }

        private void cardPictureBox3_Click ( object sender, EventArgs e ) {
            holdCheckBox3.Checked = !holdCheckBox3.Checked;
        }

        private void cardPictureBox4_Click ( object sender, EventArgs e ) {
            holdCheckBox4.Checked = !holdCheckBox4.Checked;
        }

        private void cardPictureBox5_Click ( object sender, EventArgs e ) {
            holdCheckBox5.Checked = !holdCheckBox5.Checked;
        }

        private void tweenTimer_Tick ( object sender, EventArgs e ) {
            tweener.Update ( timeStopwatch.ElapsedMilliseconds / 1000.0f );
            timeStopwatch.Restart ();
        }

        private void betButton1_CheckedChanged ( object sender, EventArgs e ) {
            if ( betButton1.Checked ) {
                SetBetAmount ( 1 );
                betButton1.BackColor = Color.Lime;
            } else
                betButton1.BackColor = Color.Red;
        }

        private void betButton3_CheckedChanged ( object sender, EventArgs e ) {
            if ( betButton3.Checked ) {
                SetBetAmount ( 3 );
                betButton3.BackColor = Color.Lime;
            } else
                betButton3.BackColor = Color.Red;
        }

        private void betButton5_CheckedChanged ( object sender, EventArgs e ) {
            if ( betButton5.Checked ) {
                SetBetAmount ( 5 );
                betButton5.BackColor = Color.Lime;
            } else
                betButton5.BackColor = Color.Red;
        }
    }
}

using System.Drawing;

namespace VideoPoker {
    public enum Hands {
        None = 0,
        Jacks_or_Better = 1,
        Two_Pair = 5,
        Three_of_a_Kind = 10,
        Straight = 15,
        Flush = 25,
        Full_House = 50,
        Four_of_a_Kind = 100,
        Straight_Flush = 500,
        Royal_Flush = 10000
    }

    public class Card {
        public const int RANK_COUNT = 13;
        public const int SUIT_COUNT = 4;

        public static readonly Bitmap spriteSheet = Properties.Resources.cards;
        public static readonly float height = spriteSheet.Height / SUIT_COUNT;
        public static readonly float width = spriteSheet.Width / RANK_COUNT;

        public int Rank { get; private set; }
        public int Suit { get; private set; }
        public Image Sprite { get; private set; }

        public Card ( int rank, int suit ) {
            Rank = rank;
            Suit = suit;
            SetSprite ( Rank, Suit );
        }

        private void SetSprite ( int rank, int suit ) {
            RectangleF r = new RectangleF ( width * rank, height * suit, width, height );
            Sprite = spriteSheet.Clone ( r, spriteSheet.PixelFormat );
        }
    }
}

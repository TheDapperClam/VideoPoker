namespace VideoPoker {
    partial class PokerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokerForm));
            this.dealButton = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.holdCheckBox1 = new System.Windows.Forms.CheckBox();
            this.holdCheckBox2 = new System.Windows.Forms.CheckBox();
            this.holdCheckBox4 = new System.Windows.Forms.CheckBox();
            this.holdCheckBox3 = new System.Windows.Forms.CheckBox();
            this.holdCheckBox5 = new System.Windows.Forms.CheckBox();
            this.handLabel = new System.Windows.Forms.Label();
            this.tweenTimer = new System.Windows.Forms.Timer(this.components);
            this.payoutDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.betButton3 = new System.Windows.Forms.CheckBox();
            this.betButton1 = new System.Windows.Forms.CheckBox();
            this.betButton5 = new System.Windows.Forms.CheckBox();
            this.cardPictureBox1 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox5 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox3 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox4 = new System.Windows.Forms.PictureBox();
            this.cardPictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.payoutDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dealButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dealButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(198, 697);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(770, 45);
            this.dealButton.TabIndex = 11;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = false;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // creditsLabel
            // 
            this.creditsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(198, 353);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(770, 31);
            this.creditsLabel.TabIndex = 12;
            this.creditsLabel.Text = "Credits: 0";
            this.creditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // holdCheckBox1
            // 
            this.holdCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.holdCheckBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdCheckBox1.BackColor = System.Drawing.Color.Red;
            this.holdCheckBox1.Enabled = false;
            this.holdCheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.holdCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdCheckBox1.Location = new System.Drawing.Point(198, 619);
            this.holdCheckBox1.Name = "holdCheckBox1";
            this.holdCheckBox1.Size = new System.Drawing.Size(149, 72);
            this.holdCheckBox1.TabIndex = 13;
            this.holdCheckBox1.Text = "Hold";
            this.holdCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.holdCheckBox1.UseVisualStyleBackColor = false;
            this.holdCheckBox1.CheckedChanged += new System.EventHandler(this.holdCheckBox1_CheckedChanged);
            // 
            // holdCheckBox2
            // 
            this.holdCheckBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.holdCheckBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdCheckBox2.BackColor = System.Drawing.Color.Red;
            this.holdCheckBox2.Enabled = false;
            this.holdCheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.holdCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdCheckBox2.Location = new System.Drawing.Point(353, 619);
            this.holdCheckBox2.Name = "holdCheckBox2";
            this.holdCheckBox2.Size = new System.Drawing.Size(149, 72);
            this.holdCheckBox2.TabIndex = 14;
            this.holdCheckBox2.Text = "Hold";
            this.holdCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.holdCheckBox2.UseVisualStyleBackColor = false;
            this.holdCheckBox2.CheckedChanged += new System.EventHandler(this.holdCheckBox2_CheckedChanged);
            // 
            // holdCheckBox4
            // 
            this.holdCheckBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.holdCheckBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdCheckBox4.BackColor = System.Drawing.Color.Red;
            this.holdCheckBox4.Enabled = false;
            this.holdCheckBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.holdCheckBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdCheckBox4.Location = new System.Drawing.Point(663, 619);
            this.holdCheckBox4.Name = "holdCheckBox4";
            this.holdCheckBox4.Size = new System.Drawing.Size(149, 72);
            this.holdCheckBox4.TabIndex = 16;
            this.holdCheckBox4.Text = "Hold";
            this.holdCheckBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.holdCheckBox4.UseVisualStyleBackColor = false;
            this.holdCheckBox4.CheckedChanged += new System.EventHandler(this.holdCheckBox4_CheckedChanged);
            // 
            // holdCheckBox3
            // 
            this.holdCheckBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.holdCheckBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdCheckBox3.BackColor = System.Drawing.Color.Red;
            this.holdCheckBox3.Enabled = false;
            this.holdCheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.holdCheckBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdCheckBox3.Location = new System.Drawing.Point(508, 619);
            this.holdCheckBox3.Name = "holdCheckBox3";
            this.holdCheckBox3.Size = new System.Drawing.Size(149, 72);
            this.holdCheckBox3.TabIndex = 15;
            this.holdCheckBox3.Text = "Hold";
            this.holdCheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.holdCheckBox3.UseVisualStyleBackColor = false;
            this.holdCheckBox3.CheckedChanged += new System.EventHandler(this.holdCheckBox3_CheckedChanged);
            // 
            // holdCheckBox5
            // 
            this.holdCheckBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.holdCheckBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.holdCheckBox5.BackColor = System.Drawing.Color.Red;
            this.holdCheckBox5.Enabled = false;
            this.holdCheckBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.holdCheckBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdCheckBox5.Location = new System.Drawing.Point(818, 619);
            this.holdCheckBox5.Name = "holdCheckBox5";
            this.holdCheckBox5.Size = new System.Drawing.Size(150, 72);
            this.holdCheckBox5.TabIndex = 17;
            this.holdCheckBox5.Text = "Hold";
            this.holdCheckBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.holdCheckBox5.UseVisualStyleBackColor = false;
            this.holdCheckBox5.CheckedChanged += new System.EventHandler(this.holdCheckBox5_CheckedChanged);
            // 
            // handLabel
            // 
            this.handLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.handLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handLabel.ForeColor = System.Drawing.Color.Yellow;
            this.handLabel.Location = new System.Drawing.Point(198, 289);
            this.handLabel.Name = "handLabel";
            this.handLabel.Size = new System.Drawing.Size(770, 64);
            this.handLabel.TabIndex = 18;
            this.handLabel.Text = "Try Again";
            this.handLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.handLabel.Visible = false;
            // 
            // tweenTimer
            // 
            this.tweenTimer.Enabled = true;
            this.tweenTimer.Interval = 1;
            this.tweenTimer.Tick += new System.EventHandler(this.tweenTimer_Tick);
            // 
            // payoutDataGridView
            // 
            this.payoutDataGridView.AllowUserToAddRows = false;
            this.payoutDataGridView.AllowUserToDeleteRows = false;
            this.payoutDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.payoutDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payoutDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.payoutDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.payoutDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.payoutDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.payoutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payoutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.payoutDataGridView.EnableHeadersVisualStyles = false;
            this.payoutDataGridView.GridColor = System.Drawing.Color.Yellow;
            this.payoutDataGridView.Location = new System.Drawing.Point(198, 19);
            this.payoutDataGridView.Name = "payoutDataGridView";
            this.payoutDataGridView.ReadOnly = true;
            this.payoutDataGridView.RowHeadersVisible = false;
            this.payoutDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.payoutDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.payoutDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.payoutDataGridView.RowTemplate.ReadOnly = true;
            this.payoutDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.payoutDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.payoutDataGridView.Size = new System.Drawing.Size(770, 267);
            this.payoutDataGridView.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Hands";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Bet 1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Bet 3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Bet 5";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // betButton3
            // 
            this.betButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.betButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.betButton3.BackColor = System.Drawing.Color.Red;
            this.betButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.betButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton3.Location = new System.Drawing.Point(974, 110);
            this.betButton3.Name = "betButton3";
            this.betButton3.Size = new System.Drawing.Size(108, 85);
            this.betButton3.TabIndex = 20;
            this.betButton3.Text = "Bet 3";
            this.betButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.betButton3.UseVisualStyleBackColor = false;
            this.betButton3.CheckedChanged += new System.EventHandler(this.betButton3_CheckedChanged);
            // 
            // betButton1
            // 
            this.betButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.betButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.betButton1.BackColor = System.Drawing.Color.Red;
            this.betButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.betButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton1.Location = new System.Drawing.Point(974, 19);
            this.betButton1.Name = "betButton1";
            this.betButton1.Size = new System.Drawing.Size(108, 85);
            this.betButton1.TabIndex = 21;
            this.betButton1.Text = "Bet 1";
            this.betButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.betButton1.UseVisualStyleBackColor = false;
            this.betButton1.CheckedChanged += new System.EventHandler(this.betButton1_CheckedChanged);
            // 
            // betButton5
            // 
            this.betButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.betButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.betButton5.BackColor = System.Drawing.Color.Red;
            this.betButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.betButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betButton5.Location = new System.Drawing.Point(974, 201);
            this.betButton5.Name = "betButton5";
            this.betButton5.Size = new System.Drawing.Size(108, 85);
            this.betButton5.TabIndex = 22;
            this.betButton5.Text = "Bet 5";
            this.betButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.betButton5.UseVisualStyleBackColor = false;
            this.betButton5.CheckedChanged += new System.EventHandler(this.betButton5_CheckedChanged);
            // 
            // cardPictureBox1
            // 
            this.cardPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPictureBox1.Enabled = false;
            this.cardPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox1.Image")));
            this.cardPictureBox1.Location = new System.Drawing.Point(198, 393);
            this.cardPictureBox1.Name = "cardPictureBox1";
            this.cardPictureBox1.Size = new System.Drawing.Size(149, 220);
            this.cardPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox1.TabIndex = 0;
            this.cardPictureBox1.TabStop = false;
            this.cardPictureBox1.Click += new System.EventHandler(this.cardPictureBox1_Click);
            // 
            // cardPictureBox5
            // 
            this.cardPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPictureBox5.Enabled = false;
            this.cardPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox5.Image")));
            this.cardPictureBox5.Location = new System.Drawing.Point(818, 393);
            this.cardPictureBox5.Name = "cardPictureBox5";
            this.cardPictureBox5.Size = new System.Drawing.Size(150, 220);
            this.cardPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox5.TabIndex = 4;
            this.cardPictureBox5.TabStop = false;
            this.cardPictureBox5.Click += new System.EventHandler(this.cardPictureBox5_Click);
            // 
            // cardPictureBox3
            // 
            this.cardPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPictureBox3.Enabled = false;
            this.cardPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox3.Image")));
            this.cardPictureBox3.Location = new System.Drawing.Point(508, 393);
            this.cardPictureBox3.Name = "cardPictureBox3";
            this.cardPictureBox3.Size = new System.Drawing.Size(149, 220);
            this.cardPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox3.TabIndex = 2;
            this.cardPictureBox3.TabStop = false;
            this.cardPictureBox3.Click += new System.EventHandler(this.cardPictureBox3_Click);
            // 
            // cardPictureBox4
            // 
            this.cardPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPictureBox4.Enabled = false;
            this.cardPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox4.Image")));
            this.cardPictureBox4.Location = new System.Drawing.Point(663, 393);
            this.cardPictureBox4.Name = "cardPictureBox4";
            this.cardPictureBox4.Size = new System.Drawing.Size(149, 220);
            this.cardPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox4.TabIndex = 3;
            this.cardPictureBox4.TabStop = false;
            this.cardPictureBox4.Click += new System.EventHandler(this.cardPictureBox4_Click);
            // 
            // cardPictureBox2
            // 
            this.cardPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardPictureBox2.Enabled = false;
            this.cardPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("cardPictureBox2.Image")));
            this.cardPictureBox2.Location = new System.Drawing.Point(353, 393);
            this.cardPictureBox2.Name = "cardPictureBox2";
            this.cardPictureBox2.Size = new System.Drawing.Size(149, 220);
            this.cardPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardPictureBox2.TabIndex = 1;
            this.cardPictureBox2.TabStop = false;
            this.cardPictureBox2.Click += new System.EventHandler(this.cardPictureBox2_Click);
            // 
            // PokerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1166, 762);
            this.Controls.Add(this.betButton5);
            this.Controls.Add(this.betButton1);
            this.Controls.Add(this.betButton3);
            this.Controls.Add(this.payoutDataGridView);
            this.Controls.Add(this.cardPictureBox1);
            this.Controls.Add(this.handLabel);
            this.Controls.Add(this.cardPictureBox5);
            this.Controls.Add(this.holdCheckBox5);
            this.Controls.Add(this.cardPictureBox3);
            this.Controls.Add(this.holdCheckBox4);
            this.Controls.Add(this.cardPictureBox4);
            this.Controls.Add(this.holdCheckBox3);
            this.Controls.Add(this.cardPictureBox2);
            this.Controls.Add(this.holdCheckBox2);
            this.Controls.Add(this.holdCheckBox1);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.dealButton);
            this.Name = "PokerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Poker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PokerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payoutDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.CheckBox holdCheckBox1;
        private System.Windows.Forms.CheckBox holdCheckBox2;
        private System.Windows.Forms.CheckBox holdCheckBox4;
        private System.Windows.Forms.CheckBox holdCheckBox3;
        private System.Windows.Forms.CheckBox holdCheckBox5;
        private System.Windows.Forms.Label handLabel;
        private System.Windows.Forms.PictureBox cardPictureBox2;
        private System.Windows.Forms.PictureBox cardPictureBox4;
        private System.Windows.Forms.PictureBox cardPictureBox3;
        private System.Windows.Forms.PictureBox cardPictureBox5;
        private System.Windows.Forms.PictureBox cardPictureBox1;
        private System.Windows.Forms.Timer tweenTimer;
        private System.Windows.Forms.DataGridView payoutDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox betButton3;
        private System.Windows.Forms.CheckBox betButton1;
        private System.Windows.Forms.CheckBox betButton5;
    }
}


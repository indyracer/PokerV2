namespace PokerV2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1Card3 = new System.Windows.Forms.TextBox();
            this.player1Card2 = new System.Windows.Forms.TextBox();
            this.player1Card4 = new System.Windows.Forms.TextBox();
            this.player1Card5 = new System.Windows.Forms.TextBox();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.evaluationButton = new System.Windows.Forms.Button();
            this.evaluationLabel = new System.Windows.Forms.TextBox();
            this.player1Card1 = new System.Windows.Forms.TextBox();
            this.player1Pic1 = new System.Windows.Forms.PictureBox();
            this.player1Pic2 = new System.Windows.Forms.PictureBox();
            this.player1Pic3 = new System.Windows.Forms.PictureBox();
            this.player1Pic4 = new System.Windows.Forms.PictureBox();
            this.player1Pic5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfPlayers = new System.Windows.Forms.TextBox();
            this.player2Pic5 = new System.Windows.Forms.PictureBox();
            this.player2Pic4 = new System.Windows.Forms.PictureBox();
            this.player2Pic3 = new System.Windows.Forms.PictureBox();
            this.player2Pic2 = new System.Windows.Forms.PictureBox();
            this.player2Pic1 = new System.Windows.Forms.PictureBox();
            this.player2Card1 = new System.Windows.Forms.TextBox();
            this.player2Card5 = new System.Windows.Forms.TextBox();
            this.player2Card4 = new System.Windows.Forms.TextBox();
            this.player2Card2 = new System.Windows.Forms.TextBox();
            this.player2Card3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // player1Card3
            // 
            this.player1Card3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Card3.Location = new System.Drawing.Point(425, 185);
            this.player1Card3.Multiline = true;
            this.player1Card3.Name = "player1Card3";
            this.player1Card3.ReadOnly = true;
            this.player1Card3.Size = new System.Drawing.Size(91, 18);
            this.player1Card3.TabIndex = 1;
            this.player1Card3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Card2
            // 
            this.player1Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Card2.Location = new System.Drawing.Point(314, 185);
            this.player1Card2.Multiline = true;
            this.player1Card2.Name = "player1Card2";
            this.player1Card2.ReadOnly = true;
            this.player1Card2.Size = new System.Drawing.Size(91, 18);
            this.player1Card2.TabIndex = 2;
            this.player1Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Card4
            // 
            this.player1Card4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Card4.Location = new System.Drawing.Point(536, 185);
            this.player1Card4.Multiline = true;
            this.player1Card4.Name = "player1Card4";
            this.player1Card4.ReadOnly = true;
            this.player1Card4.Size = new System.Drawing.Size(91, 18);
            this.player1Card4.TabIndex = 3;
            this.player1Card4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Card5
            // 
            this.player1Card5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Card5.Location = new System.Drawing.Point(647, 185);
            this.player1Card5.Multiline = true;
            this.player1Card5.Name = "player1Card5";
            this.player1Card5.ReadOnly = true;
            this.player1Card5.Size = new System.Drawing.Size(91, 18);
            this.player1Card5.TabIndex = 4;
            this.player1Card5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shuffleButton
            // 
            this.shuffleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.Location = new System.Drawing.Point(12, 185);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(119, 31);
            this.shuffleButton.TabIndex = 6;
            this.shuffleButton.Text = "Shuffle/Deal";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            // 
            // evaluationButton
            // 
            this.evaluationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationButton.Location = new System.Drawing.Point(12, 407);
            this.evaluationButton.Name = "evaluationButton";
            this.evaluationButton.Size = new System.Drawing.Size(119, 31);
            this.evaluationButton.TabIndex = 7;
            this.evaluationButton.Text = "Evaluate Hand";
            this.evaluationButton.UseVisualStyleBackColor = true;
            this.evaluationButton.Click += new System.EventHandler(this.evaluationButton_Click);
            // 
            // evaluationLabel
            // 
            this.evaluationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationLabel.Location = new System.Drawing.Point(203, 412);
            this.evaluationLabel.Name = "evaluationLabel";
            this.evaluationLabel.ReadOnly = true;
            this.evaluationLabel.Size = new System.Drawing.Size(533, 26);
            this.evaluationLabel.TabIndex = 8;
            this.evaluationLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Card1
            // 
            this.player1Card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Card1.Location = new System.Drawing.Point(203, 185);
            this.player1Card1.Multiline = true;
            this.player1Card1.Name = "player1Card1";
            this.player1Card1.ReadOnly = true;
            this.player1Card1.Size = new System.Drawing.Size(91, 18);
            this.player1Card1.TabIndex = 9;
            this.player1Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Pic1
            // 
            this.player1Pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player1Pic1.Location = new System.Drawing.Point(203, 45);
            this.player1Pic1.Name = "player1Pic1";
            this.player1Pic1.Size = new System.Drawing.Size(91, 123);
            this.player1Pic1.TabIndex = 10;
            this.player1Pic1.TabStop = false;
            // 
            // player1Pic2
            // 
            this.player1Pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player1Pic2.Location = new System.Drawing.Point(314, 45);
            this.player1Pic2.Name = "player1Pic2";
            this.player1Pic2.Size = new System.Drawing.Size(91, 123);
            this.player1Pic2.TabIndex = 11;
            this.player1Pic2.TabStop = false;
            // 
            // player1Pic3
            // 
            this.player1Pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player1Pic3.Location = new System.Drawing.Point(425, 45);
            this.player1Pic3.Name = "player1Pic3";
            this.player1Pic3.Size = new System.Drawing.Size(91, 123);
            this.player1Pic3.TabIndex = 12;
            this.player1Pic3.TabStop = false;
            // 
            // player1Pic4
            // 
            this.player1Pic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player1Pic4.Location = new System.Drawing.Point(536, 45);
            this.player1Pic4.Name = "player1Pic4";
            this.player1Pic4.Size = new System.Drawing.Size(91, 123);
            this.player1Pic4.TabIndex = 13;
            this.player1Pic4.TabStop = false;
            // 
            // player1Pic5
            // 
            this.player1Pic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player1Pic5.Location = new System.Drawing.Point(646, 45);
            this.player1Pic5.Name = "player1Pic5";
            this.player1Pic5.Size = new System.Drawing.Size(91, 123);
            this.player1Pic5.TabIndex = 14;
            this.player1Pic5.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of Players\r\n(Max 2)";
            this.label1.UseMnemonic = false;
            // 
            // numOfPlayers
            // 
            this.numOfPlayers.Location = new System.Drawing.Point(203, 13);
            this.numOfPlayers.Name = "numOfPlayers";
            this.numOfPlayers.Size = new System.Drawing.Size(100, 20);
            this.numOfPlayers.TabIndex = 16;
            // 
            // player2Pic5
            // 
            this.player2Pic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player2Pic5.Location = new System.Drawing.Point(646, 209);
            this.player2Pic5.Name = "player2Pic5";
            this.player2Pic5.Size = new System.Drawing.Size(91, 123);
            this.player2Pic5.TabIndex = 26;
            this.player2Pic5.TabStop = false;
            // 
            // player2Pic4
            // 
            this.player2Pic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player2Pic4.Location = new System.Drawing.Point(536, 209);
            this.player2Pic4.Name = "player2Pic4";
            this.player2Pic4.Size = new System.Drawing.Size(91, 123);
            this.player2Pic4.TabIndex = 25;
            this.player2Pic4.TabStop = false;
            // 
            // player2Pic3
            // 
            this.player2Pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player2Pic3.Location = new System.Drawing.Point(425, 209);
            this.player2Pic3.Name = "player2Pic3";
            this.player2Pic3.Size = new System.Drawing.Size(91, 123);
            this.player2Pic3.TabIndex = 24;
            this.player2Pic3.TabStop = false;
            // 
            // player2Pic2
            // 
            this.player2Pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player2Pic2.Location = new System.Drawing.Point(314, 209);
            this.player2Pic2.Name = "player2Pic2";
            this.player2Pic2.Size = new System.Drawing.Size(91, 123);
            this.player2Pic2.TabIndex = 23;
            this.player2Pic2.TabStop = false;
            // 
            // player2Pic1
            // 
            this.player2Pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.player2Pic1.Location = new System.Drawing.Point(203, 209);
            this.player2Pic1.Name = "player2Pic1";
            this.player2Pic1.Size = new System.Drawing.Size(91, 123);
            this.player2Pic1.TabIndex = 22;
            this.player2Pic1.TabStop = false;
            // 
            // player2Card1
            // 
            this.player2Card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Card1.Location = new System.Drawing.Point(203, 349);
            this.player2Card1.Multiline = true;
            this.player2Card1.Name = "player2Card1";
            this.player2Card1.ReadOnly = true;
            this.player2Card1.Size = new System.Drawing.Size(91, 18);
            this.player2Card1.TabIndex = 21;
            this.player2Card1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2Card5
            // 
            this.player2Card5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Card5.Location = new System.Drawing.Point(647, 349);
            this.player2Card5.Multiline = true;
            this.player2Card5.Name = "player2Card5";
            this.player2Card5.ReadOnly = true;
            this.player2Card5.Size = new System.Drawing.Size(91, 18);
            this.player2Card5.TabIndex = 20;
            this.player2Card5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2Card4
            // 
            this.player2Card4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Card4.Location = new System.Drawing.Point(536, 349);
            this.player2Card4.Multiline = true;
            this.player2Card4.Name = "player2Card4";
            this.player2Card4.ReadOnly = true;
            this.player2Card4.Size = new System.Drawing.Size(91, 18);
            this.player2Card4.TabIndex = 19;
            this.player2Card4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2Card2
            // 
            this.player2Card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Card2.Location = new System.Drawing.Point(314, 349);
            this.player2Card2.Multiline = true;
            this.player2Card2.Name = "player2Card2";
            this.player2Card2.ReadOnly = true;
            this.player2Card2.Size = new System.Drawing.Size(91, 18);
            this.player2Card2.TabIndex = 18;
            this.player2Card2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player2Card3
            // 
            this.player2Card3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Card3.Location = new System.Drawing.Point(425, 349);
            this.player2Card3.Multiline = true;
            this.player2Card3.Name = "player2Card3";
            this.player2Card3.ReadOnly = true;
            this.player2Card3.Size = new System.Drawing.Size(91, 18);
            this.player2Card3.TabIndex = 17;
            this.player2Card3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Player 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player2Pic5);
            this.Controls.Add(this.player2Pic4);
            this.Controls.Add(this.player2Pic3);
            this.Controls.Add(this.player2Pic2);
            this.Controls.Add(this.player2Pic1);
            this.Controls.Add(this.player2Card1);
            this.Controls.Add(this.player2Card5);
            this.Controls.Add(this.player2Card4);
            this.Controls.Add(this.player2Card2);
            this.Controls.Add(this.player2Card3);
            this.Controls.Add(this.numOfPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player1Pic5);
            this.Controls.Add(this.player1Pic4);
            this.Controls.Add(this.player1Pic3);
            this.Controls.Add(this.player1Pic2);
            this.Controls.Add(this.player1Pic1);
            this.Controls.Add(this.player1Card1);
            this.Controls.Add(this.evaluationLabel);
            this.Controls.Add(this.evaluationButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.player1Card5);
            this.Controls.Add(this.player1Card4);
            this.Controls.Add(this.player1Card2);
            this.Controls.Add(this.player1Card3);
            this.Name = "Form1";
            this.Text = "Poker Evaluation";
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox player1Card3;
        private System.Windows.Forms.TextBox player1Card2;
        private System.Windows.Forms.TextBox player1Card4;
        private System.Windows.Forms.TextBox player1Card5;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button evaluationButton;
        private System.Windows.Forms.TextBox evaluationLabel;
        private System.Windows.Forms.TextBox player1Card1;
        private System.Windows.Forms.PictureBox player1Pic1;
        private System.Windows.Forms.PictureBox player1Pic2;
        private System.Windows.Forms.PictureBox player1Pic3;
        private System.Windows.Forms.PictureBox player1Pic4;
        private System.Windows.Forms.PictureBox player1Pic5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numOfPlayers;
        private System.Windows.Forms.PictureBox player2Pic5;
        private System.Windows.Forms.PictureBox player2Pic4;
        private System.Windows.Forms.PictureBox player2Pic3;
        private System.Windows.Forms.PictureBox player2Pic2;
        private System.Windows.Forms.PictureBox player2Pic1;
        private System.Windows.Forms.TextBox player2Card1;
        private System.Windows.Forms.TextBox player2Card5;
        private System.Windows.Forms.TextBox player2Card4;
        private System.Windows.Forms.TextBox player2Card2;
        private System.Windows.Forms.TextBox player2Card3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


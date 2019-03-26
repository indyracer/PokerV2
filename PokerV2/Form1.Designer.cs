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
            this.card1 = new System.Windows.Forms.TextBox();
            this.card3 = new System.Windows.Forms.TextBox();
            this.card2 = new System.Windows.Forms.TextBox();
            this.card4 = new System.Windows.Forms.TextBox();
            this.card5 = new System.Windows.Forms.TextBox();
            this.handLabel = new System.Windows.Forms.Label();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.evaluationButton = new System.Windows.Forms.Button();
            this.evaluationLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // card1
            // 
            this.card1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card1.Location = new System.Drawing.Point(203, 120);
            this.card1.Multiline = true;
            this.card1.Name = "card1";
            this.card1.ReadOnly = true;
            this.card1.Size = new System.Drawing.Size(90, 100);
            this.card1.TabIndex = 0;
            // 
            // card3
            // 
            this.card3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card3.Location = new System.Drawing.Point(425, 120);
            this.card3.Multiline = true;
            this.card3.Name = "card3";
            this.card3.ReadOnly = true;
            this.card3.Size = new System.Drawing.Size(90, 100);
            this.card3.TabIndex = 1;
            // 
            // card2
            // 
            this.card2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card2.Location = new System.Drawing.Point(314, 120);
            this.card2.Multiline = true;
            this.card2.Name = "card2";
            this.card2.ReadOnly = true;
            this.card2.Size = new System.Drawing.Size(90, 100);
            this.card2.TabIndex = 2;
            // 
            // card4
            // 
            this.card4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card4.Location = new System.Drawing.Point(536, 120);
            this.card4.Multiline = true;
            this.card4.Name = "card4";
            this.card4.ReadOnly = true;
            this.card4.Size = new System.Drawing.Size(90, 100);
            this.card4.TabIndex = 3;
            // 
            // card5
            // 
            this.card5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card5.Location = new System.Drawing.Point(647, 120);
            this.card5.Multiline = true;
            this.card5.Name = "card5";
            this.card5.ReadOnly = true;
            this.card5.Size = new System.Drawing.Size(90, 100);
            this.card5.TabIndex = 4;
            // 
            // handLabel
            // 
            this.handLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.handLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handLabel.Location = new System.Drawing.Point(203, 86);
            this.handLabel.Name = "handLabel";
            this.handLabel.Size = new System.Drawing.Size(534, 31);
            this.handLabel.TabIndex = 5;
            this.handLabel.Text = "Hand";
            this.handLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shuffleButton
            // 
            this.shuffleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.Location = new System.Drawing.Point(39, 154);
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
            this.evaluationButton.Location = new System.Drawing.Point(39, 319);
            this.evaluationButton.Name = "evaluationButton";
            this.evaluationButton.Size = new System.Drawing.Size(119, 31);
            this.evaluationButton.TabIndex = 7;
            this.evaluationButton.Text = "Evaluate Hand";
            this.evaluationButton.UseVisualStyleBackColor = true;
            // 
            // evaluationLabel
            // 
            this.evaluationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationLabel.Location = new System.Drawing.Point(203, 321);
            this.evaluationLabel.Name = "evaluationLabel";
            this.evaluationLabel.Size = new System.Drawing.Size(533, 26);
            this.evaluationLabel.TabIndex = 8;
            this.evaluationLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.evaluationLabel);
            this.Controls.Add(this.evaluationButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.handLabel);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card1);
            this.Name = "Form1";
            this.Text = "Poker Evaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox card1;
        private System.Windows.Forms.TextBox card3;
        private System.Windows.Forms.TextBox card2;
        private System.Windows.Forms.TextBox card4;
        private System.Windows.Forms.TextBox card5;
        private System.Windows.Forms.Label handLabel;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button evaluationButton;
        private System.Windows.Forms.TextBox evaluationLabel;
    }
}


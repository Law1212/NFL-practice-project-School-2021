
namespace IranyitoMutato
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.passAttemptCountTextBox = new System.Windows.Forms.TextBox();
            this.successfulPassCountTextBox = new System.Windows.Forms.TextBox();
            this.passedYardsTextBox = new System.Windows.Forms.TextBox();
            this.successfulTDPassCountTextBox = new System.Windows.Forms.TextBox();
            this.lostBallCountTextBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Átadási kísérletek száma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sikeres átadások száma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(110, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Passzolt yardok:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(65, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "Touchdown passzok:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(98, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Eladott átadások:";
            // 
            // passAttemptCountTextBox
            // 
            this.passAttemptCountTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passAttemptCountTextBox.Location = new System.Drawing.Point(303, 28);
            this.passAttemptCountTextBox.Name = "passAttemptCountTextBox";
            this.passAttemptCountTextBox.Size = new System.Drawing.Size(100, 33);
            this.passAttemptCountTextBox.TabIndex = 9;
            this.passAttemptCountTextBox.Text = "0";
            this.passAttemptCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passAttemptCountTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // successfulPassCountTextBox
            // 
            this.successfulPassCountTextBox.Enabled = false;
            this.successfulPassCountTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.successfulPassCountTextBox.Location = new System.Drawing.Point(303, 67);
            this.successfulPassCountTextBox.Name = "successfulPassCountTextBox";
            this.successfulPassCountTextBox.Size = new System.Drawing.Size(100, 33);
            this.successfulPassCountTextBox.TabIndex = 10;
            this.successfulPassCountTextBox.Text = "0";
            this.successfulPassCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passedYardsTextBox
            // 
            this.passedYardsTextBox.Enabled = false;
            this.passedYardsTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passedYardsTextBox.Location = new System.Drawing.Point(303, 106);
            this.passedYardsTextBox.Name = "passedYardsTextBox";
            this.passedYardsTextBox.Size = new System.Drawing.Size(100, 33);
            this.passedYardsTextBox.TabIndex = 11;
            this.passedYardsTextBox.Text = "0";
            this.passedYardsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // successfulTDPassCountTextBox
            // 
            this.successfulTDPassCountTextBox.Enabled = false;
            this.successfulTDPassCountTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.successfulTDPassCountTextBox.Location = new System.Drawing.Point(303, 145);
            this.successfulTDPassCountTextBox.Name = "successfulTDPassCountTextBox";
            this.successfulTDPassCountTextBox.Size = new System.Drawing.Size(100, 33);
            this.successfulTDPassCountTextBox.TabIndex = 12;
            this.successfulTDPassCountTextBox.Text = "0";
            this.successfulTDPassCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lostBallCountTextBox
            // 
            this.lostBallCountTextBox.Enabled = false;
            this.lostBallCountTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lostBallCountTextBox.Location = new System.Drawing.Point(303, 184);
            this.lostBallCountTextBox.Name = "lostBallCountTextBox";
            this.lostBallCountTextBox.Size = new System.Drawing.Size(100, 33);
            this.lostBallCountTextBox.TabIndex = 13;
            this.lostBallCountTextBox.Text = "0";
            this.lostBallCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ratingLabel.ForeColor = System.Drawing.Color.Black;
            this.ratingLabel.Location = new System.Drawing.Point(443, 71);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ratingLabel.Size = new System.Drawing.Size(226, 29);
            this.ratingLabel.TabIndex = 14;
            this.ratingLabel.Text = "Irányító mutató:";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(496, 108);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(92, 36);
            this.calculateButton.TabIndex = 15;
            this.calculateButton.Text = "Számol";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 238);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.lostBallCountTextBox);
            this.Controls.Add(this.successfulTDPassCountTextBox);
            this.Controls.Add(this.passedYardsTextBox);
            this.Controls.Add(this.successfulPassCountTextBox);
            this.Controls.Add(this.passAttemptCountTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Irányító mutató kalkulátor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passAttemptCountTextBox;
        private System.Windows.Forms.TextBox successfulPassCountTextBox;
        private System.Windows.Forms.TextBox passedYardsTextBox;
        private System.Windows.Forms.TextBox successfulTDPassCount;
        private System.Windows.Forms.TextBox lostBallCountTextBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox successfulTDPassCountTextBox;
    }
}


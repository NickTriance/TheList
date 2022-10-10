
namespace TheListQuote
{
    partial class QuoteGetter
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
            this.NumberLabel = new System.Windows.Forms.Label();
            this.QuoteBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberLabel.Location = new System.Drawing.Point(262, 104);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(289, 32);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Click button to get quote.";
            // 
            // QuoteBox
            // 
            this.QuoteBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuoteBox.Location = new System.Drawing.Point(249, 149);
            this.QuoteBox.Multiline = true;
            this.QuoteBox.Name = "QuoteBox";
            this.QuoteBox.ReadOnly = true;
            this.QuoteBox.Size = new System.Drawing.Size(302, 123);
            this.QuoteBox.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(343, 289);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 39);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Get a quote!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Previous Quote";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuoteGetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.QuoteBox);
            this.Controls.Add(this.NumberLabel);
            this.Name = "QuoteGetter";
            this.Text = "The List: Random Quote";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox QuoteBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


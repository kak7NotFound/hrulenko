namespace hd
{
    partial class TestForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.option1RadioButton = new System.Windows.Forms.RadioButton();
            this.option2RadioButton = new System.Windows.Forms.RadioButton();
            this.option3RadioButton = new System.Windows.Forms.RadioButton();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(13, 13);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(46, 17);
            this.questionLabel.TabIndex = 9;
            this.questionLabel.Text = "label1";
            // 
            // option1RadioButton
            // 
            this.option1RadioButton.AutoSize = true;
            this.option1RadioButton.Location = new System.Drawing.Point(28, 68);
            this.option1RadioButton.Name = "option1RadioButton";
            this.option1RadioButton.Size = new System.Drawing.Size(110, 21);
            this.option1RadioButton.TabIndex = 2;
            this.option1RadioButton.TabStop = true;
            this.option1RadioButton.Text = "radioButton1";
            this.option1RadioButton.UseVisualStyleBackColor = true;
            // 
            // option2RadioButton
            // 
            this.option2RadioButton.AutoSize = true;
            this.option2RadioButton.Location = new System.Drawing.Point(28, 102);
            this.option2RadioButton.Name = "option2RadioButton";
            this.option2RadioButton.Size = new System.Drawing.Size(110, 21);
            this.option2RadioButton.TabIndex = 3;
            this.option2RadioButton.TabStop = true;
            this.option2RadioButton.Text = "radioButton2";
            this.option2RadioButton.UseVisualStyleBackColor = true;
            // 
            // option3RadioButton
            // 
            this.option3RadioButton.AutoSize = true;
            this.option3RadioButton.Location = new System.Drawing.Point(28, 136);
            this.option3RadioButton.Name = "option3RadioButton";
            this.option3RadioButton.Size = new System.Drawing.Size(110, 21);
            this.option3RadioButton.TabIndex = 4;
            this.option3RadioButton.TabStop = true;
            this.option3RadioButton.Text = "radioButton3";
            this.option3RadioButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(162, 183);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(110, 36);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click1);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(280, 232);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.option3RadioButton);
            this.Controls.Add(this.option2RadioButton);
            this.Controls.Add(this.option1RadioButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button nextButton;

        #endregion

        private System.Windows.Forms.RadioButton option1RadioButton;
        private System.Windows.Forms.RadioButton option2RadioButton;
        private System.Windows.Forms.RadioButton option3RadioButton;
        private System.Windows.Forms.Label questionLabel;
    }
}
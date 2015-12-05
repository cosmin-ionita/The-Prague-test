namespace ThePragueTestControls
{
    partial class AnswersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberToGuess = new System.Windows.Forms.Panel();
            this.numberInputPanel = new System.Windows.Forms.Panel();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.numberToGuessLabel = new System.Windows.Forms.Label();
            this.numberToGuess.SuspendLayout();
            this.numberInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberToGuess
            // 
            this.numberToGuess.Controls.Add(this.numberToGuessLabel);
            this.numberToGuess.Location = new System.Drawing.Point(0, 0);
            this.numberToGuess.Name = "numberToGuess";
            this.numberToGuess.Size = new System.Drawing.Size(104, 41);
            this.numberToGuess.TabIndex = 0;
            // 
            // numberInputPanel
            // 
            this.numberInputPanel.AutoSize = true;
            this.numberInputPanel.Controls.Add(this.numberInput);
            this.numberInputPanel.Location = new System.Drawing.Point(101, 0);
            this.numberInputPanel.Name = "numberInputPanel";
            this.numberInputPanel.Size = new System.Drawing.Size(108, 44);
            this.numberInputPanel.TabIndex = 1;
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(0, 0);
            this.numberInput.Multiline = true;
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(105, 41);
            this.numberInput.TabIndex = 0;
            // 
            // numberToGuessLabel
            // 
            this.numberToGuessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numberToGuessLabel.Location = new System.Drawing.Point(0, 0);
            this.numberToGuessLabel.Name = "numberToGuessLabel";
            this.numberToGuessLabel.Size = new System.Drawing.Size(104, 41);
            this.numberToGuessLabel.TabIndex = 0;
            this.numberToGuessLabel.Text = "label1";
            this.numberToGuessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numberInputPanel);
            this.Controls.Add(this.numberToGuess);
            this.Name = "AnswersControl";
            this.Size = new System.Drawing.Size(206, 41);
            this.numberToGuess.ResumeLayout(false);
            this.numberInputPanel.ResumeLayout(false);
            this.numberInputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel numberToGuess;
        private System.Windows.Forms.Label numberToGuessLabel;
        private System.Windows.Forms.Panel numberInputPanel;
        private System.Windows.Forms.TextBox numberInput;
    }
}

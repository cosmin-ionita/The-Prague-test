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
            this.numberToGuessLabel = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberToGuessLabel
            // 
            this.numberToGuessLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberToGuessLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.numberToGuessLabel.Location = new System.Drawing.Point(0, 0);
            this.numberToGuessLabel.Name = "numberToGuessLabel";
            this.numberToGuessLabel.Size = new System.Drawing.Size(42, 39);
            this.numberToGuessLabel.TabIndex = 0;
            this.numberToGuessLabel.Text = "label1";
            this.numberToGuessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberInput
            // 
            this.numberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.numberInput.Location = new System.Drawing.Point(99, 0);
            this.numberInput.MinimumSize = new System.Drawing.Size(1, 1);
            this.numberInput.Multiline = true;
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(105, 39);
            this.numberInput.TabIndex = 0;
            this.numberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AnswersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.numberToGuessLabel);
            this.Controls.Add(this.numberInput);
            this.Name = "AnswersControl";
            this.Size = new System.Drawing.Size(204, 39);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numberToGuessLabel;
        private System.Windows.Forms.TextBox numberInput;
    }
}

namespace ThePragueTestControls
{
    partial class Numbers
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
            this.bigNumber = new System.Windows.Forms.Label();
            this.smallNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bigNumber
            // 
            this.bigNumber.AutoSize = true;
            this.bigNumber.Location = new System.Drawing.Point(31, 31);
            this.bigNumber.Name = "bigNumber";
            this.bigNumber.Size = new System.Drawing.Size(62, 13);
            this.bigNumber.TabIndex = 0;
            this.bigNumber.Text = "Big Number";
            // 
            // smallNumber
            // 
            this.smallNumber.AutoSize = true;
            this.smallNumber.Location = new System.Drawing.Point(31, 79);
            this.smallNumber.Name = "smallNumber";
            this.smallNumber.Size = new System.Drawing.Size(72, 13);
            this.smallNumber.TabIndex = 1;
            this.smallNumber.Text = "Small Number";
            // 
            // Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.smallNumber);
            this.Controls.Add(this.bigNumber);
            this.Name = "Numbers";
            this.Size = new System.Drawing.Size(140, 127);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bigNumber;
        private System.Windows.Forms.Label smallNumber;
    }
}

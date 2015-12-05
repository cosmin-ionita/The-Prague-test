using System;
using System.Windows.Forms;

namespace ThePragueTestControls
{
    public partial class Numbers : UserControl
    {
        public Numbers(int width, int height, int bigNumber, int smallNumber)
        {
            InitializeComponent();

            SetNumbers(bigNumber, smallNumber);

            SetStyle();

            SetSize(width, height);
        }

        private void SetStyle()
        {
            bigNumber.Font = new System.Drawing.Font("Times New Roman", 22, System.Drawing.FontStyle.Bold);
            //smallNumber.Font = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Regular);
        }

        public void SetNumbers(int bigNumber, int smallNumber)
        {
            this.bigNumber.Text = bigNumber.ToString();
            this.smallNumber.Text = smallNumber.ToString();
        }

        public void SetSize(int width, int height)
        {
            bigNumber.Height = height / 2;

            Width = width;
            Height = height;
        }
    }
}

using System;
using System.Windows.Forms;

namespace ThePragueTestControls
{
    public partial class AnswersControl : UserControl
    {
        public AnswersControl(int number, int width, int height)
        {
            InitializeComponent();

            SetSize(width, height);

            SetNumber(number);

            SetAnswerStyle();
        }

        private void SetAnswerStyle()
        {
            numberToGuessLabel.Font = new System.Drawing.Font("Times New Roman", 18, System.Drawing.FontStyle.Bold);
            numberInput.Font = new System.Drawing.Font("Times New Roman", 18, System.Drawing.FontStyle.Regular);
        }

        private void SetNumber(int number)
        {
            numberToGuessLabel.Text = number.ToString();
        }

        private void SetSize(int width, int height)
        {
            Width = width;
            Height = height;

            SetInputDimensions(width, height);
        }

        private void SetInputDimensions(int width, int height)
        {
            numberInput.Size = new System.Drawing.Size(width / 2, height);
            numberInput.TextAlign = HorizontalAlignment.Center;

            numberToGuessLabel.Size = new System.Drawing.Size(width / 2, height);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void SetNumber(int number)
        {
            numberToGuessLabel.Text = number.ToString();
        }

        private void SetSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}

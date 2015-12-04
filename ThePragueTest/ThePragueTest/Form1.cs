using System.Windows.Forms;
using ThePragueTestControls;

namespace ThePragueTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Numbers numberControl = new Numbers(200, 300, 2, 1);

            panel1.Controls.Add(numberControl);
        }
    }
}

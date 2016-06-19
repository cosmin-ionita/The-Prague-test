using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePragueTest
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            // Se incarca interfata acestei clase (componentele vizuale)
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Atunci cand s-a dat click pe butonul de start, se incarca
            // suprafata de lucru si se afiseaza
            Form1 form = new Form1();
            form.Show();
        }
    }
}

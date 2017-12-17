using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sjjg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sy1 = new shiyan1();
            sy1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form sy2 = new shiyan2();
            sy2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form sy3 = new shiyan3();
            sy3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form sy4 = new shiyan4();
            sy4.ShowDialog();
        }
    }
}

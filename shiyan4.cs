using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace sjjg
{
    public partial class shiyan4 : Form
    {
        GraphClass gl = new GraphClass();
        int n, en;
        int[,] a;
        int b;
        public shiyan4()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = comboBox1.SelectedIndex;
            if (k == 0)
            {
                n = 5;
                en = 6;
                a = new int[,] { { 0, 1, 0, 1, 0 }, { 1, 0, 1, 0, 0 }, { 0, 1, 0, 1, 1 }, { 1, 0, 1, 0, 1 }, { 0, 0, 1, 1, 0 } };
            }
        }

        private void dispbutton_Click(object sender, EventArgs e)
        {
            if (b == 3)
            {
                dispbox.Text = gl.DispMGraph();
            }
            else if (b == 4)
            {
                dispbox.Text = gl.DispALGraph();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int s = 0;
            string input = "";
            string[] split = textBox1.Text.Split(new string[] { ",", "，" }, StringSplitOptions.None);
            for (i = 0; i < split.Length; i++)
            {
                input += split[i];
            }
            string[] c = input.Split(' ');
            n = split.Length;
            en = n + 1;
            int[,] intArray = new int[n, n];
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    intArray[k , j] = int.Parse(c[s]);
                    s++;
                }
            }
            a = intArray;
        }
        private void du1_CheckedChanged(object sender, EventArgs e)
        {
            b = 1;
        }

        private void du2_CheckedChanged(object sender, EventArgs e)
        {
            b = 2;
        }

        private void getdu_Click(object sender, EventArgs e)
        {
            int i;
            string mystr = "";
            if (b == 1)
            {
                for (i = 0; i < gl.Getn(); i++)
                    mystr += " " + i.ToString() +  ": \t" + gl.Degree1(i).ToString() + "\r\n";
            }
            else if (b == 2)
            {
                for (i = 0; i < gl.Getn(); i++)
                    mystr += " " + i.ToString() + ": \t" + gl.Degree2(i).ToString() + "\r\n";
            }

            dispbox.Text = mystr;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            b = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            b = 4;
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            gl.CreateMGraph(n, en, a);
            gl.MatToList();
        }
    }
}

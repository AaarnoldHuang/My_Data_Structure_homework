/*
 * 这个窗体实现了三路归并
 */

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
    public partial class shiyan1_2 : Form
    {
        SqListClass L1 = new SqListClass();             //实例化对象
        SqListClass L2 = new SqListClass();
        SqListClass L3 = new SqListClass();
        const int INF = 32767;

        private int mindata(int a, int  b, int c, ref int mind)           //查找最小值并返回其所在的顺序表序号
        {
            int mini = 1;
            mind = a;
            if(mind > b)
            {
                mind = b;
                mini = 2;
            }
            if(mind > c)
            {
                mind = c;
                mini = 3;
            }
            return mini;
        }

        private void Merge3(ref SqListClass L4)         //三路归并
        {
            int i = 0, j = 0, k = 0, s = 0, t;
            int a, b, c, mind = 0;
            while(i<L1.length || j < L2.length || k < L3.length)
            {
                if (i >= L1.length)
                    a = INF;
                else
                    a = Convert.ToInt16(L1.data[i]);
                if (j >= L2.length)
                    b = INF;
                else
                    b = Convert.ToInt16(L2.data[j]);
                if (k >= L3.length)
                    c = INF;
                else
                    c = Convert.ToInt16(L3.data[k]);
                t = mindata(a, b, c, ref mind);
                switch (t)
                {
                    case 1: L4.data[s] = mind.ToString();
                        s++;
                        i++;
                        break;
                    case 2: L4.data[s] = mind.ToString();
                        s++;
                        j++;
                        break;
                    case 3: L4.data[s] = mind.ToString();
                        s++;
                        k++;
                        break;
                }
            }
            L4.length = s;
        }

        public shiyan1_2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text.Trim();
            if (str1 == "")
            {
                return;
            }
            else
            {
                string[] split = str1.Split(new char[] { ' ', ' ', '.', ':', });
                L1.CreatList(split);
            }
            string str2 = textBox2.Text.Trim();
            if (str2 == "")
            {
                return;
            }
            else
            {
                string[] split = str2.Split(new char[] { ' ', ' ', '.', ':', });
                L2.CreatList(split);
            }
            string str3 = textBox3.Text.Trim();
            if (str3 == "")
            {
                return;
            }
            else
            {
                string[] split = str3.Split(new char[] { ' ', ' ', '.', ':', });
                L3.CreatList(split);
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqListClass L4 = new SqListClass();
            Merge3(ref L4);
            textBox4.Text = L4.DispList();

        }

    }
}

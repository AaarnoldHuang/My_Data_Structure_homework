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
    public partial class shiyan1 : Form
    {
        SqListClass L = new SqListClass();          //实例化一个对象L

        private void Findele()             //查找元素
        {
            int i;
            string x = " ";
            if (textBox3.Text.Trim() == "")
                label2.Text = "请输入序号！";
            else
            {
                try
                {
                    i = Convert.ToInt16(textBox3.Text.Trim());
                }
                catch (Exception err)
                {
                    label2.Text = "Error！";
                    return;
                }
                if (L.GetElem(i, ref x))
                {
                    textBox2.Text = x;
                    label2.Text = "查找成功!";
                }
                else
                {
                    textBox2.Text = "";
                    label2.Text = "未找到元素！";
                }
            }
        }

        private void Findnum()                   //查找序号
        {
            int i;
            string x = textBox3.Text.Trim();
            if (x == "")
                label2.Text = "必须输入元素值";
            else
            {
                i = L.LocateElem(x);
                if (i == 0)
                {
                    label2.Text = "没有找到输入的元素";
                    textBox2.Text = "";
                }
                else
                {
                    textBox2.Text = i.ToString();
                    label2.Text = "成功求得制定元素的序号";
                }
            }
        }

        private void Split(ref SqListClass L1, ref SqListClass L2)           //建立奇偶顺序表表
        {
            int i = 1, j = 1, k = 1;
            string x = "";
            while (k <= L.ListLength())
            {
                L.GetElem(k, ref x);
                L1.ListInsert(i, x);
                i++;
                k++;
                if (k <= L.ListLength())
                {
                    L.GetElem(k, ref x);
                    L2.ListInsert(j, x);
                    j++;
                    k++;
                }
            }
            label2.Text = "成功产生两个顺序表";
        }

        private void Insert()             //插入元素
        {
            int i;
            string x, str;
            if (textBox3.Text.Trim() == "")
                label2.Text = "必须输入序号";
            else
            {
                try
                {
                    i = Convert.ToInt16(textBox3.Text.Trim());
                }
                catch (Exception err)
                {
                    label2.Text = "输入的序号是错误的";
                    return;
                }
                x = textBox2.Text.Trim();
                if (x == "")
                {
                    label2.Text = "操作提示：必须输入元素值";
                }
                else
                {
                    if (L.ListInsert(i, x))
                    {
                        str = L.DispList();
                        textBox4.Text = str;
                        label2.Text = "操作提示：成功插入元素" + x;
                    }
                    else
                    {
                        label2.Text = "操作提示：输入的序号" + i.ToString() + "错误";
                        textBox4.Text = "";
                    }
                }
            }
        }

        private void Deletebyele(string x)                  //按元素删除数据
        {
            int i, j;
            string y = "";
            for (i = 1; i <= L.ListLength(); i++)
            {
                L.GetElem(i, ref y);
                if (y == x)
                {
                    for (j = i - 1; j < L.length - 1; j++)
                        L.data[j] = L.data[j + 1];
                    L.length--;
                }
            }
            textBox4.Text = L.DispList();
        }

        private void Deletebynum()               //按序号删除数据
        {
            int i;
            string x = "", str;
            if (textBox3.Text.Trim() == "")
                label2.Text = "必须输入序号";
            else
            {
                try
                {
                    i = Convert.ToInt16(textBox3.Text.Trim());
                }
                catch (Exception err)
                {
                    label2.Text = "输入的序号是错误的";
                    return;
                }
                if (!L.ListDelete(i, ref x))
                {
                    label2.Text = "不能删除序号为" + i.ToString() + "的元素";
                    textBox4.Text = "";
                }
                else
                {
                    str = L.DispList();
                    textBox4.Text = str;
                    label2.Text = "成功删除元素" + x;
                }
            }
        }

        public shiyan1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.Trim();
            if (str == "")
            {
                label2.Text = "请输入元素啊！";
                return;
            }
            else
            {
                string[] split = str.Split(new char[] { ',', ' ', '.', ':', });
                L.CreatList(split);
            }
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = L.DispList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int k = comboBox1.SelectedIndex;                  //使用combobox中的索引号来判断要执行什么操作
            if (k == 0)
            {
                textBox2.Enabled = false;
                label3.Text = "长度";
                textBox3.Text = L.ListLength().ToString();
            }
            else if (k == 1)
            {
                textBox2.Enabled = true;
                label3.Text = "序号";
                label4.Text = "元素";
                Findele();
            }
            else if (k == 2)
            {
                textBox2.Enabled = true;
                label3.Text = "元素";
                label4.Text = "序号";
                Findnum();
            }
            else if (k == 3)
            {
                textBox2.Enabled = true;
                label3.Text = "序号";
                label4.Text = "元素";
                Insert();
            }
            else if (k == 4)
            {
                textBox2.Enabled = true;
                string text3 = textBox3.Text.ToString();
                string text2 = textBox2.Text.ToString();
                label3.Text = "按序号";
                label4.Text = "按元素";
                if (text3 != "" && text2 == "")
                    Deletebynum();
                else if (text3 == "" && text2 != "")
                    Deletebyele(text2);
            }
            else if (k == 5)
            {
                textBox2.Enabled = true;
                SqListClass L1 = new SqListClass();
                SqListClass L2 = new SqListClass();
                Split(ref L1, ref L2);
                label3.Text = "奇数序号的元素";
                label4.Text = "偶数序号的元素";
                textBox3.Text = L1.DispList();
                textBox2.Text = L2.DispList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form slgb = new shiyan1_2();
            slgb.ShowDialog();
        }
    }
}
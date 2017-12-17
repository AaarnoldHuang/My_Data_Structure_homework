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
    public partial class shiyan2 : Form
    {
        SqStackClass sq = new SqStackClass();
        SqQueueClass qu = new SqQueueClass();
        LinkQueueClass lq = new LinkQueueClass();

        private void Display()          //显示栈
        {
            string str;
            str = sq.DispStack();
            textBox1.Text = str;
        }

        private void DisplayQue()         //显示队列
        {
            string str;
            str = qu.DisQueue();
            textBox1.Text = str;
        }

        private void DisplayQueLink()       //显示链队
        {
            string str;
            str = lq.DispQueue();
            textBox1.Text = str;
        }

        private void Pushele()                 //进栈
        {
            string x;
            x = textBox2.Text.Trim();
            if (x == "")
                label2.Text = "请输入进栈元素";
            else
            {
                if (sq.Push(x))
                {
                    Display();
                    label2.Text = "进栈成功，进栈元素：" + x;
                    textBox2.Text = "";
                }
                else label2.Text = "栈满，进栈失败";
            }
        }

        private void Popele()            //出栈
        {
            string x = "";
            if (sq.Pop(ref x))
            {
                textBox2.Text = "";
                Display();
                label2.Text = "出栈成功，出栈元素：" + x;
            }
            else label2.Text = "空栈，出栈失败";
        }

        private void GetTopele()           //得到栈顶元素
        {
            string x = "";
            if (sq.GetTop(ref x))
            {
                textBox2.Text = "";
                Display();
                label2.Text = "取栈顶元素成功,栈顶元素：" + x;
                textBox2.Text = "";
            }
            else label2.Text = "空栈，取栈顶元素失败";
        }

        private bool Match(string str)       //括号匹配
        {
            int j;
            string x = "";
            SqStackClass st = new SqStackClass();
            for (j = 0; j < str.Length; j++)
            {
                if (str[j] == '(')
                    st.Push("(");
                else if (str[j] == ')')
                {
                    if (!st.StrackEmpty())
                        st.Pop(ref x);
                    else
                        return false;
                }
            }
            if (st.StrackEmpty())
                return true;
            else
                return false;
        }

        private bool Palindrome(string str)      //回文判断
        {
            int i; string x = "";
            SqStackClass st = new SqStackClass();
        
                for (i = 0; i < str.Length; i++)
                {
                    x = str[i].ToString();
                    st.Push(x);
                }
                for (i = 0; i < str.Length; i++)
                {
                    st.Pop(ref x);
                    if (string.Compare(str[i].ToString(), x) != 0)
                        return false;
                }
                return true;
        }

        private void SetQueSize()      //设置队列大小
        {
            int n;
            if (textBox2.Text == "")
            {
                label2.Text = "Please enter a size";
                return;
            }
            try
            {
                n = Convert.ToInt16(textBox2.Text.Trim());
            }
            catch (Exception err)
            {
                label2.Text = "The size is WRONG! Please try again!";
                return;
            }
            qu.SetSize(n);
            label2.Text = "The size is set to " + (n - 1);
        }

        private void EnQueue()        //进队
        {
            string x;
            x = textBox2.Text.Trim();
            if (x == "")
                label2.Text = "You Must Be Enter A Element!";
            else
            {
                if (qu.enQueue(x))
                {
                    DisplayQue();
                    label2.Text = "Enter Queue Success! The num is:" + x;
                    textBox2.Text = "";
                }
                else
                {
                    label2.Text = "Enter queue failed cause the queue is fulled";
                    textBox2.Text = "";
                }
            }
        }

        private void EnQueueLink()     //进队
        {
            string x;
            x = textBox2.Text.Trim();
            if (x == "")
                label2.Text = "You Must Be Enter A Element!";
            else
            {
                lq.enQueue(x);
                DisplayQueLink();
                label2.Text = "Enter Queue Success! The num is:" + x;
                textBox2.Text = "";
            }
        }

        private void DeQueue()      //出队
        { 
            string x = "";
            if (qu.deQueue(ref x))
            {
                DisplayQue();
                label2.Text = "Dequeue success. The num is:" + x;
                textBox2.Text = "";
            }
        }
         
        private void DeQueueLink()     //出列
        {
            string x = "";
            if (lq.deQueue(ref x))
            {
                DisplayQueLink();
                label2.Text = "Dequeue success. The num is:" + x;
                textBox2.Text = "";
            }
        }

        private void GetCount()            //返回队列长度
        {
            int n = qu.GetCount();
            textBox2.Text = n.ToString();
            label2.Text = "";                           
        }

        private void GetCountLink()          //返回队列长度  
        {
            int n = lq.GetCount();
            textBox2.Text = n.ToString();
            label2.Text = "";
        }

        public shiyan2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Empty";
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            if (stack.Checked)
            {
                if (i == 0)
                {
                    Pushele();
                }
                else if (i == 1)
                {
                    Popele();
                }
                else if (i == 2)
                {
                    GetTopele();
                }
                else if (i == 3)
                {
                    string str;
                    str = textBox2.Text.Trim();
                    if (str == "")
                    {
                        label2.Text = "请输入待判断的字符串";
                    }
                    else
                    {
                        if (Match(str))
                            label2.Text = "匹配";
                        else
                            label2.Text = "不匹配";
                    }
                }
                else if (i == 4)
                {
                    string str;
                    str = textBox2.Text.Trim();
                    if (str == "")
                    {
                        label2.Text = "请输入待判断的字符串";
                    }
                    else
                    {
                        if (Palindrome(str))
                            label2.Text = "是回文";
                        else
                            label2.Text = "不是回文";
                    }
                }
            }
            else if (queue.Checked)
            {
                if (i == 0)
                {
                    SetQueSize();
                }
                else if (i == 1)
                {
                    EnQueue();
                }
                else if (i == 2)
                {
                    DeQueue();
                }
                else if (i == 3)
                {
                    GetCount();
                }
            }
            else if (linkqueue.Checked)
            {
                if (i == 0)
                {
                    EnQueueLink();
                }
                else if (i == 1)
                {
                    DeQueueLink();
                }
                else if(i == 2)
                {
                    GetCountLink();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void stack_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] a = { "Push", "Pop", "Get Top", "Parentheses Match", "Palindrome Test" };
            comboBox1.Items.AddRange(a);
        }

        private void queue_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] a = { "Set Queue Size", "Enqueue", "Dequeue", "Get Count"};
            comboBox1.Items.AddRange(a);
        }

        private void linkqueue_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string[] a = { "Enqueue", "Dequeue", "Get Count"};
            comboBox1.Items.AddRange(a);
        }
    }

}

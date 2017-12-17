using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjjg
{
    class SqStackClass
    {
        const int MaxSize = 100;
        public string[] data;
        public int top;

        public SqStackClass()
        {
            data = new string[MaxSize];
            top = -1;
        }

        public bool StrackEmpty()  //判断栈是否为空
        {
            return (top == -1);
        }

        public bool Push(string x)  //进栈
        {
            if (top == MaxSize - 1)
                return false;             //栈满返回false
            top++;
            data[top] = x;
            return true;
        }

        public bool Pop(ref string e)   //出栈
        {
            if (StrackEmpty())
                return false;          //栈为空时，溢出，返回false
            e = data[top];
            top--;
            return true;
        }

        public bool GetTop(ref string e)      //取栈顶元素
        {
            if (StrackEmpty())             //栈为空时，溢出，返回false
                return false;
            e = data[top];
            return true;
        }

        public string DispStack()           //输出栈中元素构成的字符串
        {
            int i; string mystr = "";
            if (StrackEmpty())
                mystr = "空栈";
            else
            {
                for (i = 0; i < top; i++)
                    mystr += data[i] + ",";
                mystr += data[top];
            }
            return mystr;
        }
    }
}

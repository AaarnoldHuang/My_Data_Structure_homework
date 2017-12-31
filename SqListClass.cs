using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjjg
{
    class SqListClass                  //顺序表类
    {
        const int MaxSize = 100;
        public string[] data;        //存放顺序表中的元素
        public int length;           //存放顺序表的长度

        public SqListClass()               //构造函数
        {
            data = new string[MaxSize];
            length = 0;
        }

        public void CreatList(string[] split)         //建立顺序表
        {
            int i;
            for (i = 0; i < split.Length; i++)
                data[i] = split[i];
            length = i;
        }

        public string DispList()                 //显示顺序表
        {
            int i;
            if (length > 0)
            {
                string mystr = data[0];
                for (i = 1; i < length; i++)
                    mystr += " " + data[i];
                return mystr;
            }
            else return "空串";
        }

        public int ListLength()              //获得顺序表的长度
        { return length; }

        public bool GetElem(int i, ref string e)       //求某序号的元素值
        {
            if (i < 1 || i > length)
                return false;
            e = data[i - 1];
            return true;
        }

        public int LocateElem(string e)               //求某元素的序号
        {
            int i = 0;
            while (i < length && string.Compare(data[i], e) != 0)
                i++;
            if (i >= length)
                return 0;
            else
                return i + 1;
        }

        public bool ListInsert(int i, string e)           //插入元素
        {
            int j;
            if (i < 1 || i > length + 1)
                return false;
            for (j = length; j >= i; j--)
                data[j] = data[j - 1];
            data[i - 1] = e;
            length++;
            return true;
        }

        public bool ListDelete(int i, ref string e)          //删除元素
        {
            int j;
            if (i < 1 || i > length)
                return false;
            e = data[i];
            for (j = i - 1; j < length - 1; j++)
                data[j] = data[j + 1];
            length--;
            return true;
        }
    }
}

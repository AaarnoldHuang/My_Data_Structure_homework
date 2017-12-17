using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjjg
{
    class SqQueueClass
    {
        const int MaxSize = 100;
        public string[] data;
        public int front, rear, QueueSize;

        public SqQueueClass()
        {
            data = new string[MaxSize];
            front = rear = 0;
            QueueSize = 5;
        }

        public bool QueueEmpty()        //判断队列是否为空
        {
            return (front == rear);
        }

        public bool enQueue(string e)            //进入队列
        {
            if ((rear + 1) % QueueSize == front)
                return false;
            rear = (rear + 1) % QueueSize;
            data[rear] = e;
            return true;
        }

        public bool deQueue(ref string e)      //出对列
        {
            if (front == rear)
                return false;
            front = (front + 1) % QueueSize;
            e = data[front];
            return true;
        }

        public string DisQueue()       //输出队列中元素构成的字符串
        {
            int i;
            string mystr = "";
            if (front == rear)
                mystr = "Empty Queue";
            else
            {
                i = (front + 1) % QueueSize;
                while (i != rear)
                {
                    mystr += data[i] + ",";
                    i = (i + 1) % QueueSize;
                }
                mystr += data[rear];
            }
            return mystr;
        }

        public int GetCount()            //返回队列中的元素个数
        {
            return ((rear - front + QueueSize) % QueueSize);
        }

        public void SetSize(int n)       //设置队列长度
        {
            QueueSize = n;
        }
    }
}

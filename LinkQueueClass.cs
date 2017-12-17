using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjjg
{
    class LinkNode                //链队节点类
    {
        public string data;      //存放数据元素
        public LinkNode next;    //指向下一结点的指针
        public LinkNode front;   //指向队头的指针
        public LinkNode rear;  //指向队尾的指针
    }

    class LinkQueueClass
    {
        LinkNode Q = new LinkNode();

        public LinkQueueClass()
        {
            Q.front = null;
            Q.rear = null;
        }

        public bool QueueEmpty()         //判断队列是否为空
        {
            return (Q.rear == null);
        }

        public void enQueue(string e)         //进队列
        {
            LinkNode p = new LinkNode();
            p.data = e;
            p.next = null;
            if (Q.rear == null)
                Q.front = Q.rear = p;
            else
            {
                Q.rear.next = p;
                Q.rear = p;
            }
        }

        public bool deQueue(ref string e)       //出队列
        {
            LinkNode p;
            if (Q.rear == null)
                return false;
            p = Q.front;
            if (Q.front == Q.rear)
                Q.front = Q.rear = null;
            else
                Q.front = Q.front.next;
            e = p.data;
            p = null;
            return true;
        }

        public int GetCount()              //得到队列中元素个数
        {
            int n = 0;
            LinkNode p = Q.front;
            while (p != null)
            {
                n++;
                p = p.next;
            }
            return n;
        }

        public string DispQueue()       //将所有元素构成字符串返回
        {
            LinkNode p = Q.front;
            string str = "";
            if (Q.rear == null)
                str = "空队";
            else
            {
                while (p.next != null)
                {
                    str += p.data + ",";
                    p = p.next;
                }
                str += p.data;
            }
            return str;
        }
    }
}

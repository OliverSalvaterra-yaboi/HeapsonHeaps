using System;
using System.Collections.Generic;
using System.Text;

namespace HeapsonHeaps
{
    class Heap
    {
        public List<int> list = new List<int>();
        public Heap() { }

        public int Count => list.Count;

        public void insert(int num)
        {
            list.Add(num);

            up(list.Count - 1);
        }

        public void up(int i)
        {
            if(i <= 0)
            {
                return;
            }

            if(list[i] < list[(i - 1)/2])
            {
                int temp = list[(i - 1)/2];
                list[(i - 1) / 2] = list[i];
                list[i] = temp;
                i = (i-1)/2;
            }
            else
            {
                return; 
            }

            up(i);
        }

        public int pop()
        {
            int temp = list[0];
            list[0] = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            down(0);

            return temp;
        }

        public void down(int i)
        {
            if(i*2 + 1 > list.Count-1)
            {
                return;
            }

            if (list[i] > list[i * 2 + 1])
            {
                int temp = list[i];
                list[i] = list[i * 2 + 1];
                list[i * 2 + 1] = temp;
                i = i * 2 + 1;
            }
            else if (i * 2 + 2 < list.Count && list[i] > list[i * 2 + 2])
            {
                int temp = list[i];
                list[i] = list[i * 2 + 2];
                list[i * 2 + 2] = temp;
                i = i * 2 + 2;
            }
            else
            {
                return;
            }

            down(i);
        }
    }
}

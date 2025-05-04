using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_soulution_ITI
{
    internal class DaynamicStack
    {
        int tos;
        int size;
        int[] arr;

        private static int Counter = 0;

        public static int GetCounter()
        {
            return Counter;
        }

        public DaynamicStack()
        {
            Counter++;
            tos = 0;
            size = 3;
            arr = new int[size];
        }

        public DaynamicStack(int _size)
        {
            Counter++;
            tos = 0;
            size = _size;
            arr = new int[size];
        }

        public void Push(int value)
        {
            if (!IsFull())
            {
                arr[tos] = value;
                tos++;
            }
            else
            {
                Console.WriteLine("Full");
            }
        }

        public int Pop()
        {
            int result = -1111;
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
            }
            else
            {
                Console.WriteLine("Empty");
            }
            return result;
        }


        public bool IsFull()
        {
            return tos == size;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_soulution_ITI
{
    class GenStack<T>
    {
        int tos;
        int size;
        T[] arr;

        private static int Counter = 0;

        public static int GetCounter()
        {
            return Counter;
        }
  
        public GenStack()
        {
            Counter++;
            tos = 0;
            size = 3;
            arr = new T[size];
        }

        public GenStack(int _size)
        {
            Counter++;
            tos = 0;
            size = _size;
            arr = new T[size];
        }

        public void Push(T value)
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

        public T Pop()
        {
            T result = default;
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

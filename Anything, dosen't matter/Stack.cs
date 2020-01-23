using System;

namespace Anything__dosen_t_matter
{
    class Stack<T>
    {
        private T[] stack;
        private int ptr;
        public Stack(int size)
        {
            stack = new T[size];
        }

        public int Length() => ptr;

        public void Push(T value)
        {
            if (ptr < stack.Length) stack[ptr++] = value;
            else Console.WriteLine("Stack is full");
        }

        public T Pop()
        {
            T ret = default;
            if (ptr > 0) ret = stack[ptr-- - 1];
            else Console.WriteLine("Stack is empty");
            return ret;
        }

        public T Peek()
        {

            T ret = default;
            if (ptr > 0) ret = stack[ptr - 1];
            else Console.WriteLine("Stack is empty");
            return ret;
        }
    }
}

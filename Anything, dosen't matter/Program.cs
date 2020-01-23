using System;

namespace Anything__dosen_t_matter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(7);
            bool exit = false;
            do
            {
                Console.Write("> ");
                string[] input = Console.ReadLine().Split(" ");
                switch (input[0])
                {
                    case "length":
                        Console.WriteLine(stack.Length());
                        break;
                    case "push":
                        stack.Push(input[1][0]);
                        break;
                    case "pop":
                        Console.WriteLine(stack.Pop());
                        break;
                    case "peek":
                        Console.WriteLine(stack.Peek());
                        break;
                    case "q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid command");
                        break;
                }
                Console.WriteLine();
            } while (!exit);
        }
    }
}

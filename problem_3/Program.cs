using System;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            string comand;

            do
            {
                comand = Console.ReadLine();
                string[] items = comand.Split(' ');

                switch (items[0])
                {
                    case "Push":
                        int[] element = items.Skip(1).Select(int.Parse).ToArray();
                        stack.Push(element);
                        break;
                    case "Pop":
                        stack.Pop();
                        foreach (var item in stack)
                        {
                            Console.Write(item);
                        }
                        break;
                    default:
                        throw new Exception();
                }

            }
            while (comand != "End");

            Console.ReadLine();
        }
    }
}
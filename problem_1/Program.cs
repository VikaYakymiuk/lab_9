using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace problem_1
{
    class Program
    {
        static void Main()
        {
            ListyIterator<string> listyIterator = null;

            string comand;

            do
            {
                comand = Console.ReadLine();
                string[] select = comand.Split(' ');

                switch (select[0])
                {
                    case "Create":
                        listyIterator = new ListyIterator<string>(select.Skip(1).ToArray());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    default:
                        throw new Exception();
                        break;
                }
            }
            while (comand != "End");

            Console.ReadLine();
        }
    }
}
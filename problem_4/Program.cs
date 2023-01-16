using System;

class Program
{
    static void Main()
    {

        int[] jumpfrog = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Frog frog = new Frog(jumpfrog);

        Console.WriteLine(String.Join(" ", frog));
    }
}
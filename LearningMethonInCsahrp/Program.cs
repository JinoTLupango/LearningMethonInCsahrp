using System;

class Program
{
    static void Method(string name)
    {
        Console.WriteLine("Hello, " + name + "! Nice to meet you!");
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        Method(userName);
    }
}

using System;

class Program
{
    static void Method(string name, int age)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);   

    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Method(name, age);
    }
}

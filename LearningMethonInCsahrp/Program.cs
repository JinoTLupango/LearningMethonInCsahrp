using System;
using System.Diagnostics;

class Program
{
    static void UserInfo(string name, int age)
    {
        Console.WriteLine("\n--- User Info ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
    static string FavoriteLangauge(string langauge)
    {
        return "Your favorite programming langauge is " + langauge + "!";
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter you favorite langauge: ");
        string lang = Console.ReadLine();

        UserInfo(name, age);
        string message = FavoriteLangauge(lang);
        Console.WriteLine(message);
    }
}

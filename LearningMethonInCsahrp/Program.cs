using System;

class Program
{
    static int AddNum(int a, int b)
    {
        return a + b;
    }
    static void Main()
    {
        int result = AddNum(5, 2);
        Console.WriteLine("The sum is: " + result);
    }
}

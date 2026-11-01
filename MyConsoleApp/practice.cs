using System;

namespace MyConsoleApp;

class practice
{
static void Main(string[] args)
    {
        Random random = new Random();
        int num1 = random.Next(1,13);
        Console.WriteLine(num1);
        Console.ReadKey();

    }
}

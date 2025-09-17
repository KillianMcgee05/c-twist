namespace _205_Csharp_twist;
using System;
class Program
{
    static void Main(string[] args)

    {
        //variables
        string name;
        string hobby;
        string answer;

        Console.WriteLine("Hello! what is your name?");
        Console.WriteLine("************************************************");
        name = Console.ReadLine();
        Console.WriteLine("Whats your favorite hobby?");
        Console.WriteLine("************************************************");
        hobby = Console.ReadLine();
        Console.WriteLine("************************************************");
        Console.WriteLine($"Hi, {name}! {hobby}, huh? thats really cool!");
        Console.WriteLine($"Speaking of cool, {name}, do YOU wanna see something cool?");
        answer = Console.ReadLine();

        if (answer == "Yes" || answer == "Y")
        {
            Console.WriteLine("      -----");
            Console.WriteLine("     |     |");
            Console.WriteLine("     | 0 0 |            tada!");
            Console.WriteLine("     |  U  |");
            Console.WriteLine("      -----");
            Console.WriteLine("   -----|-----");
            Console.WriteLine("        |");
            Console.WriteLine("        |");
            Console.WriteLine("       / |");
            Console.WriteLine("      /  |");
            Console.WriteLine("     /   |");
        }
         else
            {
                //New: fun message if they say anything else
                Console.WriteLine("Aww, maybe next time then!");
            }
    }
}


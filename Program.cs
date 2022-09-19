int Main()
{
    int x = 0, y = 1, z = 2;
    string key = "1";
    Console.WriteLine("Enter 1 to see which from two numbers is larger.");
    Console.WriteLine("Enter 2 to see which number from three is larger.");
    Console.WriteLine("Enter 3 to find out if entered number is even or odd.");
    Console.WriteLine("Enter 4 to see all even numbers between zero and N.");
    Console.WriteLine("Enter 0 to terminate the program.");
    key = Console.ReadLine();
    switch(key)
    {
        case "1":
            Console.WriteLine("Enter first number:");
            key = Console.ReadLine();
            x = System.Int32.Parse(key);
            Console.WriteLine("Enter second number:");
            key = Console.ReadLine();
            y = System.Int32.Parse(key);
            Console.WriteLine($"Entered numbers {x} and {y}.\nMax number is {Homework.TwoMax(x,y)}");
            break;
        case "2":
            Console.WriteLine("Enter first number:");
            key = Console.ReadLine();
            x = System.Int32.Parse(key);
            Console.WriteLine("Enter second number:");
            key = Console.ReadLine();
            y = System.Int32.Parse(key);
            Console.WriteLine("Enter third number:");
            key = Console.ReadLine();
            z = System.Int32.Parse(key);
            Console.WriteLine($"Entered numbers {x}, {y} and {z}.\nMax number is {Homework.ThreeMax(x,y,z)}");
            break;
        case "3":
            Console.WriteLine("Enter number:");
            key = Console.ReadLine();
            x = System.Int32.Parse(key);
            if(Homework.EvenOrNot(x))
                Console.WriteLine($"Number {x} is even.");
            else
                Console.WriteLine($"Number {x} is uneven.");
            break;
        case "4":
            Console.WriteLine("Enter number:");
            key = Console.ReadLine();
            x = System.Int32.Parse(key);
            Homework.AllEven(x);
            break;
        case "0":
            return 0;
    }

    Main();
    return 0;
}

Main();
class Homework
{
    public static int TwoMax(int x = 0, int y = 1)
    {
        return x > y ? x : y;
    }

    public static int ThreeMax(int x = 0, int y = 1, int z = 2)
    {
        if (x > y && x > z) {return x;}
        if (y > x && y > z) {return y;}
        return z;
    }

    public static bool EvenOrNot(int x = 0)
    {
        return x % 2 == 0 ? true : false;
    }

    public static void AllEven(int n = 0)
    {
        for(int i = 0; i < n; i += 2)
        {
            Console.Write($"| {i} |");
        }
        Console.WriteLine();
    }
}


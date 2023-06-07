namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        //int firstValue = new Random().Next(-10, 10);

        //Console.WriteLine(firstValue);
        //if (firstValue > 0)
        //    firstValue++;

        //else if (firstValue < 0)
        //    firstValue -= 2;
        //else
        //    firstValue = 10;
        //Console.WriteLine(firstValue);


        //int oneNumber = new Random().Next(-10, 10);
        //int secondNumber = new Random().Next(-10, 10);
        //int thirdNumber = new Random().Next(-10, 10);
        //Console.WriteLine(oneNumber + ", " + secondNumber + ", " + thirdNumber);

        //int n = 3;

        //if (oneNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        //    Console.WriteLine(n);
        //else if (oneNumber <= 0 && secondNumber <= 0 && thirdNumber <= 0)
        //    Console.WriteLine(n - 3);
        //else if (oneNumber <= 0 || secondNumber <= 0 && thirdNumber <= 0)
        //    Console.WriteLine(n - 2);
        //else if (oneNumber <= 0 && secondNumber <= 0 || thirdNumber <= 0)
        //    Console.WriteLine(n - 2);
        //else if (oneNumber <= 0 || secondNumber <= 0 || thirdNumber <= 0)
        //    Console.WriteLine(n - 2);
        //else if (oneNumber <= 0 && thirdNumber <= 0)
        //    Console.WriteLine(n - 2);
        //else if (secondNumber <= 0 && thirdNumber <= 0)
        //    Console.WriteLine(n - 2);
        //else
        //    Console.WriteLine(n - 1);

        int a = new Random().Next(0, 10);
        int b = new Random().Next(0, 10);
        Console.WriteLine(a + ", " + b);
        if (a == b)
            a = 0;
        else
            a += b;
            b = a;
        Console.WriteLine(a + ", " + b);
    }
}


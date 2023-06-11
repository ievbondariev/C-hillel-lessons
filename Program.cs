namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        // 1. Задається ціле число. Якщо він позитивний, додайте до нього 1; якщо негативне, відніміть з нього 2;
        //Якщо нуль, то замініть його на 10. Виведіть отримане число.
        int firstValue = new Random().Next(-10, 10);
        Console.WriteLine("Start value: " + firstValue);
        if (firstValue > 0)
            firstValue++;
        else if (firstValue < 0)
            firstValue -= 2;
        else
            firstValue = 10;
        Console.WriteLine("End value: " + firstValue + "\n");

        // 2. Дано три цілих числа. Знайдіть кількість додатних чисел у вихідному наборі
        int oneNumber = new Random().Next(-10, 10);
        int secondNumber = new Random().Next(-10, 10);
        int thirdNumber = new Random().Next(-10, 10);
        Console.WriteLine("3 random numbers : " + oneNumber + ", " + secondNumber + ", " + thirdNumber);

        int countPositiv = 0;
        if (oneNumber > 0)
            countPositiv++;
        if (secondNumber > 0)
            countPositiv++;
        if (thirdNumber > 0)
            countPositiv++;
        Console.WriteLine("Number of positive: " + countPositiv + "\n");

        // 3. Дано три цілих числа. Знайдіть число позитивних і кількість негативних чисел у вихідному наборі. 
        int countNegative = 0;
        if (oneNumber < 0)
            countNegative++;
        if (secondNumber < 0)
            countNegative++;
        if (thirdNumber < 0)
            countNegative++;
        Console.WriteLine("Number of positive: " + countPositiv);
        Console.WriteLine("Number of negative: " + countNegative + "\n");

        // 4. Дано дві змінні цілочисельного типу: A і B.
        // Якщо їх значення не рівні, то призначте суму цих значень кожній змінній,
        // а якщо вони є, то привласніть змінним нульові значення. Вивести нові значення змінних A і B.        
        int a = new Random().Next(0, 10);
        int b = new Random().Next(0, 10);
        Console.WriteLine("Start values: " + a + ", " + b);

        if (a == b)
            a = 0;
        else
            a += b;
        b = a;
        Console.WriteLine("End values: " + a + ", " + b + "\n");

        // 5. Напишіть програму, яка перевіряє число на парність.
        int numForChckParity = new Random().Next();
        int parity = numForChckParity % 2;

        if (parity == 0 && numForChckParity != 0)
            Console.WriteLine("Parity of number " + numForChckParity + " = " + true);
        else
            Console.WriteLine("Parity of number " + numForChckParity + " = " + false + "\n");

        // 6. Одиниці довжини нумеруються наступним чином: 1 - дециметр, 2 - кілометр, 3 - метр, 4 - міліметр, 5 - сантиметр.
        // Наведено номер одиниці довжини (ціле число в діапазоні 1-5) і довжину відрізка в цих одиницях (дійсне число).
        // Знайдіть довжину відрізка в метрах. 
        int numberOfLenght = new Random().Next(1, 5);
        double length = new Random().Next(1, 1000);
        Console.WriteLine("Number of case: " + numberOfLenght);
        Console.WriteLine("Lenght in choosed case: " + length);

        switch (numberOfLenght)
        {
            case 1:
                double lengthMetersInDecimeters = length / 10;
                Console.WriteLine("Case in decimeters: show lenght in meters - " + lengthMetersInDecimeters);
                break;
            case 2:
                double lengthMetersInKilometers = length * 1000;
                Console.WriteLine("Case in kilometers: show lenght in meters - " + lengthMetersInKilometers);
                break;
            case 3:
                double lengthMetersInMeters = length * 1;
                Console.WriteLine("Case in meters: show lenght in meters - " + lengthMetersInMeters);
                break;
            case 4:
                double lengthMetersInMilimeters = length / 1000;
                Console.WriteLine("Case in milimeters: show lenght in meters - " + lengthMetersInMilimeters);
                break;
            case 5:
                double lengthMetersInCentimeters = length / 100;
                Console.WriteLine("Case in centimeters: show lenght in meters - " + lengthMetersInCentimeters);
                break;
        }
        Console.WriteLine("\n");

        // 7. Робот може рухатися в чотирьох напрямках (північ, захід, південь, схід) і отримувати три цифрові команди: 0 - продовжувати рух, 1 - повернути ліворуч, -1 - повернути праворуч.
        // Символ C - початковий напрямок робота, а ціле число N - послана йому команда.
        // Відобразіть напрямок робота після виконання отриманої команди.
        switch (new Random().Next(-1, 1))
        {
            case 0:
                Console.WriteLine("Nord");
                break;
            case 1:
                Console.WriteLine("West");
                break;
            case -1:
                Console.WriteLine("East");
                break;
            default:
                Console.WriteLine("Stay");
                break;
        }
        Console.WriteLine("\n");


        // 8. Дано ціле число в діапазоні 20-69, яке визначає вік (в роках).
        // Виведіть рядок опису зазначеного віку, забезпечивши правильне узгодження числа зі словом «рік»,
        // наприклад: 20 - «двадцять років», 32 - «тридцять два роки», 41 - «сорок один рік»
        int age = new Random().Next(20, 69);
        int yearsAge = age % 10;

        if (yearsAge > 4 || yearsAge == 0)
            Console.WriteLine("Вік: " + age + " років");
        else if (yearsAge == 1)
            Console.WriteLine("Вік: " + age + " рік");
        else
            Console.WriteLine("Вік: " + age + " роки");

    }
}




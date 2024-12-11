using System;

class Program
{
    static void Main(string[] args)
    {
        // Приклад для double
        double a = 5.5, b = 10.2;
        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After Swap: a = {a}, b = {b}\n");

        // Приклад для string
        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");
    }

    // Універсальний метод для обміну значеннями
    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}

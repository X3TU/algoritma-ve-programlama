//1. Dışarıdan girilen 3x3 lük bir matrisi, matris biçiminde ekrana yazdırınız.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("sayı giriniz");

        int say1 = Convert.ToInt32(Console.ReadLine());
        int say2 = Convert.ToInt32(Console.ReadLine());
        int say3 = Convert.ToInt32(Console.ReadLine());
        int say4 = Convert.ToInt32(Console.ReadLine());
        int say5 = Convert.ToInt32(Console.ReadLine());
        int say6 = Convert.ToInt32(Console.ReadLine());
        int say7 = Convert.ToInt32(Console.ReadLine());
        int say8 = Convert.ToInt32(Console.ReadLine());
        int say9 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{say1},{say2},{say3}\n{say4},{say5},{say6}\n{say7},{say8},{say9}");
    }
}
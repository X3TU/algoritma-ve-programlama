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



        Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", say1,say2,say3,say4,say5,say6,say7,say8,say9);
    }
}
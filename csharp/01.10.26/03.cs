//3. Dışarıdan girilen kelimeleri yan yana yazdırınız.

using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("1.kelimeyi gir");
        string kelime1 = Console.ReadLine() ?? "";  //BUrda soru isareti ve tirnak isareti fln eger bos deger(null) girilirse patlamamasi icin
        Console.WriteLine("2.eklimeyi gir");
        string kelime2 = Console.ReadLine() ?? "";
        Console.WriteLine($"{kelime1} {kelime2}");

    }
}

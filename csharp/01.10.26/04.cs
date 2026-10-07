//4. Dışarıdan girilen ondalıklı sayıları virgülden sonra 1 basamaklı olarak yazdırınız.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ondalıklı sayı giriniz");

        float girdi = float.Parse(Console.ReadLine());

        Console.WriteLine("{0:F1}", girdi); // asil olay burda, F1 demek F fixed point yani virgulden sonraki basmaak sayısı sabit, F1 dedigimiz icinde virgulden sonra bir basamak gosterıyor, F2 yazsaydık iki basamak gostercekti.

    }
    
}
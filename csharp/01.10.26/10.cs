/*
10. Dışarıdan girilen iki sayı ve bir string değeri aşağıdaki şekilde ekrana yazdırınız. İki nokta üst üste işaretlerinin aynı sırada olmasına dikkat ediniz.

1.Sayı   :  12
2.Sayı   :  1234

Adınız   :  Abdullah Yunus
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1.sayıyı giriniz: ");
        int say1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.sayıyı giriniz: ");
        int say2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("isim soyisim gir: ");
        string isim = Console.ReadLine();

        Console.WriteLine("1.sayı\t:\t{0}\n2.sayı\t:\t{1}\n\nAdınız\t:\t{2}", say1,say2,isim);


    }
}

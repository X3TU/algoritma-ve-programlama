//8. Dışarıdan girilen 3 sayıyı "birinci sayı = 4, ikinci sayı = 6 üçüncü sayı = 7" şeklinde ekrana yazdırınız.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.sayıyı gir");
        int say1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("2.sayıyı gir");
        int say2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("3.sayıyı gir");
        int say3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("birinci sayı = {0}\nikinci sayı = {1}\nüçüncü sayı = {2}", say1,say2,say3);

    }
}

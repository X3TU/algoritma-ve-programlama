//7. Dışarıdan girilen char tipindeki verinin 'E' olup olmadığını kontrol ediniz.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("karakter giriniz");
        char girdi = char.Parse(Console.ReadLine());    //readline bitek string okuyo oyuzden chara cevirmek gerekiyo convert.tochar o ayak
        Console.WriteLine(girdi == 'E');
    }
}

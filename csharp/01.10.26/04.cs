//4. Dışarıdan girilen ondalıklı sayıları virgülden sonra 1 basamaklı olarak yazdırınız.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen ONDALIKLI SAYI giriniz ve basamağı NOKTA (.) ile ayirinz virgulle degil !!!!");
        string s = Console.ReadLine();
        float girdi;

        if (float.TryParse(s, out girdi))   //burda eger s inputuna float dısında deger str fln girilirse hata mesaji yazdiriyoruz eger normal float girerse sıkıntı yok s == girdi degiskenine donusuyo direkt
        {
            Console.WriteLine("{0:F1}", girdi);
        }
        else
        {
            Console.WriteLine("SAYI GIRMENIZ GEREKIYORDU!!");
        }
    }
}
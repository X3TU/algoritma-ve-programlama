//7. Dışarıdan girilen char tipindeki verinin 'E' olup olmadığını kontrol ediniz.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("karakter giriniz");
        char girdi = Convert.ToChar(Console.ReadLine());    //readline bitek string okuyo oyuzden chara cevirmek gerekiyo convert.tochar o ayak
        if (girdi == 'E')       //burda da stringler cift tirnakla olması gerekıyomus charlar tek tırnak onemli !
        {
            Console.WriteLine("Evet dogru girdigin harf buyuk E");
        }
        else
        {
            Console.WriteLine("hayir buyuk E harfini girmedin masmalesef");
        }
    }
}

//9. Dışarıdan girilen sayının genişliğini 5 yaparak ekrana yazdırınız. Örneğin dışarıdan girilen sayı =345 ise 00345 şeklinde yazdırılacak.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0:D5}", sayi);      //csharpta D format specifieri direkt genisligi belirleyip kalan rakamları 0 yapıyor. en baştaki 0 index sayısı eksik rakamları doldurmayla alakasi yok
    }
}

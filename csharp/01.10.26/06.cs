//6. Sistem tarihini gün ve yıl yan yana olarak ekrana yazdırınız.

using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime suan = DateTime.Now;
        Console.WriteLine("{0:dd},{0:yyyy}", suan);
    }
}

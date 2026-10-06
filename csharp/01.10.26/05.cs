//5. Sistem saatini saat ve dakika cinsinden yazdırınız.

using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime suan = DateTime.Now;
        Console.WriteLine("{0:HH:mm}", suan);
        
    }
}

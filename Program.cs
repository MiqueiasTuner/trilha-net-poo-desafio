using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("99999-1111", "Nokia 3310", "123456789", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("--------------------------------");

        Smartphone iphone = new Iphone("99999-2222", "iPhone 15", "987654321", 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}

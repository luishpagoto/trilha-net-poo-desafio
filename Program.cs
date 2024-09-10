using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância de Nokia
        Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111111111111", "16GB");
        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine();

        // Criando uma instância de Iphone
        Smartphone iphone = new Iphone("654321", "iPhone 12", "222222222222222", "128GB");
        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}

using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone

        Console.WriteLine("SmartPhone Nokia:");
        Smartphone nokia = new Nokia(numero: "12234323", modelo: "Modelo 1", imei: "121212", memoria: 256);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iPhone");
        Smartphone iphone = new Iphone(numero: "3434343", modelo: "Modelo 2", imei: "34432233", memoria: 500);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Youtube");
    }
}















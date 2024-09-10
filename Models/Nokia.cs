// Classe Nokia que herda de Smartphone
using DesafioPOO.Models;

public class Nokia : Smartphone
    {
        // Construtor que passa os parâmetros para a classe base
        public Nokia(string numero, string modelo, string imei, string memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
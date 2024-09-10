namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Classe Iphone que herda de Smartphone
    public class Iphone : Smartphone
    {
        // Construtor que passa os parâmetros para a classe base
        public Iphone(string numero, string modelo, string imei, string memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação do método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone.");
        }
    }
}
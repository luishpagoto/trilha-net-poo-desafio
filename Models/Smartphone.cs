namespace DesafioPOO.Models
{
    // Classe abstrata Smartphone
    public abstract class Smartphone
    {
        // Propriedades conforme o diagrama
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected string Memoria { get; set; }

        // Construtor que recebe os parâmetros e define as propriedades
        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos concretos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato a ser implementado pelas classes derivadas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
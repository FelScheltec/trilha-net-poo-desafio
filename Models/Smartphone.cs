namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; } // Adicione a propriedade Modelo
        public string SistemaOperacional { get; set; } // Adicione a propriedade SistemaOperacional

        public Smartphone(string numero, string modelo, string sistemaOperacional)
        {
            Numero = numero;
            Modelo = modelo; // Passe o modelo como parâmetro para a propriedade
            SistemaOperacional = sistemaOperacional; // Passe o sistema operacional como parâmetro para a propriedade
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}

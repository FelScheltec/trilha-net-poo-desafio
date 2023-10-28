namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    class nokia : Smartphone
    {
        public nokia (string numero, string modelo, string sistemaOperacional) : base(numero, modelo, sistemaOperacional)
            {

            }
            public nokia (string numero, string modelo, string sistemaOperacional, int memoria) : this(numero, modelo, sistemaOperacional)
        {
            Memoria = memoria;
        }

        public int Memoria{get;}

        // TODO: Sobrescrever o método "InstalarAplicativo"
            public override void InstalarAplicativo(string nomeApp)
            {
                Console.WriteLine($"Instalando o APP {nomeApp}");
            }
        
    }
}

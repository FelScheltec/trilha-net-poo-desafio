using System.ComponentModel;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    class iphone : Smartphone
    { 
            public iphone(string numero, string modelo, string sistemaOperacional) : base(numero, modelo, sistemaOperacional)
            {

            }

        public iphone(string numero, string modelo, string sistemaOperacional, int memoria) : this(numero, modelo, sistemaOperacional)
        {
            Memoria = memoria;
        }

        public int Memoria { get; }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o APP {nomeApp}");
        }
    }
}}

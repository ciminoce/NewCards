using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCards.Entidades.Entidades;
using NewCards.Entidades.Enums;

namespace NewCards.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaDeMazosDeCartas fabrica = new FabricaDeMazosDeCartas();
            var mazo = fabrica.CrearMazo(TipoCarta.Espaniola50);
            foreach (var carta in mazo.GetCartas())
            {
                Console.WriteLine(carta.ToString());
            }

            Console.ReadLine();
        }
    }
}

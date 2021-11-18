using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCards.Entidades.Enums;

namespace NewCards.Entidades.Entidades
{
    public abstract class Mazo
    {
        protected List<Carta> Cartas;
        protected int NumeroDeCartas;
        public Mazo(TipoCarta tipoCarta)
        {
            NumeroDeCartas =(int) tipoCarta;
            Cartas = new List<Carta>();
            if (tipoCarta==TipoCarta.Espaniola40 ||tipoCarta==TipoCarta.Espaniola50)
            {
                //Para tener los palos
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        Cartas.Add(new Carta()
                        {
                            Palo =((PalosBarajsEspaniolas) i).ToString(),
                            Numero = ((NumerosBarajaEspaniola)j).ToString()
                        });
                    }
                }
            }
            else
            {
                
            }
        }
        public List<Carta> GetCartas()
        {
            return Cartas;
        }
    }
}

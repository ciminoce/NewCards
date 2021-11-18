using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCards.Entidades.Enums;

namespace NewCards.Entidades.Entidades
{
    public class MazoCartasEspaniolas:Mazo
    {
        private readonly int CantidadDeCartas;
        public MazoCartasEspaniolas(TipoCarta tipoCarta) : base(tipoCarta)
        {
            CantidadDeCartas = tipoCarta.GetHashCode();
        }

        //public override string ToString()
        //{
        //    //StringBuilder sb = new StringBuilder();
        //    //sb.AppendLine($"Mazo de cartas españolas de {CantidadDeCartas}");
        //    //sb.AppendLine("Sus palos son:");
        //    //foreach (var palo in Palos)
        //    //{
        //    //    sb.AppendLine(palo.ToString());
        //    //}

        //    //return sb.ToString();
        //    ////return $"Mazo de cartas españolas de {CantidadDeCartas}";
        //}
    }
}

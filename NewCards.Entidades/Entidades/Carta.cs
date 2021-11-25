using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace NewCards.Entidades.Entidades
{
    public class Carta
    {
        public string Palo { get; set; }
        public string Numero { get; set; }
        public Image Imagen { get; set; }
        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }
}

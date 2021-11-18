using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCards.Entidades.Enums;

namespace NewCards.Entidades.Entidades
{
    public abstract class FabricaMazoAbstracta
    {
        public abstract Mazo CrearMazo(TipoCarta tipoCarta);
    }
}

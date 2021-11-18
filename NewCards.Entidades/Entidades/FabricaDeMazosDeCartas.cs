using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCards.Entidades.Enums;

namespace NewCards.Entidades.Entidades
{
    public class FabricaDeMazosDeCartas:FabricaMazoAbstracta
    {
        public override Mazo CrearMazo(TipoCarta tipoCarta)
        {
            switch (tipoCarta)
            {
                case TipoCarta.Espaniola40:
                    return new MazoCartasEspaniolas(tipoCarta);
                    
                case TipoCarta.Espaniola50:
                    return new MazoCartasEspaniolas(tipoCarta);
                case TipoCarta.FrancesaSinComodin:
                    return new MazoCartasFrancesas(tipoCarta);

                case TipoCarta.FrancesaConComodin:
                    return new MazoCartasFrancesas(tipoCarta);
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoCarta), tipoCarta, null);
            }
        }
    }
}

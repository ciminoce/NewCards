using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using NewCards.Entidades.Enums;

namespace NewCards.Entidades.Entidades
{
    public abstract class Mazo
    {
        protected List<Carta> Cartas;//Lista de las cartas
        protected int NumeroDeCartas;//Cantidad de cartas
        protected Image imagenCartas;//Imagen de las cartas
        protected int anchoImagen;
        protected int alturaImagen;
        protected int gapFila;
        protected int gapColumna;


        public Mazo(TipoCarta tipoCarta)
        {
            NumeroDeCartas =(int) tipoCarta;//Lo obtengo del código del tipo de carta
            Cartas = new List<Carta>();

            string[] palos; //array con los palos de la baraja
            string[] numeros;// array con los números de la baraja

            if (tipoCarta==TipoCarta.Espaniola40 ||tipoCarta==TipoCarta.Espaniola50)
            {
                palos = Enum.GetNames(typeof(PalosBarajaEspaniolas));
                numeros = Enum.GetNames(typeof(NumerosBarajaEspaniola));
                imagenCartas = new Bitmap(Properties.Resources.CartasEspaniolasConComodín);
                alturaImagen = 164;
                anchoImagen = 107;
                gapColumna = 0;
                gapFila = 0;
            }
            else
            {
                palos = Enum.GetNames(typeof(PalosBarajaFrancesa));
                numeros = Enum.GetNames(typeof(NumerosBajaraFrancesa));
                //imagenCartas = new Bitmap(Properties.Resources.CartasFrancesasEnFilaConComodin);
                //alturaImagen = 183;
                //anchoImagen = 130;
                imagenCartas = new Bitmap(Properties.Resources.NuevoCartasFrancesasConComodin);
                alturaImagen = 112;
                anchoImagen = 77;
                gapFila = 0;
                gapColumna = 0;
            }
            //Recorro el array de los palos de cada tipo de carta
            for (int paloIndex = 0; paloIndex < palos.Length; paloIndex++)
            {
                //Recorro el array de los números
                for (int numeroIndex = 0; numeroIndex < numeros.Length; numeroIndex++)
                {
                    //Manejo para recortar la imagen de la imagen general
                    Point x1 = new Point(numeroIndex * (anchoImagen + gapFila), paloIndex * (alturaImagen + gapColumna));
                    Rectangle section = Helper.CrearRectangulo(x1, new Size(anchoImagen, alturaImagen));
                    Bitmap imagenCartaTemp = Helper.CropImage(imagenCartas, section);

                    Carta carta = CrearCarta(palos[paloIndex], numeros[numeroIndex], imagenCartaTemp);
                    Cartas.Add(carta);
                    if (tipoCarta==TipoCarta.Espaniola40 &&(numeroIndex==7 ||numeroIndex==8))
                    {
                        Cartas.Remove(Cartas.Last());
                    }

                }

            }
            //Si es con comodines
            if (tipoCarta==TipoCarta.Espaniola50 || tipoCarta==TipoCarta.FrancesaConComodin)
            {
                Point x1 = new Point(0 * (anchoImagen + gapFila), 4 * (alturaImagen + gapColumna));
                Rectangle section = Helper.CrearRectangulo(x1, new Size(anchoImagen, alturaImagen));
                Bitmap imagenCartaTemp = Helper.CropImage(imagenCartas, section);
                Cartas.Add(new Carta()
                {
                    Numero = "Comodín",
                    Imagen = imagenCartaTemp

                });
                Cartas.Add(new Carta()
                {
                    Numero = "Comodín",
                    Imagen = imagenCartaTemp

                });

            }

        }

        private Carta CrearCarta(string palo, string numero, Bitmap imagenCartaTemp)
        {
            return new Carta()
            {
                Palo = palo,
                Numero = numero,
                Imagen = imagenCartaTemp
            };
        }

        public int GetCantidad()
        {
            return Cartas.Count;
        }
        public List<Carta> GetCartas()
        {
            return Cartas;
        }

        public void Barajar()
        {
            Random r = new Random(new Guid().GetHashCode());
            for (int indiceCarta = 0; indiceCarta < Cartas.Count; indiceCarta++)
            {
                int indiceAleatorio = r.Next(0, this.GetCantidad()-1);

                Carta cartaTemp = Cartas[indiceCarta];
                Cartas[indiceCarta] = Cartas[indiceAleatorio];
                Cartas[indiceAleatorio] = cartaTemp;
            }
        }
    }
}

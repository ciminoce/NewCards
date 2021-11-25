using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewCards.Entidades.Entidades;
using NewCards.Entidades.Enums;

namespace NewCards.Windows
{
    public partial class FrmVerCartas : Form
    {
        public FrmVerCartas()
        {
            InitializeComponent();
        }

        private TipoCarta tipoCarta;
        public void SetTipoCarta(TipoCarta tipoCarta)
        {
            this.tipoCarta = tipoCarta;
        }

        private Mazo mazo;
        private void FrmVerCartas_Load(object sender, EventArgs e)
        {
            FabricaDeMazosDeCartas fabrica = new FabricaDeMazosDeCartas();
            mazo = fabrica.CrearMazo(tipoCarta);
            MostrarCartas(mazo);
        }

        private void CrearBotonBarajar()
        {
            this.BarajarButton.Location = new System.Drawing.Point(1570, 840);
            this.BarajarButton.Name = "BarajarButton";
            this.BarajarButton.Size = new System.Drawing.Size(89, 49);
            this.BarajarButton.TabIndex = 1;
            this.BarajarButton.Text = "Barajar";
            this.BarajarButton.UseVisualStyleBackColor = true;
            this.BarajarButton.Click += new System.EventHandler(this.BarajarButton_Click);
            this.panel1.Controls.Add(BarajarButton);
        }

        private void MostrarCartas(Mazo mazo)
        {
            int contadorCartas = 0;
            int cantidadCartas = mazo.GetCantidad();
            int topeDeCartas = 0;
            int contadorFilas = 0;

            int gapColumna = 0;
            int gapFila = 0;
            int anchoPicture = 119;
            int alturaPicture = 182;

            if (cantidadCartas==40)
            {
                topeDeCartas = 10;
            }else if (cantidadCartas==50)
            {
                topeDeCartas = 12;
            }
            else
            {
                topeDeCartas = 13;
            }

            foreach (var carta in mazo.GetCartas())
            {
                Point point = CrearPunto(gapColumna, gapFila, anchoPicture, alturaPicture, contadorCartas,
                    contadorFilas);
                PictureBox pic = CrearPictureBox(point, anchoPicture, alturaPicture, carta.Imagen);
                
                AgregarPictureAlPanel(panel1, pic);
                contadorCartas++;
                if (contadorCartas == topeDeCartas)
                {
                    gapColumna = 0;
                    contadorFilas++;
                    contadorCartas = 0;
                    gapFila = 5;
                }
                else
                {
                    gapColumna = 5;
                }

            }
        }

        private void AgregarPictureAlPanel(Panel panel, PictureBox pic)
        {
            panel.Controls.Add(pic);
        }

        private PictureBox CrearPictureBox(Point point, int anchoPicture, int alturaPicture, Image cartaImagen)
        {
            return new PictureBox()
            {
                Location = point,
                Width = anchoPicture,
                Height = alturaPicture,
                Image = cartaImagen,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

        }

        private Point CrearPunto(int gapColumna, int gapFila, int anchoPicture, int alturaPicture, int contadorCartas, int contadorFilas)
        {
            return new Point(12 + (gapColumna + anchoPicture) * contadorCartas,
                12 + (gapFila + alturaPicture) * contadorFilas);
        }

        private void BarajarButton_Click(object sender, EventArgs e)
        {
            QuitarPictureBoxesDelPanel();
            CrearBotonBarajar();
            mazo.Barajar();
            MostrarCartas(mazo);
        }

        private void QuitarPictureBoxesDelPanel()
        {
            panel1.Controls.Clear();
        }

    }
}

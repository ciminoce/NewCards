using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCards.Entidades
{
    public class Helper
    {
        public static Bitmap CropImage(Image imagenCartas, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(imagenCartas, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        public static Rectangle CrearRectangulo(Point x1, Size size)
        {
            return new Rectangle(x1, size);
        }
    }
}

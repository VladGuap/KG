using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y) //инверсия цвета пикселя
        {
            Color sourceColor = sourceImage.GetPixel(x, y);
            Color resultColor = Color.FromArgb(255 - sourceColor.R,
                                                255 - sourceColor.G,
                                                255 - sourceColor.B);

            return resultColor;
        }
    }
}

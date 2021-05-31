using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            int intensity = (int)(0.29 * sourceColor.R + 0.58 * sourceColor.G + 0.11 * sourceColor.B);
            double k = 27;
            double resultR = intensity + 2 * k,
                    resultG = intensity + 0.5 * k,
                    resultB = intensity - 1 * k;


            return Color.FromArgb(
                Clamp((int)resultR, 0, 255),
                Clamp((int)resultG, 0, 255),
                Clamp((int)resultB, 0, 255)
                );
        }
    }
}

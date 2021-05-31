using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class BrightnessUpFilter : Filters
    {
        private int up;

        public BrightnessUpFilter(int _up)
        {
            up = _up;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color sourceColor = sourceImage.GetPixel(x, y);

            return Color.FromArgb(
                Clamp((int)sourceColor.R + up, 0, 255),
                Clamp((int)sourceColor.G + up, 0, 255),
                Clamp((int)sourceColor.B + up, 0, 255)
                );
        }
    }
}

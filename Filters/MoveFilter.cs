using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class MoveFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (x + 27 >= sourceImage.Width)
            {
                return Color.FromArgb(0, 0, 0);
            }
            else
            {
                return sourceImage.GetPixel(x + 27, y);
            }

        }
    }
}

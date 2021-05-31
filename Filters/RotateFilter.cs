using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class RotateFilter : Filters
    {

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int x0 = sourceImage.Width / 2;
            int y0 = sourceImage.Height / 2;

            int angle = 70;
            double phi = (angle * 180) / Math.PI;

            int nX = (int)((x - x0) * Math.Cos(phi) - (y - y0) * Math.Sin(phi) + x0);
            int nY = (int)((x - x0) * Math.Sin(phi) + (y - y0) * Math.Cos(phi) + y0);

            if (nX >= sourceImage.Width || nX < 0 || nY >= sourceImage.Height || nY < 0)
            {
                return Color.Black;
            }

            return sourceImage.GetPixel(nX, nY);
        }
    }
}

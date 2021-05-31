using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class PrewittFilter : MatrixFilter
    {
        protected float[,] kernelX;
        protected float[,] kernelY;

        public PrewittFilter()
        {
            kernelX = new float[,] {    { -1, 0, 1 },
                                        { -1, 0, 1 },
                                        { -1, 0, 1 } };
            kernelY = new float[,] {    { -1, -1, -1 },
                                        { 0, 0, 0 },
                                        { 1, 1, 1 } };
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            kernel = kernelX;
            Color valueX = base.calculateNewPixelColor(sourceImage, x, y);
            kernel = kernelY;
            Color valueY = base.calculateNewPixelColor(sourceImage, x, y);

            return Color.FromArgb(
                    Clamp((int)Math.Sqrt(valueX.R * valueX.R + valueY.R * valueY.R), 0, 255),
                    Clamp((int)Math.Sqrt(valueX.G * valueX.G + valueY.G * valueY.G), 0, 255),
                    Clamp((int)Math.Sqrt(valueX.B * valueX.B + valueY.B * valueY.B), 0, 255)
                    );

        }
    }
}

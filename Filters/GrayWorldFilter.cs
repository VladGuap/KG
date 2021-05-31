using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;


namespace Filters
{
    class GrayWorldFilter : Filters
    {
        private float averageColorR,
            averageColorG,
            averageColorB,
            averageColor;

        public GrayWorldFilter(Bitmap sourceImage)
        {
            averageColorR = 0;
            averageColorG = 0;
            averageColorB = 0;

            int norm = 0;

            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    Color curColor = sourceImage.GetPixel(i, j);
                    averageColorR += curColor.R;
                    averageColorG += curColor.G;
                    averageColorB += curColor.B;
                    norm++;
                }
            }

            averageColorR /= norm;
            averageColorG /= norm;
            averageColorB /= norm;

            averageColor = (averageColorR + averageColorG + averageColorB) / 3;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Color curColor = sourceImage.GetPixel(x, y);

            return Color.FromArgb(
                Clamp((int)(curColor.R * averageColor / averageColorR), 0, 255),
                Clamp((int)(curColor.G * averageColor / averageColorG), 0, 255),
                Clamp((int)(curColor.B * averageColor / averageColorB), 0, 255)
            );
        }
    }
}

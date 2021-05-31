using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class NormalizationFilter : Filters
    {
        private int norm;

        public NormalizationFilter(Bitmap sourceImage)
        {
            norm = 0;
            for (int i = 0; i < sourceImage.Width; i++)
            {
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    norm++;
                }
            }
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return Color.FromArgb(
                sourceImage.GetPixel(x, y).R / norm,
                sourceImage.GetPixel(x, y).G / norm,
                sourceImage.GetPixel(x, y).B / norm);
        }
    }
}

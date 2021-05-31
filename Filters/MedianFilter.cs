using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class MedianFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            int radius = 1;

            if (x < radius || x >= sourceImage.Width - radius - 1
                || y < radius || y >= sourceImage.Height - radius - 1)
            {
                return sourceImage.GetPixel(x, y);
            }

            double[] valuesColor = new double[(radius * 2 + 1) * (radius * 2 + 1)];
            Color[] colors = new Color[(radius * 2 + 1) * (radius * 2 + 1)];

            for (int k = -radius; k <= radius; k++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    valuesColor[(k + radius) * (radius * 2 + 1) + j + radius] = Intensity(sourceImage.GetPixel(x + k, y + j));
                    colors[(k + radius) * (radius * 2 + 1) + j + radius] = sourceImage.GetPixel(x + k, y + j);
                }
            }

            bool flag = false;
            for (int i = 0; i < valuesColor.Length; i++)
            {
                for (int j = 1; j < valuesColor.Length; j++)
                {
                    if (valuesColor[j] < valuesColor[j - 1])
                    {
                        double tmpC = valuesColor[j];
                        Color tmpColor = colors[j];
                        valuesColor[j] = valuesColor[j - 1];
                        colors[j] = colors[j - 1];
                        valuesColor[j - 1] = tmpC;
                        colors[j - 1] = tmpColor;
                        flag = true;
                    }
                }

                if (!flag)
                {
                    break;
                }
            }

            return colors[colors.Length / 2];
        }
    }
}

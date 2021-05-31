using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class EmbossFilter : MatrixFilter
    {
        private BrightnessUpFilter brightnessUpFilter;

        public EmbossFilter()
        {
            kernel = new float[,] { {0, 1, 0},
                                    {1, 0, -1},
                                    {0, -1, 0}};

            brightnessUpFilter = new BrightnessUpFilter(150);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return base.calculateNewPixelColor(sourceImage, x, y);
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker bgWorker)
        {
            Bitmap res1 = base.processImage(sourceImage, bgWorker);
            Bitmap res2 = brightnessUpFilter.processImage(res1, bgWorker);

            return res2;
        }

    }
}

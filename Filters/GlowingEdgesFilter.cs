using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class GlowingEdgesFilter : MatrixFilter
    {
        private MedianFilter medianFilter;
        private SobelFilter sobelFilter;
        private MaximumFilter maximumFilter;

        public GlowingEdgesFilter()
        {
            medianFilter = new MedianFilter();
            sobelFilter = new SobelFilter();
            maximumFilter = new MaximumFilter();
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return sourceImage.GetPixel(x, y);
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker bgWorker)
        {
            Bitmap res1 = medianFilter.processImage(sourceImage, bgWorker);
            Bitmap res2 = sobelFilter.processImage(res1, bgWorker);
            Bitmap res3 = maximumFilter.processImage(res2, bgWorker);

            return res3;
        }
    }
}

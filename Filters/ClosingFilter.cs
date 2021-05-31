using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class ClosingFilter : Filters
    {
        private DilationFilter dilationFilter;
        private ErosionFilter erosionFilter;

        public ClosingFilter(int w, int h, int[,] k)
        {

            dilationFilter = new DilationFilter(w, h, k);
            erosionFilter = new ErosionFilter(w, h, k);
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            return Color.White;
        }

        public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker bgWorker)
        {
            Bitmap res = dilationFilter.processImage(sourceImage, bgWorker);
            Bitmap finalRes = erosionFilter.processImage(res, bgWorker);

            return finalRes;
        }
    }
}

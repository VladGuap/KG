using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class MotionBlurFilter : MatrixFilter
    {
        public void createMotionBlurFilter(int size)
        {
            kernel = new float[size, size];
            for (int i = 0; i < size; i++)
            {
                kernel[i, i] = 1;
                kernel[i, i] /= size;
            }
        }

        public MotionBlurFilter()
        {
            createMotionBlurFilter(7);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Filters
{
    class SharpeningFilter : MatrixFilter
    {
        public SharpeningFilter()
        {
            kernel = new float[,] { {0, -1, 0},
                                    {-1, 5, -1},
                                    {0, -1, 0}};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSS_E2FI1_SAE_2018_19
{
    static class Mathematics
    {
        public static double sqrt(double x) {
            double bottomBorder = 1;
            double topBorder = x;

            double maxDiff = 0.00000000000001;

            while(topBorder - bottomBorder > maxDiff) {
                double middle = (topBorder + bottomBorder) / 2;

                if(middle * middle > x) {
                    topBorder = middle;
                } else {
                    bottomBorder = middle;
                }
            }

            return (topBorder + bottomBorder) / 2;
        }
    }
}

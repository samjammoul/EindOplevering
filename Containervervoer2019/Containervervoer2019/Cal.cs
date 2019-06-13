using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer2019
{
    public class Cal
    {
        public double CalMinGwicht(double MaxGewicht)
        {
            double getMinGewicht;
            getMinGewicht = (MaxGewicht * 50) / 100;

            return getMinGewicht;
        }
    }
}

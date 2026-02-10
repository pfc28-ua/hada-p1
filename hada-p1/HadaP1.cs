using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    internal class HadaP1
    {
        public static double Seconds2Minutes(double s)
        {
            if (s == 0) return 0; // Modificación obligatoria [cite: 1013]
            return s / 60.0;
        }

        public static double Minutes2Seconds(double m)
        {
            return m * 60.0;
        }

        public static double Hours2Minutes(double h)
        {
            return h * 60.0;
        }
    }
}

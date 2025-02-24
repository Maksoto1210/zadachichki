using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal static class Temperature
    {
        static Temperature()
        {
            CurrentTemperature = 20;
        }
        public static int CurrentTemperature { get; set; }
    }
}

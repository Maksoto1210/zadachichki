using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class CoolingSystem
    {
        public void Cool(object? sender, EventArgs e)
        {
            Console.WriteLine("Temperature too high!");
            Console.WriteLine("Reducing temperature by 20 degrees!");
            Temperature.CurrentTemperature -= 20;
        }
    }
}

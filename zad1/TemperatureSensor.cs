using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class TemperatureSensor
    {
        private int maxTemp;
        public TemperatureSensor(int maxTemp)
        {
            this.maxTemp = maxTemp;
        }

        public void ReadTemperature()
        {
            Console.WriteLine($"Temperature is: {Temperature.CurrentTemperature}");
        }
        public void IncreaseTemperature(int increment)
        {
            Temperature.CurrentTemperature += increment;
            if (Temperature.CurrentTemperature > maxTemp)
            {
                OnMaxTempReached(this, EventArgs.Empty);
            }
        }
        protected virtual void OnMaxTempReached(object sender, EventArgs e)
        {
            MaxTempReached?.Invoke(sender, e);
        }
        public event EventHandler MaxTempReached;
    }
}

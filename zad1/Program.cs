namespace zad1
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature limit: ");
            TemperatureSensor sensor = new TemperatureSensor(int.Parse(Console.ReadLine()));
            
            CoolingSystem cooler = new CoolingSystem();
            sensor.MaxTempReached += cooler.Cool;

            while (Console.ReadKey(true).KeyChar != '0')
            {
                sensor.ReadTemperature();
                Console.WriteLine("Warming up...");
                sensor.IncreaseTemperature(5);
            }

            Console.WriteLine("Program exited.");
            sensor.ReadTemperature();
        }
    }
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_01
{
    class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }

        // Cooler is activated when ambient temperature is higher than this
        public float Temperature { get; set; }

        // Notifies that the temperature changed on this instance
        public void OnTemperatureChanged(float newTemperature)
        {
            if(newTemperature > Temperature)
            {
                System.Console.WriteLine("Cooler: On");
            }
            else
            {
                System.Console.WriteLine("Cooler: Off");
            }
        }
    }

    class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }

        // Cooler is activated when ambient temperature is higher than this
        public float Temperature { get; set; }

        // Notifies that the temperature changed on this instance
        public void OnTemperatureChanged(float newTemperature)
        {
            if(newTemperature < Temperature)
            {
                System.Console.WriteLine("Heater: On");
            }
            else
            {
                System.Console.WriteLine("Heater: Off");
            }
        }
    }
}
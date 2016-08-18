namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_01
{
    class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature { get; set; }

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

        public float Temperature { get; set; }

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
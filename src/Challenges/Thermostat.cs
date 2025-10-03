using System;

namespace Challenges
{
    // Thermostat appliance - adjusts temperature
    public class Thermostat : SmartAppliance
    {
        private double temperature; // in Celsius

        public Thermostat(string brand, string model) : base(brand, model)
        {
            temperature = 22.0; // Default temperature
        }

        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value >= 10 && value <= 30)
                {
                    temperature = value;
                }
                else
                {
                    Console.WriteLine("Temperature must be between 10°C and 30°C.");
                }
            }
        }

        public override void PerformAction()
        {
            if (IsOn)
            {
                Console.Write("Enter desired temperature (10-30°C): ");
                if (double.TryParse(Console.ReadLine(), out double temp))
                {
                    Temperature = temp;
                    Console.WriteLine($"Temperature set to {Temperature}°C.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Temperature unchanged.");
                }
            }
            else
            {
                Console.WriteLine("Cannot adjust temperature. Thermostat is OFF.");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Temperature: {Temperature}°C";
        }
    }
}

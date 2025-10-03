using System;

namespace Challenges
{
    // Light appliance - adjusts brightness
    public class Light : SmartAppliance
    {
        private int brightness; // 0-100

        public Light(string brand, string model) : base(brand, model)
        {
            brightness = 50; // Default brightness
        }

        public int Brightness
        {
            get { return brightness; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    brightness = value;
                }
                else
                {
                    Console.WriteLine("Brightness must be between 0 and 100.");
                }
            }
        }

        public override void PerformAction()
        {
            if (IsOn)
            {
                Console.Write("Enter brightness level (0-100): ");
                if (int.TryParse(Console.ReadLine(), out int level))
                {
                    Brightness = level;
                    Console.WriteLine($"Light brightness set to {Brightness}%.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Brightness unchanged.");
                }
            }
            else
            {
                Console.WriteLine("Cannot adjust brightness. Light is OFF.");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Brightness: {Brightness}%";
        }
    }
}

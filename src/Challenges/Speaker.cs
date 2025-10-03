using System;

namespace Challenges
{
    // Speaker appliance - plays sound
    public class Speaker : SmartAppliance
    {
        private int volume; // 0-100

        public Speaker(string brand, string model) : base(brand, model)
        {
            volume = 30; // Default volume
        }

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Volume must be between 0 and 100.");
                }
            }
        }

        public override void PerformAction()
        {
            if (IsOn)
            {
                Console.WriteLine("Playing music at volume " + Volume + "%.");
                // Simulate playing sound
                Console.WriteLine("♪♪♪ La la la... ♪♪♪");
            }
            else
            {
                Console.WriteLine("Cannot play music. Speaker is OFF.");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Volume: {Volume}%";
        }
    }
}

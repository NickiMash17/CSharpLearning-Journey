using System;

namespace Challenges
{
    // Abstract base class for smart appliances
    public abstract class SmartAppliance : IControllable
    {
        // Encapsulated properties
        private string brand;
        private string model;
        private bool isOn;

        // Constructor
        protected SmartAppliance(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
            this.isOn = false;
        }

        // Properties with encapsulation
        public string Brand
        {
            get { return brand; }
            private set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public bool IsOn
        {
            get { return isOn; }
            protected set { isOn = value; }
        }

        // Common methods
        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Brand} {Model} is now ON.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Brand} {Model} is now OFF.");
        }

        // Abstract method for unique actions
        public abstract void PerformAction();

        // Override ToString for readable output
        public override string ToString()
        {
            return $"{Brand} {Model} - Status: {(IsOn ? "ON" : "OFF")}";
        }
    }
}

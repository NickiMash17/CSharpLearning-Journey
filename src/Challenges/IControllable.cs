using System;

namespace Challenges
{
    // Interface for controlling appliances
    public interface IControllable
    {
        void TurnOn();
        void TurnOff();
        void PerformAction();
    }
}

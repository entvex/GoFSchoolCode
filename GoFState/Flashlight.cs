using System;

namespace GoFState
{
    /// <summary>
    /// This is the context.
    /// </summary>
    public class Flashlight
    {

        private FlashlightState _flashlightState = new Off();

        public void Power()
        {
            _flashlightState.HandlePower(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Light on");
        }

        public void LightOff()
        {
            Console.WriteLine("Light off");
        }

        public void SetState(FlashlightState flashlightState)
        {
            _flashlightState = flashlightState;
        }

    }
}
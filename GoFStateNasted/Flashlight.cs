using System;

namespace GoFStateNasted
{
    /// <summary>
    /// This is the context.
    /// </summary>
    public class Flashlight
    {
        private FlashlightState _flashlightState;

        public Flashlight()
        {
            _flashlightState = new Off();
        }        

        public void Power()
        {
            _flashlightState.HandlePower(this);
        }

        public void ModePressed()
        {
            _flashlightState.ModePressed(this);
        }

        public void LightOn() => Console.WriteLine("Light on");

        public void LightOff() => Console.WriteLine("Light off");

        public void solidLED() => Console.WriteLine("solidLED");

        public void flashLEDs() => Console.WriteLine("flashLEDs");

        public void SetState(FlashlightState flashlightState)
        {
            _flashlightState = flashlightState;
            _flashlightState.OnEnter(this);
        }
    }
}
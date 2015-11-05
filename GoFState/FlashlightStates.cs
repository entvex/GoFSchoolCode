namespace GoFState
{
    /// <summary>
    /// This is the abstract state  
    /// </summary>
    public abstract class FlashlightState
    {
        public abstract void HandlePower(Flashlight context);
    }

    /// <summary>
    /// This is the concrete State on
    /// </summary>
    public class On : FlashlightState
    {
        public override void HandlePower(Flashlight context)
        {
            context.LightOn();
            context.SetState(new Off());
        }
    }

    /// <summary>
    /// This is the concrete State off
    /// </summary>
    public class Off : FlashlightState
    {
        public override void HandlePower(Flashlight context)
        {
            context.LightOff();
            context.SetState(new On());
        }
    }

}
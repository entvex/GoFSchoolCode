namespace GoFStateNasted
{
    /// <summary>
    /// This is the abstract state  
    /// </summary>
    public class FlashlightState
    {
        public virtual void OnEnter(Flashlight context) { }

        public virtual void HandlePower(Flashlight context) { }

        public virtual void ModePressed(Flashlight context) { }
    }

    /// <summary>
    /// This is the concrete State off
    /// </summary>
    public class Off : FlashlightState
    {
        public override void HandlePower(Flashlight context)
        {
            context.LightOn();
            context.SetState(new On());
        }
    }

    /// <summary>
    /// This is the concrete State on
    /// </summary>
    public class On : FlashlightState
    {
        public override void OnEnter(Flashlight context)
        {
            context.SetState(new SOLID());
        }

        public override void HandlePower(Flashlight context)
        {
            context.LightOff();
            context.SetState(new Off());
        }
    }

    /// <summary>
    /// This is the concrete nested State SOLID
    /// </summary>
    public class SOLID : On
    {

        public override void OnEnter(Flashlight context) { }

        public override void ModePressed(Flashlight context)
        {
            context.solidLED();
            context.SetState(new FLASHING());
        }
    }

    /// <summary>
    /// This is the concrete nested State FLASHING
    /// </summary>
    public class FLASHING : On
    {
        public override void OnEnter(Flashlight context) { }

        public override void ModePressed(Flashlight context)
        {
            context.flashLEDs();
            context.SetState(new SOLID());
        }
    }
}
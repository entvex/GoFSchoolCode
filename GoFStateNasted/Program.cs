using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFStateNasted
{
    class Program
    {
        private static void Main(string[] args)
        {
            Flashlight flashlight = new Flashlight();

            Console.WriteLine("Power on and into the nested state");
            flashlight.Power();
            flashlight.ModePressed();
            flashlight.ModePressed();

            Console.WriteLine("Power off and try to change nested state");
            flashlight.Power();
            flashlight.ModePressed();

            Console.WriteLine("Power on and see the first nested state");
            flashlight.Power();
            flashlight.ModePressed();
        }
    }
}

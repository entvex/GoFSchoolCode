using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GoFState
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Flashlight flashlight = new Flashlight();

            flashlight.Power();
            flashlight.Power();
            flashlight.Power();
            flashlight.Power();
        }
    }
}
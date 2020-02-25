using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;
namespace JoystickUSB
{
    class MouseEmulator
    {
        private bool mouseClicked = false;
        private int yvalue = 0;
        private int xvalue = 0;
        private int zvalue = 0;
        Joystick js;
        public MouseEmulator(Joystick js)
        {
            this.js = js;
        }
        public void Emulate()
        {

        }
    }
}

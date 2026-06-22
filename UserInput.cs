using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGameWindowsForms
{
    public static class UserInput
    {
        private static bool[] _keyboardState = new bool[256];
        private static bool[] _keyboardStatePrevious = new bool[256];

        public static void SetKeyState(Keys key, bool pressed)
        {
            int index = (int)key & 0xFF; // Keys enum fits in a byte, but have to mask it down to 0-255
            _keyboardState[index] = pressed;
        }

        public static bool IsKeyPressed(Keys key)
        {
            int index = (int)key & 0xFF;
            return _keyboardState[index];
        }

        public static bool IsKeyPressedPrevious(Keys key)
        {
            int index = (int)key & 0xFF;
            return _keyboardState[index];
        }
    }
}

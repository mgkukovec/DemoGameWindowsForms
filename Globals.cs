using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DemoGameWindowsForms
{
    public static class Globals
    {
        public static Vector Zero = new Vector(0, 0);

        public static float DeltaTime = 0f;
        public static DateTime PreviousTickTime = DateTime.Now;
    }
}

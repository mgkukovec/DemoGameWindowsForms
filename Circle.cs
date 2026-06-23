using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DemoGameWindowsForms
{
    public class Circle
    {
        public Vector Center;
        public float Radius;

        // Use this offset to draw, call wants the top-left corner
        public Vector DrawPosition => new Vector(Center.X - Radius, Center.Y - Radius);

        public Circle(Vector center, float radius)
        {
            Center = center;
            Radius = radius;
        }
    }
}

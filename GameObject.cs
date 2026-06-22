using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DemoGameWindowsForms
{
    public class GameObject
    {
        public Vector Position;
        public Vector MovementDirection;
        public Vector Velocity;
        public double Speed;

        public GameObject(Vector position)
        {
            Position = position;
            MovementDirection = Globals.Zero;
            Velocity = Globals.Zero;
            Speed = 1;
        }

        public virtual void Update(float deltaTime)
        {
            Velocity = MovementDirection * Speed;
            Position += Velocity * deltaTime;
        }

        public virtual void Render()
        {

        }
    }
}

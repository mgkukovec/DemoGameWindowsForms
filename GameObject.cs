using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Image Texture;
        public float RotationDegrees;

        public GameObject(Vector position)
        {
            Position = position;
            MovementDirection = Globals.Zero;
            Velocity = Globals.Zero;
            Speed = 1;
            RotationDegrees = 0f;
        }

        public virtual void Update(float deltaTime)
        {
            Velocity = MovementDirection * Speed;
            Position += Velocity * deltaTime;
            //Texture.
        }

        public virtual void Render(Graphics g)
        {
            if (Texture == null)
            {
                return;
            }

            g.DrawImage(Texture, (float)Position.X, (float)Position.Y, Texture.Width, Texture.Height);
        }
    }
}

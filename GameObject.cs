using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DemoGameWindowsForms
{
    public class GameObject
    {
        public Circle Collider;
        public Vector MovementDirection;
        public Vector Velocity;
        public double Speed;
        public Image Texture;
        public float RotationDegrees;

        public GameObject(Circle collider)
        {
            Collider = collider;
            MovementDirection = Globals.Zero;
            Velocity = Globals.Zero;
            Speed = 1;
            RotationDegrees = 0f;
        }

        public virtual void Update(float deltaTime)
        {
            Velocity = MovementDirection * Speed;
            Collider.Center += Velocity * deltaTime;
            // RotationDegrees += 90f * deltaTime; // Rotate 90 degrees per second
        }

        public virtual void Render(Graphics g)
        {
            if (Texture == null)
            {
                return;
            }

            if (RotationDegrees == 0f)
            {
                g.DrawImage(Texture, (float)Collider.Center.X, (float)Collider.Center.Y, Texture.Width, Texture.Height);
            }
            else
            {
                GraphicsState state = g.Save();

                // Apply rotation around center
                g.TranslateTransform((float)Collider.Center.X, (float)Collider.Center.Y);
                g.RotateTransform(RotationDegrees);
                g.TranslateTransform(-(float)Collider.Center.X, -(float)Collider.Center.Y);
                // Draw the image, at center of circle
                g.DrawImage(Texture, (float)Collider.DrawPosition.X, (float)Collider.DrawPosition.Y, Texture.Width, Texture.Height);

                g.Restore(state);
            }

        }
    }
}

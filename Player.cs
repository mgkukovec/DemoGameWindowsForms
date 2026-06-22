using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace DemoGameWindowsForms
{
    public class Player : GameObject
    {
        public Player(Vector position) : base(position)
        {
            Speed = 60;

            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string fullImagePath = Path.Combine(projectRoot, "Resources", "Player.png");
            Texture = Image.FromFile(fullImagePath);
        }

        public override void Update(float deltaTime)
        {
            MovementDirection = new Vector(0, 0);

            if (UserInput.IsKeyPressed(Keys.W))
            {
                MovementDirection.Y -= 1;
            }
            if (UserInput.IsKeyPressed(Keys.S))
            {
                MovementDirection.Y += 1;
            }
            if (UserInput.IsKeyPressed(Keys.A))
            {
                MovementDirection.X -= 1;
            }
            if (UserInput.IsKeyPressed(Keys.D))
            {
                MovementDirection.X += 1;
            }

            if (MovementDirection != Globals.Zero)
            {
                MovementDirection.Normalize();
            }

            base.Update(deltaTime);
        }

        public override void Render(Graphics g)
        {
            base.Render(g);
        }
    }
}

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
            Speed = 40;

            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\.."));
            string fullImagePath = Path.Combine(projectRoot, "Resources", "Player.png");
            PictureBox = new PictureBox
            {
                Image = Image.FromFile(fullImagePath),
                SizeMode = PictureBoxSizeMode.AutoSize,
                BorderStyle = BorderStyle.None,
                Visible = true,
                Location = new System.Drawing.Point(10, 10)
            };
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

        public override void Render()
        {
            base.Render();
        }
    }
}

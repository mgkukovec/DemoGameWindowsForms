using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGameWindowsForms
{
    public class GameState
    {
        private Form1 _form;
        private readonly GameObjectFactory _factory;

        public Player Player;
        //public List<Enemy> Enemies = new List<Enemy>();

        public GameState(Form1 form)
        {
            _form = form;
            _factory = new GameObjectFactory(p => _form.Controls.Add(p));

            Player = _factory.CreatePlayer(new System.Windows.Vector(10, 10));
        }

        public void Update(float deltaTime)
        {
            Player?.Update(deltaTime);

            // Enemies
        }

        public void Render(Graphics g)
        {
            Player?.Render(g);

            // Enemies
        }
    }

}

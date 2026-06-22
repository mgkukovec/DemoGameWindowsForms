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

            SpawnPlayer();
            //Enemies.Add(new Enemy(300, 200));
        }

        public void Update(float deltaTime)
        {
            Player.Update(deltaTime);

            //foreach (var e in Enemies)
            //    e.Update(Player);
        }

        public void Render(Graphics g)
        {
            //Player.Draw(g);
            //foreach (var e in Enemies)
            //    e.Draw(g);
        }

        private void SpawnPlayer()
        {
            Player = new Player(new System.Windows.Vector(20, 20));
            _form.Controls.Add(Player.PictureBox);
        }
    }

}

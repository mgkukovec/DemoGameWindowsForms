using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGameWindowsForms
{
    public class GameState
    {
        public Player Player;
        //public List<Enemy> Enemies = new List<Enemy>();

        public GameState()
        {
            Player = new Player(new System.Windows.Vector(20, 20));
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
    }

}

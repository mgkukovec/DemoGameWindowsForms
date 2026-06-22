using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DemoGameWindowsForms
{
    public class GameObjectFactory
    {
        //private readonly Action<PictureBox> addControl;

        public GameObjectFactory(Action<PictureBox> addControl)
        {
            //this.addControl = addControl;
        }

        public Player CreatePlayer(Vector position)
        {
            Player p = new Player(position);
            //addControl(p.PictureBox);
            return p;
        }
    }
}

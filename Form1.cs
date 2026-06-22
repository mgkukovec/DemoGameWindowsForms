using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGameWindowsForms
{
    public partial class Form1 : Form
    {
        private GameState _game;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            _game = new GameState();

            //Timer timer = new Timer();
            //timer.Interval = 16;
            //timer.Tick += GameLoop;
            //timer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            UserInput.SetKeyState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            UserInput.SetKeyState(e.KeyCode, false);
        }

        private void Tick(object sender, EventArgs e)
        {
            // Do not need to poll input, constantly being checked

            DateTime now = DateTime.Now;
            Globals.DeltaTime = (float)(now - Globals.PreviousTickTime).TotalSeconds;
            Globals.PreviousTickTime = now;

            _game.Update(Globals.DeltaTime);
            //_game.Render();
            //Invalidate();
        }
    }
}

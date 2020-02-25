using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoystickUSB
{
    public partial class Form2 : Form 
    {
        Random random = new Random();
        bool shooted = true;
        int points = 0;
        int x, y, xClick, yClick;

        public Form2(int xClick1, int yClick1)
        {
            xClick = xClick1;
            yClick = yClick1;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawTarget(e.Graphics);
            base.OnPaint(e);

        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void DrawTarget(Graphics g)
        {
            if (shooted)
            {
                x = random.Next(0, this.Size.Width);
                y = random.Next(0, this.Size.Height);
                shooted = false;
               
            }


            g.DrawRectangle(Pens.DeepPink,x, y, 30, 30);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimDX.DirectInput;


namespace JoystickUSB
{
    public partial class Form1 : Form
    {
        DirectInput directInput = new DirectInput();
        List<DeviceInstance> deviceList = new List<DeviceInstance>();
        private bool mouseClicked = false;
        private int yvalue = 0;
        private int xvalue = 0;
        private int zvalue = 0;
        private int counter = 0;

        bool shooted = true;
        int x, y;
        int xClick1, yClick1;
        Random random = new Random();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern void mouse_event(uint flag, uint _x, uint _y, uint btn, uint exInfo);

        private const int MOUSEEVENT_LEFTDOWN = 0x02;
        private const int MOUSEEVENT_LEFTUP = 0x04;

       

        Joystick[] Sticks; // przyciski
        public Form1()
        {
            InitializeComponent();
          
            this.MaximumSize = this.MinimumSize =  new System.Drawing.Size(1005,978);
            button1.Enabled = button2.Enabled = false;
            button1.BackColor = button2.BackColor = Color.Red;
            var devicesJoystick = directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices);
            var devicesGamePad = directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices);
            textBox1.Text = counter.ToString();
            
            foreach (DeviceInstance instance in devicesJoystick)
            {
                try
                {
                    deviceList.Add(instance);
                    listBox1.Items.Add(instance.InstanceName);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Błąd");
                }


            }

            foreach (DeviceInstance instance in devicesGamePad)
            {
                try
                {
                    deviceList.Add(instance);
                    listBox1.Items.Add(instance.InstanceName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Błąd");
                }


            }  

        }

        private void button1_Click(object sender, EventArgs e) // emulate mouse
        {
            
            
            timer1.Enabled = true;
            timer1.Interval = 1;

            timer2.Enabled = true;
            timer2.Interval = 100;
            Sticks = GetSticks();
            textBox1.BackColor = label2.ForeColor = Color.Crimson;
            textBox1.ForeColor = Color.Black;
   

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // draw
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.BackColor = button2.BackColor = Color.GreenYellow;
            button1.Enabled = button2.Enabled = true;
        }

        public Joystick[] GetSticks()
        {
            

            var sticks = new List<Joystick>();
            foreach (DeviceInstance device in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    Joystick js = new Joystick(directInput, deviceList.ElementAt(listBox1.SelectedIndex).InstanceGuid);
                    js.Acquire();

                    foreach (DeviceObjectInstance deviceObject in js.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                        {
                            js.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                        }
                    }
                    sticks.Add(js);

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error!");
                }
            }
            return sticks.ToArray();
        }
        public void MouseMoveT(int posX, int posY)
        {
            Cursor.Position = new Point(Cursor.Position.X + posX, Cursor.Position.Y/9 + posY/9);
            Cursor.Clip = new Rectangle(Screen.PrimaryScreen.WorkingArea.Location, Screen.PrimaryScreen.WorkingArea.Size);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawTest(e.Graphics);      
            base.OnPaint(e);
        }
        private void DrawTest(Graphics g)
        {
            var p = PointToClient(Cursor.Position);
            g.DrawEllipse (Pens.DarkCyan,p.X-20, p.Y-20, 40,40);
        }

        public void DrawTarget(Graphics g)
        {
            if (shooted)
            {
                x = random.Next(0, this.Size.Width)-80;
                y = random.Next(300, this.Size.Height)-80;
                shooted = false;

            }

            g.DrawRectangle(Pens.DeepPink, x, y, 50, 50);

        }
        void stickHandle(Joystick stick, int id)
        {
            JoystickState state = new JoystickState();
            state = stick.GetCurrentState();
            yvalue = state.Y;
            xvalue = state.X;
            zvalue = state.Z;
            MouseMoveT(xvalue, yvalue);

        }

        public void check()
        {


            if (((xClick1 >= x) && (xClick1 <= x + 30)) && ((yClick1 >= y) && (yClick1 <= x + 30)))
            {
                shooted = true;
                xClick1 = 0;
                yClick1 = 0;
            }
        }

        void stickHandle2(Joystick stick, int id)
        {
            JoystickState state = new JoystickState();
            state = stick.GetCurrentState();

           

            bool[] buttons = state.GetButtons();

            if (id == 0)
            {
                if (buttons[0])
                {
                    if (mouseClicked == false)
                    {
                        mouse_event(MOUSEEVENT_LEFTDOWN, 0, 0, 0, 0);
                        mouseClicked = true;
                        xClick1 = Cursor.Position.X;
                        yClick1 = Cursor.Position.Y;

                    }
                }
                else
                {
                    if (mouseClicked)
                    {
                        mouse_event(MOUSEEVENT_LEFTUP, 0, 0, 0, 0);
                        mouseClicked = false;
                    }

                }
                if (buttons[6])
                {
                    counter++;
                    textBox1.Text = counter.ToString();

                }
                if(buttons[9])
                {
                    counter--;
                    textBox1.Text = counter.ToString();
                }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0; i<Sticks.Length; i++)
            {
                stickHandle(Sticks[i], i);

            }
            
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Sticks.Length; i++)
            {
                stickHandle2(Sticks[i], i);
                
            }
            
            Invalidate();

        }

    }  
    

    
}

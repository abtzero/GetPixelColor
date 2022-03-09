using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

using System.Threading;


//using WindowsInput;//For Input Simulator
//using InputManager; //For Input Manager

//using WindowsInput;
//using WindowsInput.Native;

//using Input


// GetPixelMethof from: https://stackoverflow.com/questions/1483928/how-to-read-the-color-of-a-screen-pixel
// mit Kommentar: "I think this is the cleanest and quickest way."

namespace GetPixelColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Auto = false;
        private Color lastColor;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetWindowDC(IntPtr window);
        [DllImport("gdi32.dll", SetLastError = true)]
        public static extern uint GetPixel(IntPtr dc, int x, int y);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr window, IntPtr dc);

        public static Color GetColorAt(int x, int y)
        {
            IntPtr desk = GetDesktopWindow();
            IntPtr dc = GetWindowDC(desk);
            int a = (int)GetPixel(dc, x, y);
            ReleaseDC(desk, dc);
            return Color.FromArgb(255, (a >> 0) & 0xff, (a >> 8) & 0xff, (a >> 16) & 0xff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Color mycolor = Color.FromArgb(255, 0, 150, 255);
            int X = int.Parse(textBoxX.Text);
            int Y = int.Parse(textBoxY.Text);
            //Color mycolor = GetColorAt(100, 50);
            Color mycolor = GetColorAt(X, Y);
            panel1.BackColor = mycolor;


            System.Threading.Thread.Sleep(int.Parse(txtBoxPause.Text));
            ///InputSimulator .SimulateKeyPress(VirtualKeyCode.VK_E);
            //SendKeys.SendWait("e");
            // https://archive.codeplex.com/?p=inputsimulator
            //InputSimulator.SimulateKeyPress(VirtualKeyCode.VK_E);
            //var sim = new InputSimulator();
            //sim.Keyboard.KeyPress(VirtualKeyCode.VK_E);
     
            short key = 0x12; // E key https://community.bistudio.com/wiki/DIK_KeyCodes
            //WindowsMessageService.SendKey(key, KeyFlag.KeyDown);
            //System.Threading.Thread.Sleep(20);
            //WindowsMessageService.SendKey(key, KeyFlag.KeyUp);
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBoxX.Text = trackBar1.Value.ToString();
            //int X = int.Parse(textBoxX.Text);
            //int Y = int.Parse(textBoxY.Text);
            panel1.BackColor = GetColorAt(trackBar1.Value, trackBar2.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBoxY.Text = trackBar2.Value.ToString();
            //int X = int.Parse(textBoxX.Text);
            //int Y = int.Parse(textBoxY.Text);
            panel1.BackColor = GetColorAt(trackBar1.Value, trackBar2.Value);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("AUTO: " + Auto);
            if (Auto)
            {
                btnAuto.BackColor = Color.FromArgb(255, 244, 244, 244);
                Auto = false;
                timer1.Enabled = false;
            }
            else
            {
                btnAuto.BackColor = Color.FromArgb(255, 0, 200, 70);
                Auto = true;
                timer1.Enabled = true;
            }
        }

        /*
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        */
        private void timer1_Tick(object sender, EventArgs e)
        {
            //panel1.BackColor = GetColorAt(trackBar1.Value, trackBar2.Value);
            Color actColor = GetColorAt(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text));
            if (actColor != lastColor)
            {
                //panel1.BackColor = GetColorAt(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text));
                panel1.BackColor = actColor;
                lastColor = actColor;
                textR.Text = actColor.R.ToString();
                textG.Text = actColor.G.ToString();
                textB.Text = actColor.B.ToString();
                Console.WriteLine(actColor.R.ToString() + " " + actColor.G.ToString() + " " + actColor.B.ToString());
                //if(actColor.R >= 140 & actColor.R<= 170 & actColor.G >= 140 & actColor.G <= 170 & actColor.B >= 140 & actColor.B <= 170)
                if (actColor.R == 229 & actColor.G == 229 & actColor.B == 229)
                {
                    this.BackColor = Color.Red;
                    Console.WriteLine("===================     HIT COLOR!     ==================");
                    timer1.Enabled = false;
                    btnAuto.BackColor = Color.FromArgb(255, 244, 244, 244);
                    Auto = false;
                    this.Refresh();
                    //this.BackColor = Color.Yellow;

                    DoIt();
                }
                else
                {
                    this.BackColor = Color.FromArgb(255, 244, 244, 244);
                }
            }

        }

        private void DoIt() {
            System.Threading.Thread.Sleep(int.Parse(txtBoxPause.Text));

            this.BackColor = Color.Yellow;
            this.Refresh();
            //Application.DoEvents();

            //SendKeys.SendWait("e");
            //var sim = new InputSimulator();
            //sim.Keyboard.KeyPress(VirtualKeyCode.VK_E);

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                short key = 0x1F; // x12 E key   // S: 0x1F x14 T https://community.bistudio.com/wiki/DIK_KeyCodes
                Send_Key(key, 0x0000);
                System.Threading.Thread.Sleep(20);
                Console.WriteLine("- - - - - - - - - - -  SENT - - - - - - - - - - - - - -");
                Send_Key(key, 0x0002);


            }).Start();

            this.Refresh();
            this.BackColor = Color.FromArgb(255, 244, 244, 244);

            System.Threading.Thread.Sleep(int.Parse(txtBoxPause.Text));

            timer1.Enabled = true;
            btnAuto.BackColor = Color.FromArgb(255, 0, 200, 70); // green
            Auto = true;
        }


        private void Send(short key)
        {
            Send_Key(key, 0x0000);
            System.Threading.Thread.Sleep(20);
            Send_Key(key, 0x0002);
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (trackBar3.Value == 0) { trackBar3.Value = 1; }
            textBoxInterval.Text = trackBar3.Value.ToString();
            timer1.Interval = trackBar3.Value;
        }

        private void textBoxInterval_TextChanged(object sender, EventArgs e)
        {
            trackBar3.Value = int.Parse(textBoxInterval.Text);
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(textBoxX.Text);
        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            trackBar2.Value = int.Parse(textBoxY.Text);
        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // https://stackoverflow.com/questions/28854034/simulate-keyboard-click-in-gtasa 
        // https://www.codeproject.com/Questions/279641/c-sharp-DirectInput-Send-Key


        [DllImport("user32.dll")]
        static extern UInt32 SendInput(UInt32 nInputs, [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] INPUT[] pInputs, Int32 cbSize);

        [StructLayout(LayoutKind.Sequential)]
        struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct KEYBDINPUT
        {
            public short wVk;
            public short wScan;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct HARDWAREINPUT
        {
            public int uMsg;
            public short wParamL;
            public short wParamH;
        }

        [StructLayout(LayoutKind.Explicit)]
        struct INPUT
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(4)]
            public MOUSEINPUT mi;
            [FieldOffset(4)]
            public KEYBDINPUT ki;
            [FieldOffset(4)]
            public HARDWAREINPUT hi;
        }

        const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        const int KEYEVENTF_KEYUP = 0x0002;
        const int KEYEVENTF_UNICODE = 0x0004;
        const int KEYEVENTF_SCANCODE = 0x0008;


        public void Send_Key(short Keycode, int KeyUporDown)
        {
            INPUT[] InputData = new INPUT[1];

            InputData[0].type = 1;
            InputData[0].ki.wScan = Keycode;
            InputData[0].ki.dwFlags = KeyUporDown;
            InputData[0].ki.time = 0;
            InputData[0].ki.dwExtraInfo = IntPtr.Zero;

            SendInput(1, InputData, Marshal.SizeOf(typeof(INPUT)));
        }
    }
    
}

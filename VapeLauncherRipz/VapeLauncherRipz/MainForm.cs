using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VapeLauncherRipz
{
    public partial class main : Form
    {

		[DllImport("user32.dll")]
		private static extern IntPtr FindWindow(string lpclass, string lpwindow);

		// Token: 0x06000003 RID: 3
		[DllImport("kernel32")]
		private static extern bool AllocConsole();

		// Token: 0x06000004 RID: 4
		[DllImport("kernel32.dll")]
		private static extern bool FreeConsole();

		[DllImport("user32.dll")]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		Random rnd = new Random();

		int flagValue1, flagValue2, flagValue3;

		public main()
        {
            InitializeComponent();
            info.Text = "No Minecraft found \r\n Open Minecraft to continue";
			flagValue1 = rnd.Next(40, 55);
			flagValue2 = rnd.Next(90, 123);
			flagValue3 = rnd.Next(140, 180);
		}

		private void StartInject()
        {
			menupanel.Visible = false;
			progres.Start();
        }

		private void searchprocess_Tick(object sender, EventArgs e)
        {
			IntPtr value = FindWindow("LWJGL", null);
			bool flag = value == IntPtr.Zero;
			if (flag)
			{
				this.inject.Visible = false;
				this.inject.Text = "zero";
				this.info.Text = "No Minecraft found \r\n Open Minecraft to continue";
				//this.info.Location = new Point(40, 93);
			}
			else
			{
				this.inject.Visible = true;
				this.inject.Text = value.ToString();
				this.info.Text = "Select a Minecraft to use \r\n Make sure game is fully loaded first";
				//this.text.Location = new Point(30, 93);
			}
		}

        private void progres_Tick(object sender, EventArgs e)
        {
			progress.Visible = true;
            this.progress.Value++;
            bool flag = this.progress.Value == flagValue1;
            if (flag)
            {
                this.sleeper.Start();
                this.progres.Stop();
            }
            bool flag2 = this.progress.Value == flagValue2;
            if (flag2)
            {
                this.sleeper.Start();
                this.progres.Stop();
            }
            bool flag3 = this.progress.Value == flagValue3;
            if (flag3)
            {
                this.sleeper.Start();
                this.progres.Stop();
            }
            bool flag4 = this.progress.Value == 200;
            if (flag4)
            {
                this.progres.Stop();
                this.progresanim.Start();
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
			AllocConsole();
			this.cnsle.Start();
			if (!(FindWindow("LWJGL", null) == IntPtr.Zero))
			{
				this.menupanel.Height = 63;
				this.progres.Start();
			}
			else
			{
				this.menupanel.Height = 184;
				this.info.Text = "No Minecraft found \r\n Open Minecraft to continue";
				this.searchprocess.Start();
			}
		}

        private void cnsle_Tick(object sender, EventArgs e)
        {
			FreeConsole();
        }

        private void progresanim_Tick(object sender, EventArgs e)
        {
			this.progress.Width--;
			this.progress.Location = new Point(this.progress.Location.X + 1, this.progress.Location.Y);
			bool flag = this.progress.Width == 258;
			if (flag)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag2 = this.progress.Width == 254;
			if (flag2)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag3 = this.progress.Width == 250;
			if (flag3)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag4 = this.progress.Width == 246;
			if (flag4)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag5 = this.progress.Width == 242;
			if (flag5)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag6 = this.progress.Width == 238;
			if (flag6)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag7 = this.progress.Width == 234;
			if (flag7)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag8 = this.progress.Width == 230;
			if (flag8)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag9 = this.progress.Width == 226;
			if (flag9)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag10 = this.progress.Width == 222;
			if (flag10)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag11 = this.progress.Width == 218;
			if (flag11)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag12 = this.progress.Width == 214;
			if (flag12)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag13 = this.progress.Width == 210;
			if (flag13)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag14 = this.progress.Width == 206;
			if (flag14)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag15 = this.progress.Width == 202;
			if (flag15)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag16 = this.progress.Width == 198;
			if (flag16)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag17 = this.progress.Width == 194;
			if (flag17)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag18 = this.progress.Width == 190;
			if (flag18)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag19 = this.progress.Width == 186;
			if (flag19)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag20 = this.progress.Width == 182;
			if (flag20)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag21 = this.progress.Width == 178;
			if (flag21)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag22 = this.progress.Width == 174;
			if (flag22)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag23 = this.progress.Width == 170;
			if (flag23)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag24 = this.progress.Width == 166;
			if (flag24)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag25 = this.progress.Width == 162;
			if (flag25)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag26 = this.progress.Width == 158;
			if (flag26)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag27 = this.progress.Width == 154;
			if (flag27)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag28 = this.progress.Width == 150;
			if (flag28)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag29 = this.progress.Width == 146;
			if (flag29)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag30 = this.progress.Width == 142;
			if (flag30)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag31 = this.progress.Width == 138;
			if (flag31)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag32 = this.progress.Width == 134;
			if (flag32)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag33 = this.progress.Width == 130;
			if (flag33)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag34 = this.progress.Width == 126;
			if (flag34)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag35 = this.progress.Width == 122;
			if (flag35)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag36 = this.progress.Width == 118;
			if (flag36)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag37 = this.progress.Width == 114;
			if (flag37)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag38 = this.progress.Width == 110;
			if (flag38)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag39 = this.progress.Width == 106;
			if (flag39)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag40 = this.progress.Width == 102;
			if (flag40)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag41 = this.progress.Width == 98;
			if (flag41)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag42 = this.progress.Width == 94;
			if (flag42)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag43 = this.progress.Width == 90;
			if (flag43)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag44 = this.progress.Width == 86;
			if (flag44)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag45 = this.progress.Width == 82;
			if (flag45)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag46 = this.progress.Width == 78;
			if (flag46)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag47 = this.progress.Width == 74;
			if (flag47)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag48 = this.progress.Width == 70;
			if (flag48)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag49 = this.progress.Width == 66;
			if (flag49)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag50 = this.progress.Width == 62;
			if (flag50)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag51 = this.progress.Width == 58;
			if (flag51)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag52 = this.progress.Width == 54;
			if (flag52)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag53 = this.progress.Width == 50;
			if (flag53)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag54 = this.progress.Width == 46;
			if (flag54)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag55 = this.progress.Width == 42;
			if (flag55)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag56 = this.progress.Width == 38;
			if (flag56)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag57 = this.progress.Width == 34;
			if (flag57)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag58 = this.progress.Width == 30;
			if (flag58)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag59 = this.progress.Width == 26;
			if (flag59)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag60 = this.progress.Width == 22;
			if (flag60)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag61 = this.progress.Width == 18;
			if (flag61)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag62 = this.progress.Width == 14;
			if (flag62)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag63 = this.progress.Width == 10;
			if (flag63)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			bool flag64 = this.progress.Width == 6;
			if (flag64)
			{
				this.progress.Location = new Point(this.progress.Location.X - 2, this.progress.Location.Y);
			}
			if (this.progress.Width == 4)
            {
				closeanim.Start();
            }
		}

        private void sleeper_Tick(object sender, EventArgs e)
        {
            this.progres.Start();
            this.sleeper.Stop();
        }

        private void inject_Click(object sender, EventArgs e)
        {
			StartInject();
        }

        private void closeanim_Tick(object sender, EventArgs e)
        {
			this.Opacity -= .1;
			if (this.Opacity <= 0)
            {
				Environment.Exit(0);
            }
		}
    }
}

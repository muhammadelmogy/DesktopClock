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

namespace Desktop_Clock
{
    public partial class frmClock : Form
    {
        private delegate void RunSetIime(DateTime d);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        public frmClock()
        {
            InitializeComponent();
            this.InitComponent();

            this.beginClock();
        }

        private void beginClock()
        {
            Task task = Task.Run(() =>
            {
                for (; ;)
                {
                    var time = DateTime.Now;

                    this.lblClockDisplay.Invoke(new RunSetIime(SetTime), time);

                    Thread.Sleep((60 - time.Second) * 1000);
                }
            });
        }

        private void SetTime(DateTime d)
        {
            var hour = (d.Hour < 10) ? "0" + d.Hour.ToString() : d.Hour.ToString();
            var min = (d.Minute < 10) ? "0" + d.Minute.ToString() : d.Minute.ToString();
            var time = string.Format("{0}:{1}", hour, min);

            this.lblClockDisplay.Text = time;
            this.lblDate.Text = d.Date.ToLongDateString();
        }

        private void InitComponent()
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.lblOrangeTheme.BackColor = Color.FromArgb(255, 108, 9);
            this.lblBlueTheme.BackColor = Color.FromArgb(24, 116, 205);
            this.lblClose.Font = this.Font;
        }

        private void frmClock_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lblClockDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            this.frmClock_MouseDown(this, e);
        }

        private void lblDate_MouseDown(object sender, MouseEventArgs e)
        {
            this.frmClock_MouseDown(this, e);
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        private void lblOrangeTheme_Click(object sender, EventArgs e)
        {
            this.lblClockDisplay.BackColor = System.Drawing.Color.FromArgb(255, 160, 90);
            this.BackColor = System.Drawing.Color.FromArgb(255, 108, 9);
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(255, 108, 9);
        }

        private void lblBlueTheme_Click(object sender, EventArgs e)
        {
            this.lblClockDisplay.BackColor = Color.FromArgb(30, 144, 255);
            this.BackColor = Color.FromArgb(24, 116, 205);
            this.lblClose.BackColor = Color.FromArgb(24, 116, 205);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            this.lblClose.Font = new Font(this.Font, FontStyle.Bold);
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            this.lblClose.Font = new Font(this.Font, FontStyle.Regular);
        }
    }
}

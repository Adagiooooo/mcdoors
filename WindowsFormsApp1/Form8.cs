using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        private Timer timer;
        private int dotCount = 0;
        private string picTake;

        public Form8(string pic)
        {
            InitializeComponent();
            timer1.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
            Methods.RoundBorders(pictureBox2, 20);
            Methods.RoundBorders(button2, 10);
            Methods.RoundBorders(button1, 10);
            picTake = pic;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button1.Visible = false;
            label1.Visible = false;
            Methods.MatchParentWidth(label2);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            if(picTake == "qr")
            {
                pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "qrcredit", "qranimation.gif"));
                label2.Text = "Scan the QR code below";
                

            }
            else if (picTake == "credit")
            {
                pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "qrcredit", "cardanimation.gif"));
                label2.Text = "Tap you card in the device down below";
            }
            timer = new Timer();
            timer.Interval = 7000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            pictureBox2.Visible = false;
            label1.Visible = true;
            animate();
        }

        private void animate()
        {
          
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                button1.Visible = true;
                label1.Visible = false;
            };
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dotCount++;
            if (dotCount > 4)
                dotCount = 0;

            label1.Text = "Processing" + new string('.', dotCount);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3(picTake);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        private string pic = "";
        public static Form7 instance;
        public Form7()
        {
            InitializeComponent();
            instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaximizeBox = false;
            Methods.CenterSub(panel1);
            Methods.CenterSub(panel2);
            Methods.RoundBorders(panel2, 20);
            Methods.RoundBorders(panel3, 20);
            Methods.RoundBorders(pictureBox5, 30);
            Methods.RoundBorders(pictureBox3, 30); 
            Methods.InheritEvent(panel2, panel2_Click);
            Methods.InheritEvent(panel3, panel3_Click);

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "qr";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "credit";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "qr";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "credit";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "credit";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "credit";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "credit";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "credit";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "qr";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "qr";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            pic = "qr";
            Form3 form3 = new Form3(pic);
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }
    }
}

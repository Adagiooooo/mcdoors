using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string eat;

        public static Form2 instance;
        
        public Form2(string eatText)
        {
            instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.MaximizeBox = false;
            Methods.CenterSub(panel1);
            Methods.CenterSub(panel2);
            Methods.RoundBorders(panel2, 20);
            Methods.RoundBorders(panel3, 20);
            Methods.InheritEvent(panel2, panel2_Click);
            Methods.InheritEvent(panel3, panel3_Click);

            this.eat = eatText;

        }
        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3("");
            Form7 form7 = new Form7();
            form3.eatText = eat;
            form3.paymentMethod = "Card";
            form7.FormClosed += (s, args) => this.Close();
            form7.Show(); 
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3("");
            form3.eatText = eat;
            form3.paymentMethod = "Cash";
            form3.FormClosed += (s, args) => this.Close();
            form3.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

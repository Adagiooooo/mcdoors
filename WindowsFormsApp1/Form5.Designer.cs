namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customization1 = new System.Windows.Forms.Panel();
            this.customText1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dropdown1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customization2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.customText2 = new System.Windows.Forms.Label();
            this.dropdown2 = new System.Windows.Forms.FlowLayoutPanel();
            this.customization3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.customText3 = new System.Windows.Forms.Label();
            this.dropdown3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Iterator = new System.Windows.Forms.Label();
            this.subtract = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.customization1.SuspendLayout();
            this.customization2.SuspendLayout();
            this.customization3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(0, 175);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(734, 63);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "button1";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 188);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 123);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "PHP 00.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Regular Fries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make A Choice";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.customization1);
            this.flowLayoutPanel1.Controls.Add(this.dropdown1);
            this.flowLayoutPanel1.Controls.Add(this.customization2);
            this.flowLayoutPanel1.Controls.Add(this.dropdown2);
            this.flowLayoutPanel1.Controls.Add(this.customization3);
            this.flowLayoutPanel1.Controls.Add(this.dropdown3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(734, 1006);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // customization1
            // 
            this.customization1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customization1.Controls.Add(this.customText1);
            this.customization1.Controls.Add(this.label4);
            this.customization1.Location = new System.Drawing.Point(0, 311);
            this.customization1.Margin = new System.Windows.Forms.Padding(0);
            this.customization1.Name = "customization1";
            this.customization1.Size = new System.Drawing.Size(728, 100);
            this.customization1.TabIndex = 3;
            this.customization1.Click += new System.EventHandler(this.customization1_click);
            this.customization1.Paint += new System.Windows.Forms.PaintEventHandler(this.customization1_Paint);
            // 
            // customText1
            // 
            this.customText1.AutoSize = true;
            this.customText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customText1.Location = new System.Drawing.Point(125, 11);
            this.customText1.Name = "customText1";
            this.customText1.Size = new System.Drawing.Size(19, 25);
            this.customText1.TabIndex = 1;
            this.customText1.Text = "-";
            this.customText1.Click += new System.EventHandler(this.customText1_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(18, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 75);
            this.label4.TabIndex = 0;
            this.label4.Text = "1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropdown1
            // 
            this.dropdown1.AutoScroll = true;
            this.dropdown1.AutoSize = true;
            this.dropdown1.Location = new System.Drawing.Point(0, 411);
            this.dropdown1.Margin = new System.Windows.Forms.Padding(0);
            this.dropdown1.MaximumSize = new System.Drawing.Size(728, 0);
            this.dropdown1.MinimumSize = new System.Drawing.Size(728, 0);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Size = new System.Drawing.Size(728, 0);
            this.dropdown1.TabIndex = 4;
            this.dropdown1.WrapContents = false;
            // 
            // customization2
            // 
            this.customization2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customization2.Controls.Add(this.label5);
            this.customization2.Controls.Add(this.customText2);
            this.customization2.Location = new System.Drawing.Point(0, 411);
            this.customization2.Margin = new System.Windows.Forms.Padding(0);
            this.customization2.Name = "customization2";
            this.customization2.Size = new System.Drawing.Size(728, 100);
            this.customization2.TabIndex = 5;
            this.customization2.Click += new System.EventHandler(this.customization2_click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 75);
            this.label5.TabIndex = 3;
            this.label5.Text = "2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customText2
            // 
            this.customText2.AutoSize = true;
            this.customText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customText2.Location = new System.Drawing.Point(125, 14);
            this.customText2.Name = "customText2";
            this.customText2.Size = new System.Drawing.Size(19, 25);
            this.customText2.TabIndex = 2;
            this.customText2.Text = "-";
            // 
            // dropdown2
            // 
            this.dropdown2.AutoSize = true;
            this.dropdown2.Location = new System.Drawing.Point(0, 511);
            this.dropdown2.Margin = new System.Windows.Forms.Padding(0);
            this.dropdown2.MaximumSize = new System.Drawing.Size(728, 0);
            this.dropdown2.MinimumSize = new System.Drawing.Size(728, 0);
            this.dropdown2.Name = "dropdown2";
            this.dropdown2.Size = new System.Drawing.Size(728, 0);
            this.dropdown2.TabIndex = 6;
            this.dropdown2.WrapContents = false;
            // 
            // customization3
            // 
            this.customization3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customization3.Controls.Add(this.label6);
            this.customization3.Controls.Add(this.customText3);
            this.customization3.Location = new System.Drawing.Point(0, 511);
            this.customization3.Margin = new System.Windows.Forms.Padding(0);
            this.customization3.Name = "customization3";
            this.customization3.Size = new System.Drawing.Size(728, 100);
            this.customization3.TabIndex = 7;
            this.customization3.Click += new System.EventHandler(this.customization3_click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 75);
            this.label6.TabIndex = 4;
            this.label6.Text = "3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customText3
            // 
            this.customText3.AutoSize = true;
            this.customText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customText3.Location = new System.Drawing.Point(125, 9);
            this.customText3.Name = "customText3";
            this.customText3.Size = new System.Drawing.Size(19, 25);
            this.customText3.TabIndex = 0;
            this.customText3.Text = "-";
            // 
            // dropdown3
            // 
            this.dropdown3.AutoScroll = true;
            this.dropdown3.AutoSize = true;
            this.dropdown3.Location = new System.Drawing.Point(0, 611);
            this.dropdown3.Margin = new System.Windows.Forms.Padding(0);
            this.dropdown3.MaximumSize = new System.Drawing.Size(728, 0);
            this.dropdown3.MinimumSize = new System.Drawing.Size(728, 0);
            this.dropdown3.Name = "dropdown3";
            this.dropdown3.Size = new System.Drawing.Size(728, 0);
            this.dropdown3.TabIndex = 8;
            this.dropdown3.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addition);
            this.panel3.Controls.Add(this.subtract);
            this.panel3.Controls.Add(this.Iterator);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 768);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(734, 238);
            this.panel3.TabIndex = 9;
            // 
            // Iterator
            // 
            this.Iterator.AutoSize = true;
            this.Iterator.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iterator.Location = new System.Drawing.Point(325, 46);
            this.Iterator.Name = "Iterator";
            this.Iterator.Size = new System.Drawing.Size(52, 55);
            this.Iterator.TabIndex = 10;
            this.Iterator.Text = "1";
            // 
            // subtract
            // 
            this.subtract.AutoSize = true;
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.Location = new System.Drawing.Point(188, 46);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(41, 55);
            this.subtract.TabIndex = 11;
            this.subtract.Text = "-";
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(474, 46);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(53, 55);
            this.addition.TabIndex = 12;
            this.addition.Text = "+";
            this.addition.Click += new System.EventHandler(this.add_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 1006);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.customization1.ResumeLayout(false);
            this.customization1.PerformLayout();
            this.customization2.ResumeLayout(false);
            this.customization2.PerformLayout();
            this.customization3.ResumeLayout(false);
            this.customization3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel customization1;
        private System.Windows.Forms.FlowLayoutPanel dropdown1;
        private System.Windows.Forms.Panel customization2;
        private System.Windows.Forms.FlowLayoutPanel dropdown2;
        private System.Windows.Forms.Panel customization3;
        private System.Windows.Forms.FlowLayoutPanel dropdown3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label customText1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label customText2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label customText3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Iterator;
        private System.Windows.Forms.Label addition;
        private System.Windows.Forms.Label subtract;
    }
}
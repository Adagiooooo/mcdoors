using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    internal class Methods
    {
        public static void MatchParentWidth(Control control)
        {
            if (control.Parent != null)
            {
                control.Width = control.Parent.ClientSize.Width;
            }
        }
        public static void FlowMargin(Control control)
        {
            if (control.Parent != null)
            {
                // Calculate the X-coordinate for centering the control within its parent
                int centerX = (control.Parent.ClientSize.Width - control.Width) / 2;

                // Set the control's new location to achieve horizontal centering
                control.Location = new Point(centerX, control.Location.Y);
            }
        }

        public static void RoundBorders(Control control, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90);
            path.AddArc(new Rectangle(control.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), 270, 90);
            path.AddArc(new Rectangle(control.Width - cornerRadius * 2, control.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90);
            path.CloseFigure();

            Region region = new Region(path);
            control.Region = region;
        }

        public static void CenterSub(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                // Calculate new X position to center horizontally
                int newX = (panel.Width - control.Width) / 2;

                // Calculate new Y position to center vertically
                int newY = (panel.Height - control.Height) / 2;

                // Set the new location
                control.Location = new Point(newX, newY);
            }
        }

        public static void InheritEvent(Control parentControl, EventHandler clickHandler)
        {
            foreach (Control childControl in parentControl.Controls)
            {
                // Attach the same click event handler to each child control
                childControl.Click += clickHandler;

                // Recursively attach click event handler to child controls of this child control
                InheritEvent(childControl, clickHandler);
            }
        }

        public static void ShowAds(Control control)
        {
            int currentIndex = 0;

            control.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "ads", $"ad{currentIndex + 1}.jpg"));
            control.BackgroundImageLayout = ImageLayout.Stretch;
            currentIndex++;


            Timer timer = new Timer();
            timer.Interval = 4000;
            timer.Tick += (sender, e) =>
            {
                control.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "ads", $"ad{currentIndex + 1}.jpg"));
                control.BackgroundImageLayout = ImageLayout.Stretch;
                currentIndex = (currentIndex + 1) % 4;
            };
            timer.Start();
        }

        public static void ApplyCircularBorder(Control control)
        {
            control.Paint += (sender, e) =>
            {
                using (Graphics g = e.Graphics)
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    // Define the pen for drawing the border
                    using (Pen pen = new Pen(Color.Black, 2))
                    {
                        // Calculate the rectangle to fit the ellipse
                        Rectangle rect = new Rectangle(1, 1, control.Width - 4, control.Height - 4);

                        // Draw the ellipse
                        g.DrawEllipse(pen, rect);
                    }
                }
            };
        }

    }
}

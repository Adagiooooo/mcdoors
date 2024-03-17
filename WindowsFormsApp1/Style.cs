using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Style
    {
        public static void MatchParentWidth(Control control)
        {
            if (control.Parent != null)
            {
                control.Width = control.Parent.ClientSize.Width;
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

    }
}

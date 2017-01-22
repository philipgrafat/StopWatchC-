using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace StopWatch
{
    // http://stackoverflow.com/questions/7731855/rounded-edges-in-picturebox-c-sharp
    public class OvalPictureBox : PictureBox
    {
        public OvalPictureBox()
        {
            this.BackColor = Color.DarkGray;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));
                this.Region = new Region(gp);
            }
        }
    }
}
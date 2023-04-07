using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace DrawingApp
{
    public partial class Paint : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        int index;

        public Paint()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
            }
            pic.Refresh();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}
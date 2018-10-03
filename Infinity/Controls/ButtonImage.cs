using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinity.Controls
{
    public partial class ButtonImage : PictureBox
    {
        // Definición de variables
        Color normalColor = Color.FromArgb(31, 171, 137);
        Color hoverColor = Color.FromArgb(98, 210, 162);
        Color activeColor = Color.FromArgb(157, 243, 196);
        Bitmap image = new Bitmap(@"C:\SOFTWARE\GitHub\Infinity-controls\Infinity\Infinity\recursos\Natural Food_96pxclaro.png");




        public ButtonImage()
        {
            InitializeComponent();
            base.BackgroundImageLayout = ImageLayout.Zoom;
            base.Size = new Size(100, 100);
            base.BackColor = normalColor;
            base.Image = image;
        }



        protected new Bitmap Image
        {
            get { return image; }
            set { image = value; base.Image = value; Invalidate(); }
        }


        public override Image BackgroundImage
        {
            get
            {
                return base.Image;
            }
            set
            {
                base.Image = value;
                Invalidate();
            }
        }

        public new Color BackColor
        {
            get { return normalColor; }
            set
            {
                normalColor = value;
                base.BackColor = value;
                Invalidate();
            }
        }

        public Color HoverColor
        {
            get { return hoverColor; }
            set
            {
                hoverColor = value;
            }
        }

        public Color ActiveColor
        {
            get { return activeColor; }
            set
            {
                activeColor = value;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.BackColor = hoverColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //base.OnMouseLeave(e);
            base.BackColor = normalColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                base.BackColor = activeColor;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);

        }
    }
}

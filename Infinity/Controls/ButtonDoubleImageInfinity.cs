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
    public partial class ButtonDoubleImageInfinity : PictureBox
    {
        // Definición de variables
        private Image Image1;
        private Image Image2;



        public ButtonDoubleImageInfinity()
        {
            InitializeComponent();
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Width = 100;
            this.Height = 100;
        }



        public Image onHoverImage
        {
            get
            {
                return Image2;
            }
            set
            {
                Image2 = value;
            }
        }

        public new Image Image
        {
            get
            {
                return Image1;
            }
            set
            {
                base.BackgroundImage = value;
                Image1 = value;
                Invalidate();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            this.BackgroundImage = Image2;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //base.OnMouseLeave(e);
            this.BackgroundImage = Image1;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
        }
    }
}

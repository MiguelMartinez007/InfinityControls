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
    public partial class ButtonImageInfinity : Control
    {
        //Definicion de variables
        SolidBrush col;

        String icono = @"C:\SOFTWARE\GitHub\InfinityControls\Infinity\recursos\Natural Food_96pxclaro.png";

        Color normalColor;
        Color hoverColor;
        Color activeColor;
        Color foreColor;
        Color activeTextColor;
        Color hoverTextColor;

        int borderImage = 5;

        Bitmap icon;
        Bitmap hoverIcon;
        Bitmap activeIcon;

        ContentAlignment textAlign = ContentAlignment.MiddleLeft;

        Bitmap imagen;

        private int sizeImage = 40;
        bool positionImage = true;




        public ButtonImageInfinity()
        {
            InitializeComponent();
            base.Size = new Size(240, 45);
            base.BackColor = normalColor;
            col = new SolidBrush(foreColor);
            imagen = new Bitmap(icono);

            icon = new Bitmap(icono);
            hoverIcon = new Bitmap(icono);
            activeIcon = new Bitmap(icono);

            base.Font = new Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            normalColor = Color.FromArgb(31, 171, 137);
            hoverColor = Color.FromArgb(98, 210, 162);
            activeColor = Color.FromArgb(157, 243, 196);
            foreColor = Color.FromArgb(215, 251, 232);
            activeTextColor = Color.FromArgb(215, 251, 232);
            hoverTextColor = Color.FromArgb(215, 251, 232);
        }


        public int BorderImage
        {
            get { return borderImage; }
            set { borderImage = value; Invalidate(); }
        }


        public ContentAlignment TextAlign
        {
            get { return textAlign; }
            set { textAlign = value; Invalidate(); }
        }

        public Bitmap Icon
        {
            get { return icon; }
            set { imagen = value; icon = value; Invalidate(); }
        }
        public Bitmap HoverIcon
        {
            get { return hoverIcon; }
            set { hoverIcon = value; Invalidate(); }
        }
        public Bitmap ActiveIcon
        {
            get { return activeIcon; }
            set { activeIcon = value; Invalidate(); }
        }

        public Color ColorFondo
        {
            get { return base.BackColor; }
            set { base.BackColor = value; normalColor = value; Invalidate(); }
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

        public Color HoverTextColor
        {
            get { return hoverTextColor; }
            set
            {
                hoverTextColor = value;
            }
        }

        public Color ActiveTextColor
        {
            get { return activeTextColor; }
            set
            {
                activeTextColor = value;
            }
        }

        public new String Text
        {
            get { return base.Text; }
            set { base.Text = value; Invalidate(); }
        }

        public new Font Font
        {
            get { return base.Font; }
            set { base.Font = value; Invalidate(); }
        }

        public int SizeImage
        {
            get { return sizeImage; }
            set { sizeImage = value; Invalidate(); }
        }

        public new Color ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; Invalidate(); }
        }

        public bool PositionImage
        {
            get { return positionImage; }
            set { positionImage = value; Invalidate(); }
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            Graphics g = pe.Graphics;

            Rectangle rect = pe.ClipRectangle;


            StringFormat formato = new StringFormat();

            switch (textAlign)
            {
                case ContentAlignment.BottomCenter:
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomLeft:
                    formato.Alignment = StringAlignment.Near;
                    formato.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.BottomRight:
                    formato.Alignment = StringAlignment.Far;
                    formato.LineAlignment = StringAlignment.Far;
                    break;
                case ContentAlignment.MiddleCenter:
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleLeft:
                    formato.Alignment = StringAlignment.Near;
                    formato.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.MiddleRight:
                    formato.Alignment = StringAlignment.Far;
                    formato.LineAlignment = StringAlignment.Center;
                    break;
                case ContentAlignment.TopCenter:
                    formato.Alignment = StringAlignment.Center;
                    formato.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopLeft:
                    formato.Alignment = StringAlignment.Near;
                    formato.LineAlignment = StringAlignment.Near;
                    break;
                case ContentAlignment.TopRight:
                    formato.Alignment = StringAlignment.Far;
                    formato.LineAlignment = StringAlignment.Near;
                    break;
                default:
                    break;
            }


            double alineamientoImagen = (rect.Height / 2) - (sizeImage / 2);

            if (positionImage)
            {
                g.DrawImage(imagen, borderImage, (int)alineamientoImagen, sizeImage, sizeImage);

                g.DrawString(Text, Font, Brushes.White, new Rectangle(sizeImage + borderImage, rect.Top, rect.Width - sizeImage - borderImage, rect.Height), formato);
            }
            else
            {
                g.DrawImage(imagen, rect.Width - sizeImage - borderImage, (int)alineamientoImagen, sizeImage, sizeImage);

                g.DrawString(Text, Font, Brushes.White, new Rectangle(5, rect.Top, rect.Width - sizeImage - borderImage, rect.Height), formato);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.BackColor = hoverColor;
            col = new SolidBrush(hoverTextColor);
            imagen = hoverIcon;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.BackColor = normalColor;
            col = new SolidBrush(foreColor);
            imagen = icon;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.BackColor = activeColor;
                col = new SolidBrush(activeTextColor);
                imagen = activeIcon;
            }
        }
    }
}

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
    public partial class ButtonNormal : Control
    {
        // Definición de variables
        Color normalColor = Color.FromArgb(31, 171, 137);
        Color hoverColor = Color.FromArgb(98, 210, 162);
        Color activeColor = Color.FromArgb(157, 243, 196);




        public ButtonNormal()
        {
            InitializeComponent();
            base.Size = new Size(240, 45);
            base.BackColor = normalColor;

            base.Font = new Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }



        protected new Color BackColor
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

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;

            Rectangle rect = ClientRectangle;
            rect.Width--;
            rect.Height--;


            //Font fuente = new Font("Arial", (float)rect.Height * 0.3f, FontStyle.Regular); // Se multiplica por .5 para que la fuente tenga siempre la mitad del tamaño del control

            // Damos formato a la fuente
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            g.DrawString(Text, Font, Brushes.White, new Rectangle(rect.Left, rect.Top, rect.Width, rect.Height), formato);
        }



        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.BackColor = hoverColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.BackColor = normalColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                base.BackColor = activeColor;
                Invalidate();
            }
        }
    }
}

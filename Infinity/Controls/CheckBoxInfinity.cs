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
    public partial class CheckBoxInfinity : Control
    {
        // Declaración de variables
        Color normalColor = Color.Gray;
        Color hoverColor = Color.FromArgb(31, 171, 137);
        Color activeColor = Color.FromArgb(98, 210, 162);
        Color foreColor;

        bool isChecked = false;



        public CheckBoxInfinity()
        {
            InitializeComponent();
            base.Size = new Size(20, 20);
            base.Font = new Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            base.BackColor = normalColor;
            foreColor = Color.White;
        }



        public new Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; foreColor = value; Invalidate(); }
        }

        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; Invalidate(); }
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

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            base.Size = new Size(20, 20);
            Graphics g = pe.Graphics;

            Rectangle rect = ClientRectangle;
            rect.Width--;
            rect.Height--;


            //Font fuente = new Font("Arial", (float)rect.Height * 0.3f, FontStyle.Regular); // Se multiplica por .5 para que la fuente tenga siempre la mitad del tamaño del control

            // Damos formato a la fuente
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;

            if (isChecked)
            {
                SolidBrush col = new SolidBrush(foreColor);

                g.DrawString("✓", Font, col, new Rectangle(rect.Left + 2, rect.Top + 2, rect.Width, rect.Height), formato);
                base.BackColor = activeColor;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isChecked = !isChecked;
                Invalidate();
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!isChecked)
            {
                base.BackColor = hoverColor;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.BackColor = normalColor;
            Invalidate();
        }
    }
}

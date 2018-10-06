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
    public partial class SwitchInfinity2 : Control
    {
        public SwitchInfinity2()
        {
            InitializeComponent();
        }

        // Definicion de variables
        private Color normalColorPrimary = Color.FromArgb(30, 30, 30);
        private Color normalColorSecondary = Color.FromArgb(62, 62, 66);
        private Color activeColorPrimary = Color.FromArgb(67, 75, 179);
        private Color activeColorSecondary = Color.FromArgb(180, 182, 219);
        private Color fontColorNormal = Color.FromArgb(240, 240, 240);
        private Color fontColorActive = Color.FromArgb(240, 240, 240);
        private bool controlSwitch = false;

        // Definicion de las variables publicas
        public Color ActiveColorPrimary
        {
            get { return activeColorPrimary; }
            set
            {
                activeColorPrimary = value;
                Invalidate();
            }
        }
        public Color ActiveColorSecondary
        {
            get { return activeColorSecondary; }
            set
            {
                activeColorSecondary = value;
                Invalidate();
            }
        }

        // Variables publicas para cambiar el color del texto
        public Color FontColorActive
        {
            get { return fontColorActive; }
            set
            {
                fontColorActive = value;
                Invalidate();
            }
        }

        // Funcion publica que permitira cambiar el estado del switch
        public bool EstadoSwitch
        {
            get { return controlSwitch; }
            set
            {
                controlSwitch = value;
                Invalidate();
            }
        }




        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            base.Width = 80;
            base.Height = 35;

            Graphics g = pe.Graphics;

            // Se obtiene el rectangulo que reprecenta al área del control
            Rectangle rect = ClientRectangle;
            rect.Width--;
            rect.Height--;

            // Definición de fuente para el texto
            Font fuente = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);

            // Dividimos el rectangulo para obtener la mitar del control y
            // utilizarlo para dibujar los botones
            rect.Width /= 2;

            // Toma el color de fondo, en este caso el mismo que el padre
            g.FillRectangle(new SolidBrush(Parent.BackColor), ClientRectangle);

            // Se crea el formato para el texto
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Far;
            formato.LineAlignment = StringAlignment.Center;

            // Dibuja 2 rectangulos
            if (controlSwitch)
            {
                g.FillRectangle(new SolidBrush(activeColorSecondary), 0, 0, rect.Width, rect.Height);
                g.FillRectangle(new SolidBrush(activeColorPrimary), rect.Width, 0, rect.Width, rect.Height);
                g.DrawString("ON", fuente, Brushes.White, new Rectangle(9, 11, 60, 13), formato);
            }
            else
            {
                g.FillRectangle(new SolidBrush(normalColorPrimary), 0, 0, rect.Width, rect.Height);
                g.FillRectangle(new SolidBrush(normalColorSecondary), rect.Width, 0, rect.Width, rect.Height);
                g.DrawString("OFF", fuente, Brushes.White, new Rectangle(5, 11, 27, 13), formato);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                controlSwitch = !controlSwitch;
                Invalidate();
            }
        }
    }
}

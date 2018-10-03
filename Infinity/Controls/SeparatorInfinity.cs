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
    public partial class SeparatorInfinity : Control
    {
        // Definición de variables
        Color backColor;
        Size size;


        public SeparatorInfinity()
        {
            InitializeComponent();
            base.BackColor = Color.Black;
            base.Size = new Size(200, 1);
        }





        protected new Color BackColor
        {
            get { return backColor; }
            set { base.BackColor = value; backColor = value; Invalidate(); }
        }

        protected new Size Size
        {
            get { return size; }
            set { base.Size = value; size = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            //base.OnPaint(pe);
            Graphics g = pe.Graphics;
        }
    }
}

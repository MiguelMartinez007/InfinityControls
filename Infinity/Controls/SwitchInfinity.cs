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
    public partial class SwitchInfinity : UserControl
    {
        public SwitchInfinity()
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
                if (controlSwitch) OFF.BackColor = activeColorPrimary;
            }
        }
        public Color ActiveColorSecondary
        {
            get { return activeColorSecondary; }
            set
            {
                activeColorSecondary = value;
                if (controlSwitch) ON.BackColor = activeColorSecondary;
            }
        }
        
        // Variables publicas para cambiar el color del texto
        public Color FontColorActive
        {
            get { return fontColorActive; }
            set
            {
                fontColorActive = value;
                if (controlSwitch) ON.ForeColor = fontColorActive;
            }
        }

        // Funcion publica que permitira cambiar el estado del switch
        public bool EstadoSwitch
        {
            get { return controlSwitch; }
            set
            {
                controlSwitch = value;
                verificacion();
            }
        }



        // Funciones del desarrollador
        void verificacion()
        {
            if (controlSwitch)
            {
                OFF.Visible = false;
                pOFF.BackColor = activeColorPrimary;
                ON.Visible = true;
                pON.BackColor = activeColorSecondary;
            }
            else
            {
                OFF.Visible = true;
                pOFF.BackColor = normalColorSecondary;
                ON.Visible = false;
                pON.BackColor = normalColorPrimary;
            }
        }

        void cabiarEstado()
        {
            controlSwitch = !controlSwitch;
            verificacion();
        }

        void valoresDefault()
        {
            verificacion();

            OFF.ForeColor = fontColorNormal;
            ON.ForeColor = fontColorActive;
        }

        private void SwitchInfinity_Load(object sender, EventArgs e)
        {
            valoresDefault();
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            cabiarEstado();
        }

        private void ON_Click(object sender, EventArgs e)
        {
            cabiarEstado();
        }

        private void pOFF_Click(object sender, EventArgs e)
        {
            cabiarEstado();
        }

        private void pON_Click(object sender, EventArgs e)
        {
            cabiarEstado();
        }
    }
}

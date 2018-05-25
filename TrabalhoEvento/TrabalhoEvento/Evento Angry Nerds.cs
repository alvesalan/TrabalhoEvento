using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoEvento
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSistemaJogadores_Click(object sender, EventArgs e)
        {
            SistemaJogadores sistemaJogadores = new SistemaJogadores();
            sistemaJogadores.Show();
        }
    }
}

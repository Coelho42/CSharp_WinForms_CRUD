using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap09_Winforms_TrabalhoPratico
{
    public partial class Controlo : Form
    {
        public Controlo()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void equipasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipa formEquipa = new Equipa();
            
            
        }

        private void jogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Treinador formTreinador = new Treinador();
          
        }
    }
}

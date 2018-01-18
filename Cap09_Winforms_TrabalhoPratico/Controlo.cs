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
        public List<string> listaEquipas = new List<string>()
        {           
        };

        public List<string> listaJogadores = new List<string>()
        {
        };

        public List<string> listaTreinadores = new List<string>()
        {
        };

        public Controlo()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
        }

        private void equipasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidadeEquipasLista formEquipa = new FormEntidadeEquipasLista();
            formEquipa.ShowDialog();
        }

        private void jogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidadeJogadoresLista formJogador = new FormEntidadeJogadoresLista();
            formJogador.ShowDialog();
        }

        private void treinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidadeTreinadoresLista formTreinador = new FormEntidadeTreinadoresLista();
            formTreinador.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

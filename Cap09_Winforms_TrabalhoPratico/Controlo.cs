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
        static List<Equipa> listaEquipas = new List<Equipa>();

        static List<Jogador> listaJogadores = new List<Jogador>();

        static List<Treinador> listaTreinadores = new List<Treinador>();


        public Controlo()
        {
            InitializeComponent();
        }

        public static List<Equipa> GetListaEquipas()
        {
            return listaEquipas;
        }

        public static List<Jogador> GetListaJogadores()
        {
            return listaJogadores;
        }

        public static List<Treinador> GetListaTreinadores()
        {
            return listaTreinadores;
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

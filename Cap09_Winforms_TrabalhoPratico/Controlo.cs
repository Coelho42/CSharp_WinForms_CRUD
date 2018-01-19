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
        private List<Equipa> listaEquipas = new List<Equipa>();

        private List<Jogador> listaJogadores = new List<Jogador>();

        private List<Treinador> listaTreinadores = new List<Treinador>();

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

        private void Controlo_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Equipa nomeEquipa = new Equipa("yolo");
                listaEquipas.Add(nomeEquipa);
            }

            foreach (Equipa nome in listaEquipas)
            {
                ListViewItem listEquipas = new ListViewItem(
                     new[]
                    {
                         nome.GetNome()
                    });
                listViewEquipas.Items.Add(listEquipas);
            }                              
        }
    }
}

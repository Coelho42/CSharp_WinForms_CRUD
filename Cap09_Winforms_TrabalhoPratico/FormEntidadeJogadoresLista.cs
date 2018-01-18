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
    public partial class FormEntidadeJogadoresLista : Form
    {
        private List<string> listaJogadores = new List<string>()
        {
        };

        public FormEntidadeJogadoresLista()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            listViewJogador.Clear();
            foreach (string jogador in listaJogadores)
            {
                listViewJogador.Items.Add(jogador);
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //listaJogadores.Add(textBoxNome.Text);
            refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewJogador.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewJogador.SelectedIndices[0];
                //listaJogadores[selectedIndex] = textBoxNome.Text;

                refresh();
            }
            else
            {
                MessageBox.Show("Selecione um Jogador");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewJogador.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewJogador.SelectedIndices[0];
                listaJogadores.RemoveAt(selectedIndex);

                refresh();
            }
            else
            {
                MessageBox.Show("Selecione um Jogador");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}

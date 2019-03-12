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
        #region Variáveis
        string strAction;
        int selectedIndex;
        #endregion

        #region Initialize
        public FormEntidadeJogadoresLista()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void FormEntidadeJogadoresLista_Load(object sender, EventArgs e)
        {
            refresh();
        }
        #endregion

        #region Refresh
        public void refresh()
        {
            listViewJogador.Items.Clear();
            foreach (Jogador Jogador in Controlo.GetListaJogadores())
            {                            
                ListViewItem listJogadores = new ListViewItem(
                     new[]
                    {
                         Jogador.nome, Jogador.idade.ToString(), Jogador.altura.ToString(), Jogador.posicao
                    });
                listViewJogador.Items.Add(listJogadores);
            }
        }
        #endregion

        #region Adicionar, Editar e Delete
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            strAction = "Gravar";
            FormEntidadeJogadoresDetalhes formJogadoresDetalhes = new FormEntidadeJogadoresDetalhes(strAction, selectedIndex);
            formJogadoresDetalhes.ShowDialog();
            refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            strAction = "Alterar";
            if (listViewJogador.SelectedIndices.Count > 0)
            {
                selectedIndex = listViewJogador.SelectedIndices[0];
                FormEntidadeJogadoresDetalhes formJogadoresDetalhes = new FormEntidadeJogadoresDetalhes(strAction, selectedIndex);
                formJogadoresDetalhes.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Selecione um Jogador antes de tentar editar.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            strAction = "Apagar";

            if (listViewJogador.SelectedIndices.Count > 0)
            {
                selectedIndex = listViewJogador.SelectedIndices[0];
                FormEntidadeJogadoresDetalhes formJogadoresDetalhes = new FormEntidadeJogadoresDetalhes(strAction, selectedIndex);
                formJogadoresDetalhes.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Selecione um Jogador antes de tentar eliminar");
            }
        }
        #endregion

        #region Close
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

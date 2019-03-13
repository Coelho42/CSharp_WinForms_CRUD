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
    public partial class FormEntidadeTreinadoresLista : Form
    {
        #region Variáveis
        string strAction;
        int selectedIndex;
        #endregion

        #region Initialize
        public FormEntidadeTreinadoresLista()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void FormEntidadeTreinadoresLista_Load(object sender, EventArgs e)
        {
            refresh();
        }
        #endregion

        #region Region
        public void refresh()
        {
            listViewTreinador.Items.Clear();
            foreach (Treinador treinador in Controlo.GetListaTreinadores())
            {
                ListViewItem listTreinadores = new ListViewItem(
                     new[]
                    {
                         treinador.nome, treinador.idade.ToString(), treinador.altura.ToString(), treinador.categoria, treinador.equipa.nome
                    });
                listViewTreinador.Items.Add(listTreinadores);
            }
        }
        #endregion

        #region Adicionar, Editar e Delete
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            strAction = "Gravar";
            FormEntidadeTreinadoresDetalhes formTreinadoresDetalhes = new FormEntidadeTreinadoresDetalhes(strAction, selectedIndex);
            formTreinadoresDetalhes.ShowDialog();
            refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            strAction = "Alterar";

            if (listViewTreinador.SelectedIndices.Count > 0)
            {
                selectedIndex = listViewTreinador.SelectedIndices[0];
                FormEntidadeTreinadoresDetalhes formTreinadoresDetalhes = new FormEntidadeTreinadoresDetalhes(strAction, selectedIndex);
                formTreinadoresDetalhes.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Selecione um Treinador antes de tentar editar");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            strAction = "Apagar";

            if (listViewTreinador.SelectedIndices.Count > 0)
            {
                selectedIndex = listViewTreinador.SelectedIndices[0];
                FormEntidadeTreinadoresDetalhes formTreinadoresDetalhes = new FormEntidadeTreinadoresDetalhes(strAction, selectedIndex);
                formTreinadoresDetalhes.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Selecione um Treinador antes de tentar eliminar");
            }
        }
        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

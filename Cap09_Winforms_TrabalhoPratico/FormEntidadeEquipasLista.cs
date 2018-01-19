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
    public partial class FormEntidadeEquipasLista : Form
    {    

        public FormEntidadeEquipasLista()
        {
            InitializeComponent();
        }

        private void labelJogadores_Click(object sender, EventArgs e)
        {

        }

        private void listViewJogador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            FormEntidadeEquipasDetalhes formEquipasDetalhes = new FormEntidadeEquipasDetalhes();
            formEquipasDetalhes.ShowDialog();
        }
    
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormEntidadeEquipasDetalhes formEquipasDetalhes = new FormEntidadeEquipasDetalhes();
            formEquipasDetalhes.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEntidadeEquipasDetalhes formEquipasDetalhes = new FormEntidadeEquipasDetalhes();
            formEquipasDetalhes.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

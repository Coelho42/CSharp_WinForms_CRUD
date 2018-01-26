﻿using System;
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
        #region Variáveis
        string strAction;
        int selectedIndex;
        #endregion

        #region Initalize
        public FormEntidadeEquipasLista()
        {
            InitializeComponent();
        }
        #endregion

        #region Load
        private void FormEntidadeEquipasLista_Load(object sender, EventArgs e)
        {
            refresh();
        }
        #endregion

        #region Refresh
        public void refresh()
        {
            listViewEquipa.Items.Clear();
            foreach (Equipa Equipa in Controlo.GetListaEquipas())
            {                
                string convocada;

                if(Equipa.getConvocada() == true)
                {
                    convocada = "Sim";
                }
                else
                {
                    convocada = "Não";
                }
                ListViewItem listEquipas = new ListViewItem(
                     new[]
                    {
                         Equipa.getNome(), convocada, Equipa.getLiga()              
                    });
                listViewEquipa.Items.Add(listEquipas);
            }
        }
        #endregion

        #region Adicionar, Editar e Delete
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            strAction = "Gravar";
            FormEntidadeEquipasDetalhes formEquipasDetalhes = new FormEntidadeEquipasDetalhes(strAction, selectedIndex);
            formEquipasDetalhes.ShowDialog();
            refresh();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            strAction = "Alterar";
            if (listViewEquipa.SelectedIndices.Count > 0)
            {
                selectedIndex = listViewEquipa.SelectedIndices[0];
                FormEntidadeEquipasDetalhes formEquipaDetalhes = new FormEntidadeEquipasDetalhes(strAction, selectedIndex);
                formEquipaDetalhes.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Selecione uma Equipa antes de tentar editar");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            strAction = "Apagar";
            
            if (listViewEquipa.SelectedIndices.Count > 0)
            {                
                selectedIndex = listViewEquipa.SelectedIndices[0];
                FormEntidadeEquipasDetalhes formEquipasDetalhes = new FormEntidadeEquipasDetalhes(strAction, selectedIndex);
                formEquipasDetalhes.ShowDialog();
                refresh();
            }
            else
            {
                MessageBox.Show("Selecione uma Equipa antes de tentar eliminar");
            }
        }
        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}

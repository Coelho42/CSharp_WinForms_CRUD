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
    public partial class FormEntidadeEquipasDetalhes : Form
    {
        string strAction;
        int selectedIndex;
        bool convocada = false;

        public FormEntidadeEquipasDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();
            this.strAction = strAction;
            this.selectedIndex = selectedIndex;
            buttonAction.Text = strAction;
        }

        private void FormEntidadeEquipasDetalhes_Load(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":
                    textBoxNome.Text.Trim();
                    textBoxConvocada.Text.Trim(); ;
                    textBoxLiga.Text.Trim();
                    break;

                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaEquipas()[selectedIndex].getNome();
                    if (Controlo.GetListaEquipas()[selectedIndex].getConvocada() == true)
                    {
                        textBoxConvocada.Text = "Sim";
                    }
                    else
                    {
                        textBoxConvocada.Text = "Não";
                    }
                    textBoxLiga.Text = Controlo.GetListaEquipas()[selectedIndex].getLiga();
                    break;

                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaEquipas()[selectedIndex].getNome();
                    textBoxNome.Enabled = false;
                    if (Controlo.GetListaEquipas()[selectedIndex].getConvocada() == true)
                    {
                        textBoxConvocada.Text = "Sim";
                    }
                    else
                    {
                        textBoxConvocada.Text = "Não";
                    }
                    textBoxConvocada.Enabled = false;
                    textBoxLiga.Text = Controlo.GetListaEquipas()[selectedIndex].getLiga();
                    textBoxLiga.Enabled = false;
                    break;
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":

                    // Se campos vazios, erro. Caso contrário passa os dados para a formUm
                    if (textBoxNome.Text == "" || textBoxConvocada.Text == "" || textBoxLiga.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        if (textBoxConvocada.Text == "S" || textBoxConvocada.Text == "s")
                        {                           
                            convocada = true;
                            Equipa Equipa = new Equipa(textBoxNome.Text, convocada, textBoxLiga.Text);
                            Controlo.GetListaEquipas().Add(Equipa);
                            this.Close();
                        }
                        else if (textBoxConvocada.Text == "N" || textBoxConvocada.Text == "n")
                        {
                            convocada = false;
                            Equipa Equipa = new Equipa(textBoxNome.Text, convocada, textBoxLiga.Text);
                            Controlo.GetListaEquipas().Add(Equipa);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ... ");
                        }
                    }
                    break;

                case "Alterar":

                    // Se campos vazios, erro. Caso contrário passa os dados para a formUm
                    if (textBoxNome.Text == "" || textBoxConvocada.Text == "" || textBoxLiga.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        if (textBoxConvocada.Text == "S" || textBoxConvocada.Text == "s")
                        {
                            convocada = true;
                            Equipa Equipa = new Equipa(textBoxNome.Text, convocada, textBoxLiga.Text);
                            Controlo.GetListaEquipas().Add(Equipa);
                            Controlo.GetListaEquipas().Remove(Controlo.GetListaEquipas()[selectedIndex]);
                            this.Close();
                        }
                        else if (textBoxConvocada.Text == "N" || textBoxConvocada.Text == "n")
                        {
                            convocada = false;
                            Equipa Equipa = new Equipa(textBoxNome.Text, convocada, textBoxLiga.Text);
                            Controlo.GetListaEquipas().Add(Equipa);
                            Controlo.GetListaEquipas().Remove(Controlo.GetListaEquipas()[selectedIndex]);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ... ");
                        }
                    }
                    break;

                case "Apagar":
                    Controlo.GetListaEquipas().Remove(Controlo.GetListaEquipas()[selectedIndex]);
                    this.Close();
                    break;
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

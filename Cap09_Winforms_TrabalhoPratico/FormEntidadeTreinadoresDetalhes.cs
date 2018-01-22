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
    public partial class FormEntidadeTreinadoresDetalhes : Form
    {

        string strAction;
        int selectedIndex;
        bool convocada = false;

        public FormEntidadeTreinadoresDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();
            this.strAction = strAction;
            this.selectedIndex = selectedIndex;
            buttonAction.Text = strAction;
        }

        private void FormEntidadeTreinadoresDetalhes_Load(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":
                    textBoxNome.Text = "";
                    textBoxIdade.Text = "";
                    textBoxEquipa.Text = "";
                    break;

                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaTreinadores()[selectedIndex].getNome();
                    if (Controlo.GetListaTreinadores()[selectedIndex].getEquipa() == true)
                    {
                        textBoxEquipa.Text = "Sim";
                    }
                    else
                    {
                        textBoxEquipa.Text = "Não";
                    }
                    textBoxIdade.Text = Controlo.GetListaTreinadores()[selectedIndex].getIdade().ToString();
                    break;

                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaTreinadores()[selectedIndex].getNome();
                    textBoxNome.Enabled = false;
                    if (Controlo.GetListaTreinadores()[selectedIndex].getEquipa() == true)
                    {
                        textBoxEquipa.Text = "Sim";
                    }
                    else
                    {
                        textBoxEquipa.Text = "Não";
                    }
                    textBoxEquipa.Enabled = false;
                    textBoxIdade.Text = Controlo.GetListaTreinadores()[selectedIndex].getIdade().ToString();
                    textBoxIdade.Enabled = false;
                    break;
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":

                    // Se campos vazios, erro. Caso contrário passa os dados para a formUm
                    if (textBoxNome.Text == "" || textBoxEquipa.Text == "" || textBoxIdade.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        if (textBoxEquipa.Text == "S" || textBoxEquipa.Text == "s")
                        {
                            convocada = true;
                            Treinador treinador = new Treinador(textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), convocada);
                            Controlo.GetListaTreinadores().Add(treinador);
                            this.Close();
                        }
                        else if (textBoxEquipa.Text == "N" || textBoxEquipa.Text == "n")
                        {
                            convocada = false;
                            Treinador treinador = new Treinador(textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), convocada);
                            Controlo.GetListaTreinadores().Add(treinador);
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
                    if (textBoxNome.Text == "" || textBoxEquipa.Text == "" || textBoxIdade.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        if (textBoxEquipa.Text == "S" || textBoxEquipa.Text == "s")
                        {
                            convocada = true;
                            Treinador treinador = new Treinador(textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), convocada);
                            Controlo.GetListaTreinadores().Add(treinador);
                            Controlo.GetListaTreinadores().Remove(Controlo.GetListaTreinadores()[selectedIndex]);
                            this.Close();
                        }
                        else if (textBoxEquipa.Text == "N" || textBoxEquipa.Text == "n")
                        {
                            convocada = false;
                            Treinador treinador = new Treinador(textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), convocada);
                            Controlo.GetListaTreinadores().Add(treinador);
                            Controlo.GetListaTreinadores().Remove(Controlo.GetListaTreinadores()[selectedIndex]);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ... ");
                        }
                    }
                    break;

                case "Apagar":
                    Controlo.GetListaTreinadores().Remove(Controlo.GetListaTreinadores()[selectedIndex]);
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

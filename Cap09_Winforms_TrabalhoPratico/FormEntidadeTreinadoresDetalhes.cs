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
        #region Variáveis
        string strAction;
        int selectedIndex;
        bool convocada = false;
        #endregion

        #region Initialize
        public FormEntidadeTreinadoresDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();
            this.strAction = strAction;
            this.selectedIndex = selectedIndex;
            buttonAction.Text = strAction;
        }
        #endregion

        #region Load
        private void FormEntidadeTreinadoresDetalhes_Load(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":
                    textBoxNome.Text.Trim();
                    textBoxIdade.Text.Trim();
                    textBoxEquipa.Text.Trim();
                    break;

                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaTreinadores()[selectedIndex].nome;
                    if (Controlo.GetListaTreinadores()[selectedIndex].equipa == true)
                    {
                        textBoxEquipa.Text = "Sim";
                    }
                    else
                    {
                        textBoxEquipa.Text = "Não";
                    }
                    textBoxIdade.Text = Controlo.GetListaTreinadores()[selectedIndex].idade.ToString();
                    break;

                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaTreinadores()[selectedIndex].nome;
                    textBoxNome.Enabled = false;
                    if (Controlo.GetListaTreinadores()[selectedIndex].equipa == true)
                    {
                        textBoxEquipa.Text = "Sim";
                    }
                    else
                    {
                        textBoxEquipa.Text = "Não";
                    }
                    textBoxEquipa.Enabled = false;
                    textBoxIdade.Text = Controlo.GetListaTreinadores()[selectedIndex].idade.ToString();
                    textBoxIdade.Enabled = false;
                    break;
            }
        }
        #endregion

        private void buttonAction_Click(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":

                    // Se campos vazios, erro. Caso contrário passa os dados para a formUm
                    if (textBoxNome.Text == "" || textBoxEquipa.Text == "" || textBoxIdade.Text == "")
                    {
                        MessageBox.Show("O Treinador não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        int idade;

                        bool idadeT = Int32.TryParse(textBoxIdade.Text, out idade);

                        if (textBoxEquipa.Text == "S" || textBoxEquipa.Text == "s")
                        {
                            convocada = true;
                            if (idadeT == true)
                            {
                                Treinador treinador = new Treinador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), convocada);
                                Controlo.GetListaTreinadores().Add(treinador);                          
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ...");
                            }
                        }
                        else if (textBoxEquipa.Text == "N" || textBoxEquipa.Text == "n")
                        {
                            convocada = false;
                            if (idadeT == true)
                            {
                                Treinador treinador = new Treinador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), convocada);
                                Controlo.GetListaTreinadores().Add(treinador);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ... ");
                            }
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
                        MessageBox.Show("O Treinador não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        int idade;

                        bool idadeT = Int32.TryParse(textBoxIdade.Text, out idade);

                        if (textBoxEquipa.Text == "S" || textBoxEquipa.Text == "s")
                        {
                            convocada = true;
                            if (idadeT == true)
                            {
                                Treinador treinador = new Treinador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), convocada);
                                Controlo.GetListaTreinadores().Add(treinador);
                                Controlo.GetListaTreinadores().Remove(Controlo.GetListaTreinadores()[selectedIndex]);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ...");
                            }
                        }
                        else if (textBoxEquipa.Text == "N" || textBoxEquipa.Text == "n")
                        {
                            convocada = false;
                            if (idadeT == true)
                            {
                                Treinador treinador = new Treinador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), convocada);
                                Controlo.GetListaTreinadores().Add(treinador);
                                Controlo.GetListaTreinadores().Remove(Controlo.GetListaTreinadores()[selectedIndex]);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ... ");
                            }
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

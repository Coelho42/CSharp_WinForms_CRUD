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
    public partial class FormEntidadeJogadoresDetalhes : Form
    {
        string strAction;
        int selectedIndex;

        public FormEntidadeJogadoresDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();
            this.strAction = strAction;
            this.selectedIndex = selectedIndex;
            buttonAction.Text = strAction;
        }

        private void FormEntidadeJogadoresDetalhes_Load(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":
                    textBoxNome.Text = "";
                    textBoxAltura.Text = "";
                    textBoxIdade.Text = "";
                    break;

                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaJogadores()[selectedIndex].getNome();
                    textBoxAltura.Text = Controlo.GetListaJogadores()[selectedIndex].getIdade().ToString();
                    textBoxIdade.Text = Controlo.GetListaJogadores()[selectedIndex].getAltura().ToString();
                    break;

                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaJogadores()[selectedIndex].getNome();
                    textBoxNome.Enabled = false;
                    textBoxAltura.Text = Controlo.GetListaJogadores()[selectedIndex].getIdade().ToString();
                    textBoxAltura.Enabled = false;
                    textBoxIdade.Text = Controlo.GetListaJogadores()[selectedIndex].getAltura().ToString();
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
                    if (textBoxNome.Text == "" || textBoxAltura.Text == "" || textBoxIdade.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        Jogador Jogador = new Jogador(textBoxNome.Text, Convert.ToInt32(textBoxAltura.Text), Convert.ToInt32(textBoxIdade.Text));
                        Controlo.GetListaJogadores().Add(Jogador);
                        this.Close();                 
                    }
                    break;

                case "Alterar":

                    // Se campos vazios, erro. Caso contrário passa os dados para a formUm
                    if (textBoxNome.Text == "" || textBoxAltura.Text == "" || textBoxIdade.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        Jogador Jogador = new Jogador(textBoxNome.Text, Convert.ToInt32(textBoxAltura.Text), Convert.ToInt32(textBoxAltura.Text));
                        Controlo.GetListaJogadores().Add(Jogador);
                        Controlo.GetListaJogadores().Remove(Controlo.GetListaJogadores()[selectedIndex]);
                        this.Close();
                    }                  
                    break;

                case "Apagar":
                    Controlo.GetListaJogadores().Remove(Controlo.GetListaJogadores()[selectedIndex]);
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

        
    


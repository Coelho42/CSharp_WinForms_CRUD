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
        #region Variáveis
        string strAction;
        int selectedIndex;
        #endregion

        #region Initialize
        public FormEntidadeJogadoresDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();
            this.strAction = strAction;
            this.selectedIndex = selectedIndex;
            buttonAction.Text = strAction;
        }
        #endregion

        #region Load
        private void FormEntidadeJogadoresDetalhes_Load(object sender, EventArgs e)
        {
            switch (strAction)
            {
                case "Gravar":
                    textBoxNome.Text.Trim();
                    textBoxIdade.Text.Trim();
                    textBoxAltura.Text.Trim();
                    // preparação da comboBox 
                    // Carregamento da comboBox a partir da tabela
                    List<Jogador> listaJogadores = SQL_Jogador.GetAll();     // Carrega a Lista com todos os registos da tabela
                    comboBoxEquipa.DataSource = new BindingSource(listaJogadores, null);       // Associa a lista à ComboBox
                    comboBoxEquipa.DisplayMember = "Nome";                       // Define qual o campo que surge na comboBox
                    comboBoxEquipa.ValueMember = "Id";                               // Define qual o campo que é extraído.       
                    comboBoxEquipa.SelectedIndex = -1;
                    break;

                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaJogadores()[selectedIndex].nome;
                    textBoxAltura.Text = Controlo.GetListaJogadores()[selectedIndex].idade.ToString();
                    textBoxIdade.Text = Controlo.GetListaJogadores()[selectedIndex].altura.ToString();
                    comboBoxEquipa.DataSource = new BindingSource(Controlo.GetListaJogadores()[selectedIndex].equipa, null);       // Associa a lista à ComboBox
                    comboBoxEquipa.DisplayMember = "Nome";                       // Define qual o campo que surge na comboBox
                    comboBoxEquipa.ValueMember = "Id";                           // Define qual o campo que é extraído.
                    break;

                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaJogadores()[selectedIndex].nome;
                    textBoxNome.Enabled = false;
                    textBoxAltura.Text = Controlo.GetListaJogadores()[selectedIndex].idade.ToString();
                    textBoxAltura.Enabled = false;
                    textBoxIdade.Text = Controlo.GetListaJogadores()[selectedIndex].altura.ToString();
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
                    if (textBoxNome.Text == "" || textBoxAltura.Text == "" || textBoxIdade.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        int idade;
                        double altura;

                        bool idadeT = Int32.TryParse(textBoxIdade.Text, out idade);
                        bool alturaT = Double.TryParse(textBoxAltura.Text, out altura);

                        if (idadeT == true && alturaT == true)
                        {
                            Jogador Jogador = new Jogador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), textBoxPosicao.Text, SQL_Equipa(comboBoxEquipa.SelectedValue));
                            Controlo.GetListaJogadores().Add(Jogador);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ...");
                        }               
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
                        int idade;
                        double altura;

                        bool idadeT = Int32.TryParse(textBoxIdade.Text, out idade);
                        bool alturaT = Double.TryParse(textBoxAltura.Text, out altura);

                        if (idadeT == true && alturaT == true)
                        {
                            Jogador Jogador = new Jogador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), textBoxPosicao.Text);
                            Controlo.GetListaJogadores().Add(Jogador);
                            Controlo.GetListaJogadores().Remove(Controlo.GetListaJogadores()[selectedIndex]);
                            this.Close();
                        }    
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ...");
                        }
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

        
    


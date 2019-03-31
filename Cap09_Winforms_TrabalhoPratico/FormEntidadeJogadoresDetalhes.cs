using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cap09_Winforms_TrabalhoPratico
{
    public partial class FormEntidadeJogadoresDetalhes : Form
    {
        #region Variáveis
        string strAction;
        int selectedIndex;
        List<Equipa> listaEquipas;
        #endregion

        #region Initialize
        public FormEntidadeJogadoresDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();
            this.strAction = strAction;
            this.selectedIndex = selectedIndex;
            buttonAction.Text = strAction;
            listaEquipas = SQL_Equipa.GetAll();     // Carrega a Lista com todos os registos da tabela
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
                    textBoxPosicao.Text.Trim();
                    // preparação da comboBox 
                    // Carregamento da comboBox a partir da tabela   
                    comboBoxEquipa.DataSource = new BindingSource(listaEquipas, null);       // Associa a lista à ComboBox
                    comboBoxEquipa.DisplayMember = "Nome";                       // Define qual o campo que surge na comboBox
                    comboBoxEquipa.ValueMember = "Id";                               // Define qual o campo que é extraído.       
                    comboBoxEquipa.SelectedIndex = -1;
                    break;

                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaJogadores()[selectedIndex].nome;
                    textBoxIdade.Text = Controlo.GetListaJogadores()[selectedIndex].idade.ToString();
                    textBoxAltura.Text = Controlo.GetListaJogadores()[selectedIndex].altura.ToString();
                    textBoxPosicao.Text = Controlo.GetListaJogadores()[selectedIndex].posicao;
                    comboBoxEquipa.DataSource = new BindingSource(listaEquipas, null); ;       // Associa a lista à ComboBox
                    comboBoxEquipa.SelectedText = Controlo.GetListaJogadores()[selectedIndex].equipa.ToString();
                    comboBoxEquipa.DisplayMember = "Nome";                       // Define qual o campo que surge na comboBox
                    comboBoxEquipa.ValueMember = "Id";                           // Define qual o campo que é extraído.
                    break;

                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaJogadores()[selectedIndex].nome;
                    textBoxNome.Enabled = false;
                    textBoxIdade.Text = Controlo.GetListaJogadores()[selectedIndex].idade.ToString();
                    textBoxIdade.Enabled = false;
                    textBoxAltura.Text = Controlo.GetListaJogadores()[selectedIndex].altura.ToString();
                    textBoxAltura.Enabled = false;
                    textBoxPosicao.Text = Controlo.GetListaJogadores()[selectedIndex].posicao;
                    textBoxPosicao.Enabled = false;
                    comboBoxEquipa.DataSource = new BindingSource(listaEquipas, null); ;       // Associa a lista à ComboBox
                    comboBoxEquipa.SelectedText = Controlo.GetListaJogadores()[selectedIndex].equipa.ToString();
                    comboBoxEquipa.DisplayMember = "Nome";                       // Define qual o campo que surge na comboBox
                    comboBoxEquipa.ValueMember = "Id";                           // Define qual o campo que é extraído.
                    comboBoxEquipa.Enabled = false;
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
                    if (textBoxNome.Text == "" || textBoxIdade.Text == "" || textBoxAltura.Text == "" || textBoxPosicao.Text == "" || comboBoxEquipa.SelectedIndex == -1)
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
                            Jogador Jogador = new Jogador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), textBoxPosicao.Text, SQL_Equipa.Get(Convert.ToInt64(comboBoxEquipa.SelectedValue)));
                            SQL_Jogador.Add(Jogador);
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
                            Jogador Jogador = Controlo.GetListaJogadores()[selectedIndex];      // Cria um novo objeto Jogador
                            Jogador.nome = textBoxNome.Text;      // Atribuí o nome ao Jogador
                            Jogador.idade = Convert.ToInt32(textBoxIdade.Text);        // Atribuí a idade ao Jogador
                            Jogador.altura = Convert.ToDouble(textBoxAltura.Text);      // Atribuí a altura ao Jogador
                            Jogador.posicao = textBoxPosicao.Text;      // Atribuí a posição ao Jogador
                            Jogador.equipa = SQL_Equipa.Get(Convert.ToInt64(comboBoxEquipa.SelectedValue));     // Atribuí a equipa ao Jogador
                            SQL_Jogador.Set(Jogador);
                            Controlo.GetListaJogadores().Remove(Controlo.GetListaJogadores()[selectedIndex]);
                            Controlo.GetListaJogadores().Add(Jogador);

                            this.Close();
                        }    
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ...");
                        }
                    }                  
                    break;

                case "Apagar":
                    SQL_Jogador.Del(Controlo.GetListaJogadores()[selectedIndex]);
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

        
    


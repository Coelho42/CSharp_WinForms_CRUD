using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cap09_Winforms_TrabalhoPratico
{
    public partial class FormEntidadeTreinadoresDetalhes : Form
    {
        #region Variáveis
        string strAction;
        int selectedIndex;
        bool convocada = false;
        List<Equipa> listaEquipas;     // Carrega a Lista com todos os registos da tabela
        #endregion

        #region Initialize
        public FormEntidadeTreinadoresDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();
            this.strAction = strAction;
            this.selectedIndex = selectedIndex;
            buttonAction.Text = strAction;
            listaEquipas = SQL_Equipa.GetAll();     // Carrega a Lista com todos os registos da tabela
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
                    textBoxAltura.Text.Trim();
                    textBoxCategoria.Text.Trim();
                    // preparação da comboBox 
                    // Carregamento da comboBox a partir da tabela                   
                    comboBoxEquipa.DataSource = new BindingSource(listaEquipas, null);       // Associa a lista à ComboBox
                    comboBoxEquipa.DisplayMember = "Nome";                       // Define qual o campo que surge na comboBox
                    comboBoxEquipa.ValueMember = "Id";                               // Define qual o campo que é extraído.       
                    comboBoxEquipa.SelectedIndex = -1;
                    break;

                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaTreinadores()[selectedIndex].nome;
                    textBoxIdade.Text = Controlo.GetListaTreinadores()[selectedIndex].idade.ToString();
                    textBoxAltura.Text = Controlo.GetListaTreinadores()[selectedIndex].altura.ToString();
                    textBoxCategoria.Text = Controlo.GetListaTreinadores()[selectedIndex].categoria;
                    comboBoxEquipa.DataSource = new BindingSource(Controlo.GetListaTreinadores()[selectedIndex].equipa, null);       // Associa a lista à ComboBox
                    comboBoxEquipa.SelectedText = Controlo.GetListaTreinadores()[selectedIndex].equipa.ToString();
                    comboBoxEquipa.DisplayMember = "Nome";                       // Define qual o campo que surge na comboBox
                    comboBoxEquipa.ValueMember = "Id";                           // Define qual o campo que é extraído.
                    break;

                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaTreinadores()[selectedIndex].nome;
                    textBoxNome.Enabled = false;
                    textBoxIdade.Text = Controlo.GetListaTreinadores()[selectedIndex].idade.ToString();
                    textBoxIdade.Enabled = false;
                    textBoxAltura.Text = Controlo.GetListaTreinadores()[selectedIndex].altura.ToString();
                    textBoxAltura.Enabled = false;
                    textBoxCategoria.Text = Controlo.GetListaTreinadores()[selectedIndex].categoria;
                    textBoxCategoria.Enabled = false;
                    comboBoxEquipa.DataSource = new BindingSource(Controlo.GetListaTreinadores()[selectedIndex].equipa, null);       // Associa a lista à ComboBox
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
                    if (textBoxNome.Text == "" || textBoxIdade.Text == "" || textBoxAltura.Text == "" || textBoxCategoria.Text == "" || comboBoxEquipa.SelectedIndex == -1)
                    {
                        MessageBox.Show("O Treinador não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        int idade;

                        bool idadeT = Int32.TryParse(textBoxIdade.Text, out idade);

                        if (idadeT == true)
                        {
                            Treinador treinador = new Treinador(0, textBoxNome.Text, Convert.ToInt32(textBoxIdade.Text), Convert.ToDouble(textBoxAltura.Text), textBoxCategoria.Text, SQL_Equipa.Get(Convert.ToInt64(comboBoxEquipa.SelectedValue)));
                            SQL_Treinador.Add(treinador);
                            Controlo.GetListaTreinadores().Add(treinador);
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
                    if (textBoxNome.Text == "" || comboBoxEquipa.SelectedIndex == -1 || textBoxIdade.Text == "")
                    {
                        MessageBox.Show("O Treinador não pode ser criada, porfavor preencha todos os espaços.");
                    }
                    else
                    {
                        int idade;

                        bool idadeT = Int32.TryParse(textBoxIdade.Text, out idade);          
                           
                        if (idadeT == true)
                        {
                            Treinador treinador = Controlo.GetListaTreinadores()[selectedIndex];      // Cria um novo objeto Treinador
                            treinador.nome = textBoxNome.Text;      // Atribuí o nome ao Treinador
                            treinador.idade = Convert.ToInt32(textBoxIdade.Text);        // Atribuí a idade ao Treinador
                            treinador.altura = Convert.ToDouble(textBoxAltura.Text);      // Atribuí a altura ao Treinador
                            treinador.categoria = textBoxCategoria.Text;      // Atribuí a categoria ao Treinador
                            treinador.equipa = SQL_Equipa.Get(Convert.ToInt64(comboBoxEquipa.SelectedValue));     // Atribuí a equipa ao Treinador
                            SQL_Treinador.Set(treinador);
                            Controlo.GetListaTreinadores().Add(treinador);
                            Controlo.GetListaTreinadores().Remove(Controlo.GetListaTreinadores()[selectedIndex]);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ...");
                        }              
                    }
                    break;

                case "Apagar":
                    SQL_Treinador.Del(Controlo.GetListaTreinadores()[selectedIndex]);
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

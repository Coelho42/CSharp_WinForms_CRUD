using Cap09_Winforms_TrabalhoPratico.Sockets;
using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Cap09_Winforms_TrabalhoPratico
{
    /// <summary>
    /// Form dos Detalhes das Equipas
    /// </summary>
    public partial class FormEntidadeEquipasDetalhes : Form
    {
        #region Variáveis
        string strAction;       // String que indica que tipo de Ação vai ser realizada
        int selectedIndex;      // Int que indica o index do registo selecionado na ListView
        bool convocada = false;     // Bool que indica se a equipa foi convocada ou não
        #endregion

        #region Initialize
        /// <summary>
        /// Método de Initialize da interface dos Detalhes das Equipas
        /// </summary>
        /// <param name="strAction"></param>
        /// <param name="selectedIndex"></param>
        public FormEntidadeEquipasDetalhes(string strAction, int selectedIndex)
        {
            InitializeComponent();      // Initialize da Form
            this.strAction = strAction;     // Recebe a StrAction a partir do construtor da interface
            this.selectedIndex = selectedIndex;     // Recebe o index do registo selecionado na ListView
            buttonAction.Text = strAction;      // Atualiza o texto do Button da Interface            
        }
        #endregion

        #region Load
        /// <summary>
        /// Load da interface de detalhes das Equipas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEntidadeEquipasDetalhes_Load(object sender, EventArgs e)
        {
            // Switch que executa uma ação de acordo com a StrAction
            switch (strAction)
            {
                // Caso o conteúdo seja "Gravar" faz...
                case "Gravar":
                    textBoxNome.Text.Trim();        // Dá clear na TextBox do Nome
                    textBoxConvocada.Text.Trim();       // Dá clear na TextBox Convocada
                    textBoxLiga.Text.Trim();        // Dá clear na TextBox da Liga
                    break;

                // Caso o conteúdo seja "Gravar" faz...
                case "Alterar":
                    textBoxNome.Text = Controlo.GetListaEquipas()[selectedIndex].nome;      // Recebe o nome do registo selecionado
                    if (Controlo.GetListaEquipas()[selectedIndex].convocada == true)        // Verifica se o conteúdo da propriedade convocada está a true
                    {
                        textBoxConvocada.Text = "Sim";      // Dá o valor de "Sim" à TextBox Convocada
                    }
                    else  // Verifica se o conteúdo da propriedade convocada está a false
                    {
                        textBoxConvocada.Text = "Não";       // Dá o valor de "Não" à TextBox Convocada
                    }
                    textBoxLiga.Text = Controlo.GetListaEquipas()[selectedIndex].liga;      // Recebe a Liga do registo selecionado
                    break;

                // Caso o conteúdo seja "Apagar" faz...
                case "Apagar":
                    textBoxNome.Text = Controlo.GetListaEquipas()[selectedIndex].nome;      // Recebe o nome do registo selecionado          
                    textBoxNome.Enabled = false;        // Dá disable na TextBox do nome
                    if (Controlo.GetListaEquipas()[selectedIndex].convocada == true)         // Verifica se o conteúdo da propriedade convocada está a true
                    {
                        textBoxConvocada.Text = "Sim";      // Dá o valor de "Sim" à TextBox Convocada
                    }
                    else  // Verifica se o conteúdo da propriedade convocada está a false
                    {
                        textBoxConvocada.Text = "Não";      // Dá o valor de "Não" à TextBox Convocada
                    }
                    textBoxConvocada.Enabled = false;       // Dá disable na TextBox Convocada
                    textBoxLiga.Text = Controlo.GetListaEquipas()[selectedIndex].liga;  // Recebe a Liga do registo selecionado
                    textBoxLiga.Enabled = false;        // Dá disable na TextBox da Liga
                    break;
            }
        }
        #endregion

        /// <summary>
        /// Método que realiza o CRUD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAction_Click(object sender, EventArgs e)
        {
            // Switch que executa uma ação de acordo com a StrAction 
            switch (strAction)
            {
                // Caso o conteúdo seja "Gravar" faz...
                case "Gravar":
                    // Se campos vazios, erro. Caso contrário passa os dados para a formUm
                    if (textBoxNome.Text == "" || textBoxConvocada.Text == "" || textBoxLiga.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");       // MessageBox de Alerta
                    }
                    else
                    {
                        // Verifica Se o conteúdo da TextBox Convocada é "Sim"
                        if (textBoxConvocada.Text == "Sim" || textBoxConvocada.Text == "sim")
                        {                           
                            convocada = true;       // Torna o boolean Convocada true
                            Equipa Equipa = new Equipa(0, textBoxNome.Text, convocada, textBoxLiga.Text);       // Cria um novo objeto Equipa
                            SQL_Equipa.Add(Equipa);     // Adiciona a equipa à base de dados
                            Controlo.GetListaEquipas().Add(Equipa);     // Adiciona a equipa à ListView
                            this.Close();       // Fecha a interface
                        }
                        // Verifica Se o conteúdo da TextBox Convocada é "Não"
                        else if (textBoxConvocada.Text == "Não" || textBoxConvocada.Text == "não")
                        {
                            convocada = false;      // Torna o boolean Convocada false
                            Equipa Equipa = new Equipa(0, textBoxNome.Text, convocada, textBoxLiga.Text);       // Cria um novo objeto Equipa
                            SQL_Equipa.Add(Equipa);     // Adiciona a equipa à base de dados
                            Controlo.GetListaEquipas().Add(Equipa);      // Adiciona a equipa à ListView    
                            this.Close();       // Fecha a interface
                        }
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ... ");        // MessageBox de Alerta
                        }
                    }
                    break;

                // Caso o conteúdo seja "Gravar" faz...
                case "Alterar":

                    // Se campos vazios, erro. Caso contrário passa os dados para a formUm
                    if (textBoxNome.Text == "" || textBoxConvocada.Text == "" || textBoxLiga.Text == "")
                    {
                        MessageBox.Show("A Equipa não pode ser criada, porfavor preencha todos os espaços.");       // MessageBox de Alerta
                    }
                    else
                    {
                        // Verifica Se o conteúdo da TextBox Convocada é "Sim"
                        if (textBoxConvocada.Text == "Sim" || textBoxConvocada.Text == "sim")
                        {
                            convocada = true;       // Torna o boolean Convocada true
                            Equipa Equipa = Controlo.GetListaEquipas()[selectedIndex];      // Cria um novo objeto Equipa
                            Equipa.nome = textBoxNome.Text;      // Atribuí o nome à Equipa
                            Equipa.convocada = convocada;        // Atribuí o valor do atributo convocada à Equipa
                            Equipa.liga = textBoxLiga.Text;      // Atribuí o nome à Equipa
                            SQL_Equipa.Set(Equipa);     // Atualiza a Equipa na base de dados
                            Controlo.GetListaEquipas().Add(Equipa);     // Atualiza a Equipa na Listview
                            Controlo.GetListaEquipas().Remove(Controlo.GetListaEquipas()[selectedIndex]);       // Atualiza a Equipa na Listview
                            this.Close();         // Fecha a interface
                        }
                        // Verifica Se o conteúdo da TextBox Convocada é "Não"
                        else if (textBoxConvocada.Text == "Não" || textBoxConvocada.Text == "não")
                        {
                            convocada = false;       // Torna o boolean Convocada false
                            Equipa Equipa = Controlo.GetListaEquipas()[selectedIndex];       // Cria um novo objeto Equipa
                            Equipa.nome = textBoxNome.Text;      // Atribuí o nome à Equipa
                            Equipa.convocada = convocada;        // Atribuí o valor do atributo convocada à Equipa
                            Equipa.liga = textBoxLiga.Text;      // Atribuí o nome à Equipa
                            SQL_Equipa.Set(Equipa);       // Atualiza a Equipa na base de dados
                            Controlo.GetListaEquipas().Add(Equipa);       // Atualiza a Equipa na Listview
                            Controlo.GetListaEquipas().Remove(Controlo.GetListaEquipas()[selectedIndex]);        // Atualiza a Equipa na Listview
                            this.Close();         // Fecha a interface
                        }
                        else
                        {
                            MessageBox.Show("O que introduziu não se encontra de acordo com os parâmetros que são requeridos ... ");        // MessageBox de Alerta
                        }
                    }
                    break;

                // Caso o conteúdo seja "Apagar" faz...
                case "Apagar":
                    if (!SQL_Equipa.CheckRelationalIntegrityViolation(Controlo.GetListaEquipas()[selectedIndex]))
                    {
                        SQL_Equipa.Del(Controlo.GetListaEquipas()[selectedIndex]);      // Apaga a Equipa da base de dados
                    }
                   
                    this.Close();       // Fecha a interface
                    break;

                case "Sockets":
                    try
                    {
                        // Código dos dados para descodificação em receiveCalBack
                        byte[] buffer1 = Encoding.UTF8.GetBytes("MSG_EQUIPA");

                        if(textBoxConvocada.Text == "Sim" || textBoxConvocada.Text == "sim")
                        {
                            convocada = true;
                        }
                        else if (textBoxConvocada.Text == "Não" || textBoxConvocada.Text == "não")
                        {
                            convocada = false;
                        }

                        // Recolha e Serialização dos atributos da Pessoa pelo construtor
                        MessageBox.Show(textBoxNome.Text.ToString());
                        Equipa equipa = new Equipa(textBoxNome.Text, convocada, textBoxLiga.Text);
                        byte[] buffer2 = equipa.ToByteArray();
                        MessageBox.Show(equipa.nome.ToString() + " " + equipa.convocada.ToString() + " " + equipa.liga.ToString());

                        // Concatenação dos 2 arrays num 3º. BlockCopy é a opção
                        // preferida, mas há outras muito mais rápidas.
                        // Copia N bytes de um array origem, com início no elemento x
                        // para um array de destino, começando num elemento y

                        // Criação do Array de Bytes final com a dimensão dos 2 Arrays
                        byte[] buffer = new byte[buffer1.Length + buffer2.Length];

                        // Cópia do Array1 para início do Array final
                        Buffer.BlockCopy(
                            buffer1,            // Array Origem
                            0,                  // início da cópia no Array origem
                            buffer,             // Array Destino
                            0,                  // início da concatenação no Array destino
                            buffer1.Length);    // nº de bytes a copiar

                        // Cópia do Array2 para o Array final, a seguir ao Array1
                        Buffer.BlockCopy(
                            buffer2,            // Array Origem
                            0,                  // início da cópia no Array origem
                            buffer,             // Array Destino
                            buffer1.Length,     // início da concatenação no Array destino
                            buffer2.Length);    // nº de bytes a copiar

                        // Início do envio dos dados através do socket em 2 passos
                        // 1º BeginSend() cria nova thread
                        // 2º Envia o método callBack para a thread, onde é executado, 
                        // libertando a presente thread.
                        // O ultimo argumento é o próprio socket que será entregue ao método callBack
                        // através de um parâmetro Async Result (ver o método na classe Networking)
                        if (Tools.IsServer)
                        {
                            NetWorkingServer.socketToClient.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, NetWorkingServer.SendCallback, NetWorkingServer.socketToClient);
                        }
                        else
                        {
                            NetWorkingCliente.socketToServer.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, NetWorkingCliente.SendCallBack, NetWorkingCliente.socketToServer);
                        }                      
                    }
                    catch (SocketException ex)
                    {
                        Tools.ShowDialog("Client: ButtonSendTring: SocketException:\n\n" + ex.Message);
                    }
                    catch (ObjectDisposedException ex)
                    {
                        Tools.ShowDialog("Client: ButtonSend: ObjectDisposedException:\n\n" + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Tools.ShowDialog("Client: ButtonSend: Exceção genérica:\n\n" + ex.Message);
                    }

                    this.Close();       // Fecha a interface
                    break;
            }
        }
        /// <summary>
        /// Fecha a Interface dos Detalhes da Equipa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();         // Fecha a interface
        }
    }
}

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Cap09_Winforms_TrabalhoPratico.Sockets
{
    /// <summary>
    /// Form de trabalho que assume dois tipos de startup:
    /// - Server inicia um listener para receber chamadas de
    ///   clientes. Assim que recebe, passa-a a um socket local
    /// - Cliente inicia desativado e quando ....
    /// 
    /// </summary>
    public partial class FormWork : Form
    {    
        #region Load e Construtores

        /// <summary>
        /// Recebe a form startup para a poder
        /// fachar no método override do botão X
        /// 
        /// Altera o nome do buttonStartApp e o 
        /// title da form em função
        /// do boolean de Tools
        /// </summary>
        public FormWork()
        {
            InitializeComponent();

            // Altera o nome do título da form
            if (Tools.IsServer)
            {
                this.Text = "Server";
                buttonConnect.Text = "Start Server";
                textBoxIPAddress.Visible = false;
                labelIP.Visible = false;
            }
            else
            {
                this.Text = "Cliente";
                buttonConnect.Text = "Connect to Server";
            }
        }

        /// <summary>
        /// Desativar objetos de transmissão
        /// Load atua logo a seguir ao construtor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormWork_Load(object sender, EventArgs e)
        {
            UpdateControlStates(false);

            // Botão de criação de nova instancia apenas para Server
            if (Tools.IsServer) buttonNewClient.Visible = true;
            else buttonNewClient.Visible = false;
        }

        #endregion

        #region Métodos Invoke

        /// <summary>
        /// Adiciona uma pessoa à dataGridView
        /// Invoke permite acesso seguro de uma  thread 
        /// secundária à dataGrid que está na thread principal
        /// </summary>
        internal void SubmitPersonToDataGrid()
        {
            Invoke((Action)delegate
            {
                //dataGridView.Rows.Add(pessoa.Name, pessoa.Age, pessoa.IsMale);
            });
        }

        /// <summary>
        /// Remove uma pessoa da dataGridView
        /// Invoke permite acesso seguro de uma  thread 
        /// secundária à dataGrid que está na thread principal
        /// </summary>
        /// <param name="pessoa"></param>
        internal void RemovePersonToDataGrid(/*Pessoa pessoa*/)
        {
            Invoke((Action)delegate
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    /*
                    if (row.Cells[0].Value != null &&
                         row.Cells[0].Value.ToString() == pessoa.Name &&
                         row.Cells[1].Value.ToString() == pessoa.IsMale.ToString() &&
                         row.Cells[0].Value.ToString() == pessoa.Age.ToString())
                    {
                        dataGridView.Rows.Remove(row);
                    }
                    */
                }
            });
        }

        /// <summary>
        /// Ativa ou desativa objetos da Form
        /// em função do estado do botão Connect
        /// True => Comunicação ativa
        /// False=> Comunicação inativa
        /// </summary>
        /// <param name="toggle"></param>
        internal void UpdateControlStates(bool toggle)
        {
            // Acesso seguro à thread principal a partir
            // de threads secundárias.
            Invoke((Action)delegate
            {
                // Faz desaparecer o IP para o server
                if (Tools.IsServer)
                {
                    labelIP.Visible = textBoxIPAddress.Visible = false;
                    textBoxIPAddress.Visible = false;
                }
                else
                {
                    labelIP.Visible = textBoxIPAddress.Visible = true;
                    textBoxIPAddress.Visible = true;
                }

                // Objetos da Ligação
                buttonConnect.Enabled = !toggle;
                textBoxIPAddress.Enabled = !toggle;

                // Objetos de transmissão
                groupBoxObjetos.Enabled = toggle;
                groupBoxStrings.Enabled = toggle;
            });
        }

        /// <summary>
        /// Atualização da Label de estado da ligação
        /// </summary>
        /// <param name="state"></param>
        internal void UpdateConnectionStateLabel(string state, Color color)
        {
            Invoke((Action)delegate
            {
                labelConnectionState.Text = state;
                labelConnectionState.ForeColor = color;
            });
        }

        /// <summary>
        /// Atualização da Imagem do estado da ligação
        /// </summary>
        /// <param name="state"></param>
        internal void UpdateConnectionImage(Image newImage)
        {
            Invoke((Action)delegate
            {
                pictureBoxConnection.Image = newImage;
            });
        }

        /// <summary>
        /// Atualização TextBoxStringReceived com a nova string recebida
        /// </summary>
        /// <param name="state"></param>
        internal void UpdateTextBoxStringsReceived(string msg)
        {
            Invoke((Action)delegate
            {
                textBoxStringsReceived.Text += msg + "\r\n";
            });
        }


        #endregion

        #region Botões Comunicação: Connect e Send

        /// <summary>
        /// FAz arrancar o server ou Client conforme
        /// o boolean IsServer de Tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // Startup do server ou client
            if (Tools.IsServer)
            {
                NetWorkingServer.StartServer(this);
            }
            else
            {
                NetWorkingCliente.ConnectToServer(textBoxIPAddress.Text, this);
            }

            // Desativa botão após iniciar a ligação.
            buttonConnect.Enabled = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // ENVIO DE MENSAGENS
        // Para enviar vários tipos de dados, optou-se por usar os 1ºs 10 bytes para 
        // o código da mensagem. este código vai permitir ao método ReceiveCallBack
        // perceber o tipo de mensagem que recebe, podendo extrai-la em conformidade.
        // Os códigos são:
        // - MSG_STRING para enviar apenas strings
        // - MSG_PERSON para enviar objetos Pessoa
        // - MSG_SRV_OK para o Server notificar o Client que a ligação estabelecida e
        //   assim poder alterar o aspeto da interface para iniciar o envio de msgs.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Envia uma String
        /// O array de bytes a enviar é composto por duas partes
        /// 1º MSG_STRING
        /// 2º a string da menssagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendString_Click(object sender, EventArgs e)
        {
            // proteção do preenchimento do campo nome.
            if (textBoxStringtoSend.Text.Equals(""))
            {
                Tools.ShowDialog("Preencha o campo!");
                return;
            }

            try
            {
                // Preparação dos dados (Sempre num array de bytes)
                // 1ºs 10 bytes para o código, seguido da string da msg
                // A serialização Converte toda a string para um byte array
                Byte[] buffer = Encoding.UTF8.GetBytes("MSG_STRING" + textBoxStringtoSend.Text.Trim());

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

                // Limpesa da textBox
                textBoxStringtoSend.Text = "";
            }
            catch (SocketException ex)
            {
                UpdateControlStates(false); // atualiza os botões da form
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
        }

        /// <summary>
        /// Envia um Objeto Pessoa serializado
        /// O array de bytes a enviar é composto por duas partes
        /// 1º MSG_PERSON
        /// 2º o objeto serializado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSendObject_Click(object sender, EventArgs e)
        {
            /*
            // proteção do preenchimento do campo nome.
            if (textBoxPessoaNome.Text.Equals(""))
            {
                Tools.ShowDialog("Preencha o campo nome!");
                return;
            }

            try
            {
                // Código dos dados para descodificação em receiveCalBack
                byte[] buffer1 = Encoding.UTF8.GetBytes("MSG_PERSON");

                // Recolha e Serialização dos atributos da Pessoa pelo construtor
                Pessoa pessoa = new Pessoa(checkBoxPessoaGenero.Checked, (ushort)numberBoxPessoaIdade.Value, textBoxPessoaNome.Text);
                byte[] buffer2 = pessoa.ToByteArray();

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
                Tools.ShowDialog("FormWork: ButtonSend: SocketException:" + ex.Message);
                UpdateControlStates(false); // atualiza os botões da form
            }
            catch (ObjectDisposedException ex)
            {
                Tools.ShowDialog("FormWork: ButtonSend: ObjectDisposedException: " + ex.Message);
                UpdateControlStates(false); // atualiza os botões da form
            }
            catch (Exception ex)
            {
                Tools.ShowDialog("FormWork: ButtonSend: Exceção genérica: " + ex.Message);
                UpdateControlStates(false); // atualiza os botões da form
            }
            */
        }

        #endregion

        private void labelConnectionState_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using static Cap09_Winforms_TrabalhoPratico.Sockets.Tools;

namespace Cap09_Winforms_TrabalhoPratico.Sockets
{
    class NetWorkingCliente
    {
        #region Dados Locais

        /// <summary>
        /// Array de bytes para receber e enviar os dados
        /// </summary>
        private static byte[] buffer;        

        // <summary>
        /// PORTO do SERVER fixo de receção de ligações de clientes
        /// </summary>
        private static int SERVER_PORT = 8888;

        /// <summary>
        /// Atributo - Recebe a Form para que estes métodos possam 
        /// aceder aos seus gráficos
        /// </summary>
        private static FormWork formWork;

        /// <summary>
        /// Socket para comunicação com o Server
        /// </summary>
        internal static Socket socketToServer;

        #endregion

        #region Métodos de comunicação Síncronos e Assíncronos CallBack

        /// <summary>
        /// Método Síncrono para o botão da Form iniciar a ligação
        /// </summary>
        /// <param name="ipAdress">contém o ip da textBox da Form</param>
        /// <param name="form">Contém a ref da form, para manipulação gráfica</param>
        internal static void ConnectToServer(String ipAdress, FormWork form)
        {
            // registo da ServerForm no atributo local para que
            // os métodos CallBack possam manipular as ListViews
            // da form.
            formWork = form;

            // atualização da label de estado da ligação e da imagem, na form.
            formWork.UpdateConnectionStateLabel("Connecting", Color.Orange);

            try
            {
                socketToServer = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);

                // Definição do endereço e porto.
                var remoteEndPoint = new IPEndPoint(IPAddress.Parse(ipAdress), SERVER_PORT);

                // Inicia a ligação em 2 passos
                // 1º BeginConnect() cria uma thread
                // 2º Envia o método CallBack para a thread onde executa a ligação, 
                // libertando a presente thread. Notar que o ultimo argumento é o 
                // próprio socket que será entregue ao método callBack através de 
                // um parâmetro Async Result (ver o método na classe Networking)
                socketToServer.BeginConnect(remoteEndPoint, ConnectCallBack, socketToServer);
            }
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação e da imagem, na form.
                formWork.UpdateConnectionStateLabel("OFF", Color.DarkRed);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                ShowDialog("NetWorkingCliente: ConnectToServer - SocketException:\n\n" + ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingCliente: ConnectToServer - ButtonConnectObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                ShowDialog("NetWorkingCliente: ConnectToServer - genérica:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// ConnectCallBack() 
        /// É chamado pelo método ConnectToServer para concluir a
        /// É executado dentro de uma nova thread, ou seja, em modo assíncrono
        /// </summary>
        /// <param name="AR">Async Result é um Object que recebe dados da chamada anterior</param>
        internal static void ConnectCallBack(IAsyncResult AR)
        {
            //Socket local
            Socket clientSocket = null;

            // atualização da label de estado da ligação, na form.
            formWork.UpdateConnectionStateLabel("ON", Color.Green);
            formWork.UpdateControlStates(true);

            try
            {
                // Socket local recebe cópia do socket enviádo em AR
                clientSocket = (Socket)AR.AsyncState;

                // 2º passo da ligação. EndConnect() executa a ligação
                // Se sucesso, prosegue, caso contrário gera exceção.
                clientSocket.EndConnect(AR);

                // Redimensionamento do array de bytes para receber o array do socket
                buffer = new byte[clientSocket.ReceiveBufferSize];

                // Início da receção dos dados numa nova thread.
                // 1º BeginReceive() cria uma nova thread
                // 2º Envia o método callBack para a thread, onde é executado, 
                // libertando a presente thread.
                // O ultimo argumento é o próprio socket que será entregue ao método callBack
                // através de um parâmetro Async Result (ver o método na classe Networking)
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallBack, clientSocket);
            }
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação, na form.
                formWork.UpdateConnectionStateLabel("OFF", Color.DarkRed);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                ShowDialog(
                    "NetWorkingCliente: ConnectCallback: SocketException:\n\n" 
                    + ex.Message + "\n\n"
                    + "Problemas a Verificar:\n"
                    + "Server não está ativo! -> Ligue o Server\n"
                    + "Firewall está a bloquear a app! -> Crie uma exceção para a app");
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingCliente: ConnectCallback: ObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                ShowDialog("NetWorkingCliente: ConnectCallback: Exceção genérica:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// ReceiveCallback()
        /// Conclui a receção dos dados, iniciada em 
        /// AcceptCallback() com socket.BeginReceive(). 
        /// 1º extrai o socket do objeto AR
        /// 2º extrai o array de bytes do socket
        /// 3º converte os dados para o objeto final
        /// 4º É executado dentro de uma nova thread, ou seja, em modo assíncrono
        /// </summary>
        /// <param name="AR">Async Result é um Object que recebe dados da chamada anterior</param>
        internal static void ReceiveCallBack(IAsyncResult AR)
        {
            // Socket local
            Socket clientSocket = null;

            try
            {
                // Socket local recebe cópia do socket enviádo em AR
                clientSocket = (Socket)AR.AsyncState;

                // Extração da string do array de bytes do socket. ATENÇÃO:
                // O array vem com 65536 bytes, mas a mensagem contem apenas 9
                // bytes. "SERVER_OK" contém 9 chars (1 byte cada). Converter o
                // array diretamente para string, extrai a string de 9 chars e 
                // 65536-9 bytes que resultam em witspaces na conversão.

                // Extração do tamanho util da mensagem (sem white spaces)
                int messageLengthReceived = clientSocket.EndReceive(AR);

                // Caso o Server desligue, a Socket exception vai ser 
                // lançada aqui. Ao ser apanhada, o socket é retirado 
                // da lista e o socket encerrado

                // Controlo da receção. Se tamanho do array de bytes (a mensagem)
                // vem a zero => aborta pq não há mensagem a tratar
                if (messageLengthReceived == 0) return;

                // extração da MSG. Contém 10 bytes, a começar no elemento 0
                string msgCode = Encoding.UTF8.GetString(buffer, 0, 10);

                switch (msgCode)
                {
                    case "MSG_EQUIPA":
                        // A partir do byte 10, o array contém os dados do obj Pessoa 
                        // => contrutor com desSerialização
                        Equipa equipa = new Equipa(buffer);
                        MessageBox.Show(equipa.nome + " " + equipa.convocada + " " + equipa.liga);

                        // Adicão da pessoa à DataGrid
                        // A FormServer foi passada para um atributo local, 
                        // desta class para a thread possa aceder de forma
                        // segura ao método da thread principal que insere
                        // dados na DataGridView.
                        formWork.SubmitEquipaToDataGrid(equipa);
                        break;

                    case "MSG__SV_OK":
                        // Atualização dos objetos da form
                        formWork.UpdateControlStates(true);
                        break;
                }

                // Início de nova receção dos dados numa nova thread.
                // 1º BeginReceive() cria uma nova thread
                // 2º Envia o método callBack para a thread, onde é executado, 
                // libertando a presente thread.
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallBack, clientSocket);
            }
            // Avoid Pokemon exception handling in cases like these.
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação e da imagem, na form.
                formWork.UpdateConnectionStateLabel("OFF", Color.DarkRed);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                ShowDialog("NetWorkingCliente: ReceiveCallback: SocketException:\n\n" + ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingCliente: ReceiveCallback: ObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                ShowDialog("NetWorkingCliente: ReceiveCallback: Exceção genérica:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// SendCallBack()
        /// Conclui o envio de dados, iniciado em 
        /// AcceptCallback() com socket.BeginSend().
        /// para enviar a srintg MSG_SRV_OK ao cliente
        /// 1º extrai o socket do objeto AR
        /// 2º Conclui o envio dos dados 
        /// É executado dentro de uma nova thread, ou seja, em modo assíncrono
        /// </summary>
        /// <param name="AR">Async Result é um Object que recebe dados da chamada anterior</param>
        internal static void SendCallBack(IAsyncResult AR)
        {
            // Socket local
            Socket clientSocket = null;

            try
            {
                // Socket local recebe cópia do socket enviádo em AR
                clientSocket = (Socket)AR.AsyncState;

                // Conclui o envio de dados. EndSend() executa o envio.
                clientSocket.EndSend(AR);
            }
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação e da imagem, na form.
                formWork.UpdateConnectionStateLabel("OFF", Color.DarkRed);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                ShowDialog("NetWorkingCliente: SendCallback: SocketException:\n\n" + ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingCliente: SendCallback: ObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                ShowDialog("NetWorkingCliente: SendCallback: Exceção genérica:\n\n" + ex.Message);
            }
        }
        #endregion
    }
}
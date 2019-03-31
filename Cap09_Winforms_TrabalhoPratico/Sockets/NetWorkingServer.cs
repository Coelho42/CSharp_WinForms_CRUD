using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static Cap09_Winforms_TrabalhoPratico.Sockets.Tools;

namespace Cap09_Winforms_TrabalhoPratico.Sockets
{
    class NetWorkingServer
    {
        #region Dados Locais

        /// <summary>
        /// Socket para receção de pedidos de ligação
        /// </summary>
        private static readonly Socket socketToListenClients = new Socket(
            AddressFamily.InterNetwork, // IPv4
            SocketType.Stream,          // Bit Streaming
            ProtocolType.Tcp);          // TCP

        /// <summary>
        /// PORTO fixo de receção de ligações de clientes
        /// </summary>
        private static int PORT = 8888;

        /// <summary>
        /// Array de bytes para receber e enviar os dados
        /// </summary>
        private static byte[] buffer;

        /// <summary>
        /// Atributo - Recebe a Form para que estes métodos possam 
        /// aceder aos seus gráficos
        /// </summary>
        private static FormWork formWork;

        /// <summary>
        /// Socket do cliente ligado
        /// </summary>
        internal static Socket socketToClient;

        #endregion

        #region Métodos Assíncronos CallBack

        /// <summary>
        /// StartServer() não é CallBack.
        /// Configura o Socket Principal socketToListenClients.
        /// Este Socket tem a função unica de ficar a "ouvir" 
        /// a rede nas interfaces da máquina, à espera que 
        /// cheguem pedidos de comunicação de Clientes, isto é,
        /// com o PORTO pré definido no atrituto local "porto". 
        /// Assim que confirma o porto, chama o método especial
        /// AcceptCallBack(), para receber a ligação e trata-la
        /// numa THREAD própria. São métodos assíncronos CallBack.
        /// Portanto, o método StartServer() é chamado pela
        /// ServerForm e trabalha ainda na thread principal.
        /// </summary>
        internal static void StartServer(FormWork form)
        {
            // registo da ServerForm no atributo local para que
            // os métodos CallBack possam manipular as ListViews
            // da form.
            formWork = form;

            // atualização da label de estado da ligação, na form.
            formWork.UpdateConnectionStateLabel("Listening", Color.Orange);

            try
            {
                // Configura o socketToListenClients para ouvir 
                // - em qualquer IP que esteja ativo na máquina
                // - no porto definido na constante
                socketToListenClients.Bind(new IPEndPoint(IPAddress.Any, PORT));

                // A Seguir define uma lista de atendimento com
                // um máximo de 10 ligações. A 11ª e seguintes
                // serão rejeitadas. Isto não significa que não
                // possa receber mais de 10, mas sim que trata
                // 10 de cada vez.
                socketToListenClients.Listen(1);

                // Só a deguir é que começa a receber as ligações 
                // em Threads assíncronas usando 2 passos 
                // (BeginAccept e EndAccept).
                // BeginAccept() é um AsyncCallback Method, isto é,
                // cria uma nova thread para executar o método
                // definido no 1º parâmetro: AcceptCallback() e
                // que vai concluir a receção da ligação com 
                // EndAccept(). Callback pq só chama o método 
                // quando uma dada condição for satisfeita: chegar
                // um pedido de ligação ao ip e porto definidos.
                // O 2º parâmetro é um Object, destinado a enviar 
                // dados para dentro do método do 1º parâmetro. 
                // Será null se não for usado:


                // IPORTANTE: Há muitos autores que insistem em 
                // incluir o objeto anónimo, new AsyncCallback(), 
                // como na linha comentada a seguir, mas é 
                // desnecessário. BeginAccept é um método CallBack
                // pelo que já inclui o obj AsyncCallback().
                // socketToListenClients.BeginAccept(new AsyncCallback(AcceptCallback), socketToListenClients);
                socketToListenClients.BeginAccept(AcceptCallback, socketToListenClients);

                // PORTANTO, BeginAccept inicia o Listening. Assim 
                // que chegar um pedido de ligação à máquina e ao 
                // porto definido, o método AcceptCallback() é 
                // executado numa nova thread para concluir a ligação
                // e libertar a thread principal.
            }
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação, na form.
                formWork.UpdateConnectionStateLabel("OFF", Color.DarkRed);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                // Mostra qq erro relacionado com o socket
                ShowDialog("NetWorkingServer - StartServer - SocketException:\n\n" + ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingServer - StartServer - ObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                // Trata todos os restantes erros
                ShowDialog("NetWorkingServer - StartServer - Exceção genérica:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// AcceptCallback()
        /// Conclui a aceitação da ligação numa nova thread
        /// O método podia chamar-se apenas Accept ou outro
        /// nome qq, mas tem a palavra CallBack para lembrar
        /// que só pode ser chamado por um obj AsyncCallback()
        /// que implementa a parte assíncrona, ou seja, cria
        /// e gere a thread onde este método vai correr.
        /// ------------------------------------------------
        /// Parâmetro tem que ser sempre (IAsyncResult AR).
        /// Trata-se de um objeto "Async result" que é Object
        /// e que contém dados úteis ao controlo da thread, 
        /// mas também ao programador, já que pode transportar 
        /// dados e objetos para dentro da thread, bastando
        /// para isso inclui-los no ultimo argumento do 
        /// método que chama este método.
        /// </summary>
        /// <param name="AR">Async Result é um Object que recebe dados da chamada anterior</param>
        private static void AcceptCallback(IAsyncResult AR)
        {
            // Socket local para gerir a ligação ao cliente em exclusivo
            // libertando o principal para continuar a receber ligações
            Socket localSocketToClient;

            try
            {
                // Ligação estabelecida com cliente. 
                // Socket local recebe a ligação do socket principal
                // Socket listener é libertado para poder receber + ligações
                socketToClient = localSocketToClient = socketToListenClients.EndAccept(AR);

                // atualização da imagem e label de estado da ligação, na form.
                formWork.UpdateConnectionStateLabel("ON", Color.Green);
                formWork.UpdateControlStates(true);

                /////////////////////////////////////////////////////////////////////////////
                // Receção dos dados do cliente 
                // Mais uma vez, a técnica AsyncCallBack - 2 passos: 
                // 1º BeginReceive() cria a thread para executar o método ReceiveCallback()
                // 2º ReceiveCallback() recebe o socket por parâmetro Async Result e 
                // conclui a receção da mensagem de forma assíncrona.

                // Redimensionamento do array de bytes com o tamanho dos dados recebidos
                buffer = new byte[localSocketToClient.ReceiveBufferSize];

                // Início da extração dos dados .BeginReceive()
                // Chamada, em callBack assíncrono do método 
                // ReceiveCallback() para concluir a receção 
                // dados numa nova thread.
                localSocketToClient.BeginReceive(
                    buffer,             // array de bytes 
                    0, buffer.Length,   // 1º e ultimo elemento do array a tratar
                    SocketFlags.None,   // Não há flags nesta configuração
                    ReceiveCallback,    // Método CallBack para executar o Passo 2
                    localSocketToClient);//Socket local, a passar ao ReceiveCallback 

                // Lembrar: o ultimo argumento destes métodos, Begin...(), serve para
                // passar dados ao método callBack. Neste caso: ReceiveCallback e 
                // estamosa passar o socket local, criado aqui.
                // No método ReceiveCallback, é o parâmetro AR que vai receber o socket.

                /////////////////////////////////////////////////////////////////////////////
                // Envio msg ao cliente a informar que os dados foram recebidos.
                // Mais uma vez, a técnica dos 2 passos: 
                // 1º BeginSend() cria a thread que executa o método SendCallback()
                // 2º SendCallback() recebe o socket por parâmetro Async Result e 
                // conclui o envio da mensagem de forma assíncrona

                // Conversão da msg para um byte array
                Byte[] sendDataBuffer = Encoding.UTF8.GetBytes("MSG__SV_OK");

                // Passo 1: BeginSend() cria a thread que executa o método SendCallback()
                localSocketToClient.BeginSend(
                    sendDataBuffer,             // array de bytes com o 
                    0, sendDataBuffer.Length,   // 1º e ultimo elemento do array a tratar
                    SocketFlags.None,           // Não há flags nesta configuração
                    SendCallback,               // Método CallBack para executar o Passo 2
                    localSocketToClient);       //Socket local a passar ao SendCallback() 

                // Esta thread termina aqui
                // Inicia outra thread para receber outra ligação
                socketToListenClients.BeginAccept(AcceptCallback, null);

                // Esta thread secundária termina aqui.
            }
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação, na form.
                formWork.UpdateConnectionStateLabel("OFF", Color.DarkRed);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                // Trata qq erro relacionado com a criação do socket
                ShowDialog("NetWorkingServer - AcceptCallback SocketException:\n\n" + ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingServer - AcceptCallback ObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                // Trata todos os restantes erros
                ShowDialog("NetWorkingServer - AcceptCallback Exceção genérica:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// ReceiveCallback()
        /// Conclui a receção dos dados, iniciada em 
        /// AcceptCallback() com socket.BeginReceive(). 
        /// 1º extrai o socket do objeto AR
        /// 2º extrai o array de bytes do socket
        /// 3º converte os dados para o objeto final
        /// 4º Inicia nova receção de dados numa nova thread
        /// </summary>
        /// <param name="AR">Async Result é um Object que recebe dados da chamada anterior</param>
        private static void ReceiveCallback(IAsyncResult AR)
        {
            // Socket local
            Socket localSocketToClient = null;

            try
            {
                // Socket local recebe cópia do socket enviádo em AR
                localSocketToClient = (Socket)AR.AsyncState;

                // Extração do tamanho da msg em bytes
                int messageLengthReceived = localSocketToClient.EndReceive(AR);

                // Caso o cliente desligue, a Socket exception vai ser 
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
                        // O array de bytes contém os dados de uma pessoa 
                        // => contrutor com desSerialização
                        Equipa equipa = new Equipa(buffer);

                        // Adicão da pessoa à DataGrid
                        // A FormServer foi passada para um atributo local, 
                        // desta class para a thread possa aceder de forma
                        // segura ao método da thread principal que insere
                        // dados na DataGridView.
                        formWork.SubmitEquipaToDataGrid(equipa);
                        break;
                }

                // Esta thread termina aqui
                // Inicia outra thread para receber dados
                localSocketToClient.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, localSocketToClient);
            }
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação e da imagem, na form.
                formWork.UpdateConnectionStateLabel("Listening", Color.Orange);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                // Erros do socket
                ShowDialog("NetWorkingServer - ReceiveCallback Socket Exception:\n\n" + ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingServer - ReceiveCallback ObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                // Trata todos os restantes erros
                ShowDialog("NetWorkingServer - ReceiveCallback Exceção genérica:\n\n" + ex.Message);
            }
        }

        /// <summary>
        /// Tratamento do envio de msgs
        /// Executa numa nova thread
        /// </summary>
        /// <param name="AR">Async Result é um Object que recebe dados da chamada anterior</param>
        internal static void SendCallback(IAsyncResult AR)
        {
            // Socket local
            Socket localSocketToClient = null;

            try
            {
                // Socket local recebe cópia do socket local de AcceptCallback()
                localSocketToClient = (Socket)AR.AsyncState;

                // Conclui o envio dos dados para o socket cliente
                localSocketToClient.EndSend(AR);

                // Esta Thread termina aqui
            }
            catch (SocketException ex)
            {
                // atualização da label de estado da ligação e da imagem, na form.
                formWork.UpdateConnectionStateLabel("Listening", Color.Orange);

                // Atualização dos objetos gráficos
                formWork.UpdateControlStates(false);

                // Erros do socket
                ShowDialog("NetWorkingServer - SendCallback Socket Exception:\n\n" + ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowDialog("NetWorkingServer - SendCallback ObjectDisposedException:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                // Trata todos os restantes erros
                ShowDialog("NetWorkingServer - SendCallback Exceção genérica:\n\n" + ex.Message);
            }
        }

        #endregion
    }
}

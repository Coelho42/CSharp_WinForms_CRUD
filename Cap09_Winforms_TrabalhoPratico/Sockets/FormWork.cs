using System;
using System.Drawing;
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
            buttonEquipas.Enabled = false;
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
        }

        #endregion

        #region Métodos Invoke

        /// <summary>
        /// Adiciona uma pessoa à dataGridView
        /// Invoke permite acesso seguro de uma  thread 
        /// secundária à dataGrid que está na thread principal
        /// </summary>
        internal void SubmitEquipaToDataGrid(Equipa equipa)
        {
            Invoke((Action)delegate
            {
                dataGridViewEquipas.Rows.Add(equipa.nome, equipa.convocada, equipa.liga);
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
                buttonEquipas.Enabled = true;
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
        #endregion

        #region Abre Interfaces

        private void buttonEquipas_Click(object sender, EventArgs e)
        {
            FormEntidadeEquipasDetalhes formEquipas = new FormEntidadeEquipasDetalhes("Sockets", -1);
            formEquipas.ShowDialog();
        }
        #endregion
    }
}
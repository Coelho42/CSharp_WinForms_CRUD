using System;
using System.Windows.Forms;

namespace Cap09_Winforms_TrabalhoPratico.Sockets
{
    class Tools
    {
        /// <summary>
        /// Determina se a app é Server ou Client
        /// </summary>
        public static bool IsServer { get; set; } = true;

        /// <summary>
        /// Método auxiliar para emitir mensagens
        /// </summary>
        /// <param name="message"></param>
        public static void ShowDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

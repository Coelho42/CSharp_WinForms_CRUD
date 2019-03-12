using System;
using System.Data.Common;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   // MySQL

namespace Cap09_Winforms_TrabalhoPratico
{
    static class SQL_Connection
    {
        #region Dados locais

        // Connector para ligar à base de dados
        static internal MySqlConnection conn_mysql = null;
        static internal string clipboardText;

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        /// ConnectionString - Contêm o endereço e as credenciais de ligação, a associar ao connector
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        // Local
        static private readonly String sqlConnStringMySqlPC = @"server=localhost; database=torneiotartaruga; user id=root; password=tgpsi; SslMode=none";
        #endregion

        #region SQL Connections

        /// <summary>
        /// Cria e devolve uma connection aberta para o DBMS ativo
        /// </summary>
        /// <returns>Ligação preparada e aberta</returns>
        static internal DbConnection OpenConnection()
        {          
            // Termina as Ligações antigas primeiro. False para não colocar DBMSactive a null
            CloseAllConnections(false);

            // Criação de um objeto de ligação comum a todos os connectors a devolver a quem pedir uma ligação
            DbConnection connection = null;

            try
            {
                //inicializa a Ligação
                conn_mysql = new MySqlConnection(sqlConnStringMySqlPC);

                //tenta abrir a Ligação
                conn_mysql.Open();

                // Se abertura com sucesso, entrega a ligação ao objeto genérico. Caso contrário gera exceção
                connection = conn_mysql;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro com o DBMS");
            }
            return connection;         
        }

        /// <summary>
        /// Fecha todas as Ligações com os DBMS
        /// </summary>
        /// <param name="dbmsNull">True: passa o DBMSactive para null</param>
        static internal void CloseAllConnections(bool dbmsActiveNull)
        {           
            //fecha ligação mysql
            if (conn_mysql != null)
            {
                conn_mysql.Close();
                conn_mysql = null;
            }          
        }

        #endregion

        #region Utilitários

        /// <summary>
        /// Permite enviar parametros vazios se determinado valor acontecer
        /// Neste caso se o valor for null ou -1 é enviado um null para a bd
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        internal static object ValueOrDBNullIfZero(Int32? val)
        {
            if (val == null) return DBNull.Value;
            if (val == -1) return DBNull.Value;
            return val;
        }

        /// <summary>
        /// Permite enviar parametros vazios se determinado valor acontecer
        /// Neste caso se o valor for null é enviado um objeto null para a bd
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        internal static object ValueOrDBNullIfZero(Object val)
        {
            if (val == null) return DBNull.Value;
            return val;
        }

        #endregion
    }
}

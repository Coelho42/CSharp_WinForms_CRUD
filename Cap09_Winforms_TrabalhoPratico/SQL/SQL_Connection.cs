using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   // MySQL
using static Cap09_Winforms_TrabalhoPratico.Settings;

namespace Cap09_Winforms_TrabalhoPratico
{
    static class SQL_Connection
    {
        #region Dados locais

        // Regista o DBMS ativo, para execução de SQL DML
        static internal int DBMSactive { get; set; } = DBMS_NULL;
        static internal string clipboardText = null;

        // Connectors para ligar à base de dados
        static internal SqlConnection conn_sqlserver = null;
        static internal MySqlConnection conn_mysql = null;
        static internal SQLiteConnection conn_sqlite = null;

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        /// ConnectionString - Contêm o endereço e as credenciais de ligação, a associar ao connector
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        // LocalDB -Instância local SQL Server express do Visual Studio.
        static private readonly String sqlConnStringBdLocal = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LocalDBs\LocalBD.mdf;Integrated Security=True;MultipleActiveResultSets=true";

        // SQLServer 2017 DBMS num dado IP.
        static private readonly String sqlConnStringSQLserver = @"Data Source=DESKTOP-AJ6VJSD;Initial Catalog=TorneioTartaruga;Persist Security Info=True;User ID=root;Password=tgpsi";

        // MySQL
        static private readonly String sqlConnStringMySql = @"server=localhost; database=torneiotartaruga; user id=root; password=tgpsi; SslMode=none";

        // SQL lite: para manter a BD transportável em git, Não há um DBMS, mas sim uma file. Logo o caminho é absoluto:
        // Para o tornar adaptável a qualquer PC, com git ou outro qq meio, usar esta concatenação:
        static private readonly String sqlConnStringSQLite = "data source=" + System.IO.Path.GetFullPath(@"..\..\LocalDBs\TorneioTartaruga.db");
        #endregion

        #region SQL Connections

        /// <summary>
        /// Cria e devolve uma connection aberta para o DBMS ativo
        /// </summary>
        /// <returns>Ligação preparada e aberta</returns>
        static internal DbConnection OpenConnection(int dbmsToActivate)
        {
            DBMSactive = dbmsToActivate;    // Ativa um DBMS
            return OpenConnection();        // Cria a ligação no método "verdadeiro" e devolve-a a quem pedir
        }

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
                // Efetua a ligação para o DBMS ativo
                switch (DBMSactive)
                {
                    case DBMS_SQLSERVER_BD_LOCAL:
                        // Prepara a Ligação SQLServer com a connectionString
                        conn_sqlserver = new SqlConnection(sqlConnStringBdLocal);

                        // tenta abrir a Ligação
                        conn_sqlserver.Open();

                        // Se abertura com sucesso, entrega a ligação ao objeto genérico. Caso contrário gera exceção
                        connection = conn_sqlserver;
                        DBMSactive = DBMS_SQLSERVER_BD_LOCAL;
                        break;

                    case DBMS_SQLSERVER:
                        //inicializa a Ligação
                        conn_sqlserver = new SqlConnection(sqlConnStringSQLserver);

                        //tenta abrir a Ligação
                        conn_sqlserver.Open();

                        // Se abertura com sucesso, entrega a ligação ao objeto genérico. Caso contrário gera exceção
                        connection = conn_sqlserver;
                        DBMSactive = DBMS_SQLSERVER;
                        break;

                    case DBMS_MYSQL:
                        //inicializa a Ligação
                        conn_mysql = new MySqlConnection(sqlConnStringMySql);

                        //tenta abrir a Ligação
                        conn_mysql.Open();

                        // Se abertura com sucesso, entrega a ligação ao objeto genérico. Caso contrário gera exceção
                        connection = conn_mysql;
                        DBMSactive = DBMS_MYSQL;
                        break;

                    case DBMS_SQLITE:
                        //inicializa a Ligação
                        conn_sqlite = new SQLiteConnection(sqlConnStringSQLite);

                        //tenta abrir a Ligação
                        conn_sqlite.Open();

                        // Se abertura com sucesso, entrega a ligação ao objeto genérico. Caso contrário gera exceção
                        connection = conn_sqlite;
                        DBMSactive = DBMS_SQLITE;
                        break;

                    case DBMS_NULL:
                        MessageBox.Show(
                            "Atenção ao programador, DBMS is NULL",
                            "SQL_Connection - OpenConnectio() - case DBMS_NULL",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );
                        break;

                    default:
                        MessageBox.Show(
                            "Atenção ao programador, DBMS desconhecido:\n" + DBMSactive,
                            "SQL_Connection - OpenConnectio() - Default",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation
                        );
                        break;
                }
            }
            catch (Exception ex)
            {
                // Mostra a mensegem de erro numa MsgBox e associa o botão ok ao Clipboard. 
                // Desta forma o utilizador poderá colar o erro na google e pesquisar soluções

                string msgtext = "Não foi possível ligar à base de dados, com o seguinte erro:\n\n\""
                    + ex.Message
                    + "\"\n\nContacte o Administrador do sistema informático"
                    + "\nO botão OK irá copiar a mensagem de erro. Google it!";

                if (MessageBox.Show(msgtext, "DBMS NÃO DISPONÍVEL", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == System.Windows.Forms.DialogResult.OK)
                {
                    // Como não se deve pode usar o ClipBord de forma direta a partir de uma thread, 
                    // copiamos a msg de erro para um atributo desta classe static e acedemos-lhe a partir da 
                    // thread principal após o encerramento da Thread 2
                    clipboardText = ex.Message;
                };

                return connection;
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

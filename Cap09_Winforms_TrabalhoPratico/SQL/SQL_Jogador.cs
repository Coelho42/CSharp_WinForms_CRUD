using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static Cap09_Winforms_TrabalhoPratico.SQL_Connection;
using static Cap09_Winforms_TrabalhoPratico.Settings;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Cap09_Winforms_TrabalhoPratico
{
    /// <summary>
    /// CRUD da entidade Jogador
    /// </summary>
    static internal class SQL_Jogador
    {
        #region Create

        /// <summary>
        /// Adiciona um novo registo à tabela
        /// </summary>
        /// <param name="user"></param>
        static internal void Add(Jogador jogador)
        {
            //Execução do SQL DML sob controlo do try catch
            try
            {
                // Abre ligação ao DBMS Ativo
                using (DbConnection conn = OpenConnection())
                {
                    // Prepara e executa o SQL DML
                    switch (DBMSactive)
                    {
                        case DBMS_SQLSERVER_BD_LOCAL:
                        case DBMS_SQLSERVER:
                            // Prepara e executa o SQL DML
                            using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "INSERT INTO Jogador"
                                + "(Nome, Idade, Altura, Posicao, EquipaID)"
                                + "VALUES(@nome,@idade,@altura,@posicao,@equipaid);";
                                sqlCommand.Parameters.Add(new SqlParameter("@nome", jogador.nome));
                                sqlCommand.Parameters.Add(new SqlParameter("@idade", jogador.idade));
                                sqlCommand.Parameters.Add(new SqlParameter("@altura", jogador.altura));
                                sqlCommand.Parameters.Add(new SqlParameter("@posicao", jogador.posicao));
                                sqlCommand.Parameters.Add(new SqlParameter("@equipaid", jogador.equipa.id));

                                // Tenta Executar e Se diferente de 1, provoca excessão saltanto para o catch
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;
                        case DBMS_MYSQL:
                            // Prepara e executa o SQL DML
                            using (MySqlCommand sqlCommand = ((MySqlConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "INSERT INTO Jogador"
                                + "(Nome, Idade, Altura, Posicao, EquipaID)"
                                + "VALUES(@nome,@idade,@altura,@posicao,@equipaid);";
                                sqlCommand.Parameters.Add(new MySqlParameter("@nome", jogador.nome));
                                sqlCommand.Parameters.Add(new MySqlParameter("@idade", jogador.idade));
                                sqlCommand.Parameters.Add(new MySqlParameter("@altura", jogador.altura));
                                sqlCommand.Parameters.Add(new MySqlParameter("@posicao", jogador.posicao));
                                sqlCommand.Parameters.Add(new MySqlParameter("@equipaid", jogador.equipa.id));

                                // Tenta Executar e Se diferente de 1, provoca excessão saltanto para o catch
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;
                        case DBMS_SQLITE:
                            // Prepara e executa o SQL DML
                            using (SQLiteCommand sqlCommand = ((SQLiteConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "INSERT INTO Jogador"
                                + "(Nome, Idade, Altura, Posicao, EquipaID)"
                                + "VALUES(@nome,@idade,@altura,@posicao,@equipaid);";
                                sqlCommand.Parameters.Add(new SQLiteParameter("@nome", jogador.nome));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@idade", jogador.idade));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@altura", jogador.altura));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@posicao", jogador.posicao));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@equipaid", jogador.equipa.id));

                                // Tenta Executar e Se diferente de 1, provoca excessão saltanto para o catch
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        #endregion

        #region Read

        /// <summary>
        /// Recolhe todos os registos da tabela, converte para obj e adiciona numa lista a devolver
        /// Há várias ligações - Processo:
        /// 1 - Ligação BD - Extrai os registos BD para a lista principal
        /// 2 - Completa os objeto da lista principal, preenchendo os obj FK, com base nas listas FK
        ///     Usa um ciclo para correr a lista principal e um ciclo ou obj FK
        /// </summary>
        /// <returns>Lista de objetos</returns>
        static internal List<Jogador> GetAll()
        {
            List<Jogador> listaJogadores = new List<Jogador>();   // Lista Principal
            String query = "";

            //Execução do SQL DML sob controlo do try catch
            try
            {
                // Abre ligação ao DBMS Ativo
                using (DbConnection conn = OpenConnection())
                {
                    // Prepara e executa o SQL DML
                    switch (DBMSactive)
                    {
                        case DBMS_SQLSERVER_BD_LOCAL:
                        case DBMS_SQLSERVER:

                            query = "SELECT * FROM Jogador;";
                            // Prepara e executa o SQL DML
                            using (SqlCommand sqlCommand = new SqlCommand())
                            {
                                // Config da ligação
                                sqlCommand.CommandText = query;
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Connection = ((SqlConnection)conn);

                                // Reader recebe os dados da execução da query
                                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                                {
                                    // Extração dos dados do reader para a lista, um a um: registo tabela -> new Obj -> Lista<Objs>
                                    while (reader.Read())
                                    {
                                        // Construção do objeto (com construtor mínimo)
                                        // Se objeto tem FKs, Não usar SQL***.get() para construir o objeto fk dentro do construtor. gera exceção.
                                        // Criar o obj FK com o Construtor de Id e depois completar o objeto a seguir à connection.close.
                                        Jogador jogador = new Jogador(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetInt32(reader.GetOrdinal("Idade")),
                                            reader.GetFloat(reader.GetOrdinal("Altura")),
                                            reader["Posicao"].ToString(),
                                            new Equipa(reader.GetInt32(reader.GetOrdinal("EquipaID")))
                                        );

                                        //adiciona o obj à lista
                                        listaJogadores.Add(jogador);
                                    }
                                }
                            }
                            break;
                        case DBMS_MYSQL:
                            query = "SELECT * FROM Jogador;";
                            // Prepara e executa o SQL DML
                            using (MySqlCommand sqlCommand = new MySqlCommand())
                            {
                                // Config da ligação
                                sqlCommand.CommandText = query;
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Connection = ((MySqlConnection)conn);

                                // Reader recebe os dados da execução da query
                                using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                                {
                                    // Extração dos dados do reader para a lista, um a um: registo tabela -> new Obj -> Lista<Objs>
                                    while (reader.Read())
                                    {
                                        // Construção do objeto (com construtor mínimo)
                                        // Se objeto tem FKs, Não usar SQL***.get() para construir o objeto fk dentro do construtor. gera exceção.
                                        // Criar o obj FK com o Construtor de Id e depois completar o objeto a seguir à connection.close.
                                        Jogador jogador = new Jogador(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetInt32(reader.GetOrdinal("Idade")),
                                            reader.GetFloat(reader.GetOrdinal("Altura")),
                                            reader["Posicao"].ToString(),
                                            new Equipa(reader.GetInt32(reader.GetOrdinal("EquipaID")))
                                        );

                                        //adiciona o obj à lista
                                        listaJogadores.Add(jogador);
                                    }
                                }
                            }
                            break;
                        case DBMS_SQLITE:
                            query = "SELECT * FROM Jogador;";

                            // Prepara e executa o SQL DML
                            using (SQLiteCommand sqlCommand = new SQLiteCommand())
                            {
                                // Config da ligação
                                sqlCommand.CommandText = query;
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Connection = ((SQLiteConnection)conn);

                                // Reader recebe os dados da execução da query
                                using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                                {
                                    // Extração dos dados do reader para a lista, um a um: registo tabela -> new Obj -> Lista<Objs>
                                    while (reader.Read())
                                    {
                                        // Construção do objeto (com construtor mínimo)
                                        // Se objeto tem FKs, Não usar SQL***.get() para construir o objeto fk dentro do construtor. gera exceção.
                                        // Criar o obj FK com o Construtor de Id e depois completar o objeto a seguir à connection.close.
                                        Jogador jogador = new Jogador(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetInt32(reader.GetOrdinal("Idade")),
                                            reader.GetFloat(reader.GetOrdinal("Altura")),
                                            reader["Posicao"].ToString(),
                                            new Equipa(reader.GetInt32(reader.GetOrdinal("EquipaID")))
                                        );

                                        //adiciona o obj à lista
                                        listaJogadores.Add(jogador);
                                    }
                                }
                            }
                            break;
                    }                 
                }
                // Se Entidade tem FKs, Executar um foreach à lista de objetos extraídos e completar com o objeto fk, usando um get(id) à SQL respetiva
                foreach (Jogador jogador in listaJogadores)
                {
                    jogador.equipa = SQL_Equipa.Get(jogador.equipa.id);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            return listaJogadores;
        }

        /// <summary>
        /// Obtem um registo completo da tabela através do seu id, converte para obj e devolve.
        /// Há várias ligações - Processo:
        /// 1 - Ligação BD - Extrai o registo BD.
        /// 2 - Completa os objeto da lista principal, preenchendo os obj FK, com base nas listas FK
        ///     Usa um ciclo para correr a lista principal e um ciclo ou obj FK
        /// </summary>
        /// <returns>Devolve um objeto preenchido ou NULL</returns>
        static internal Jogador Get(long id)
        {
            Jogador jogador = null;

            //Execução do SQL DML sob controlo do try catch
            try
            {
                // Abre ligação ao DBMS Ativo
                using (DbConnection conn = OpenConnection())
                {
                    // Prepara e executa o SQL DML
                    switch (DBMSactive)
                    {
                        case DBMS_SQLSERVER_BD_LOCAL:
                        case DBMS_SQLSERVER:
                            // Prepara e executa o SQL DML
                            using (SqlCommand sqlCommand = new SqlCommand())
                            {
                                // Config da ligação
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Connection = ((SqlConnection)conn);

                                // SQL DDL
                                sqlCommand.CommandText = "SELECT * FROM Jogador where Id=@Id;";
                                sqlCommand.Parameters.Add(new MySqlParameter("@Id", id));

                                // Reader recebe os dados da execução da query
                                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                                {
                                    // Extração dos dados do reader para a lista, um a um: registo tabela -> new Obj -> Lista<Objs>
                                    if (reader.Read())
                                    {
                                        // Construção do objeto (com construtor mínimo)
                                        // Se objeto tem FKs, Não usar SQL***.get() para construir o objeto fk dentro do construtor. gera exceção.
                                        // Criar o obj FK com o Construtor de Id e depois completar o objeto a seguir à connection.close.
                                        jogador = new Jogador(
                                            reader.GetInt64(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetInt32(reader.GetOrdinal("Idade")),
                                            reader.GetFloat(reader.GetOrdinal("Altura")),
                                            reader["Posicao"].ToString(),
                                            new Equipa(reader.GetInt32(reader.GetOrdinal("EquipaID")))
                                        );
                                    }
                                }
                            }
                            break;
                        case DBMS_MYSQL:
                            // Prepara e executa o SQL DML
                            using (MySqlCommand sqlCommand = new MySqlCommand())
                            {
                                // Config da ligação
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Connection = ((MySqlConnection)conn);

                                // SQL DDL
                                sqlCommand.CommandText = "SELECT * FROM Jogador where Id=@Id;";
                                sqlCommand.Parameters.Add(new MySqlParameter("@Id", id));

                                // Reader recebe os dados da execução da query
                                using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                                {
                                    // Extração dos dados do reader para a lista, um a um: registo tabela -> new Obj -> Lista<Objs>
                                    if (reader.Read())
                                    {
                                        // Construção do objeto (com construtor mínimo)
                                        // Se objeto tem FKs, Não usar SQL***.get() para construir o objeto fk dentro do construtor. gera exceção.
                                        // Criar o obj FK com o Construtor de Id e depois completar o objeto a seguir à connection.close.
                                        jogador = new Jogador(
                                            reader.GetInt64(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetInt32(reader.GetOrdinal("Idade")),
                                            reader.GetFloat(reader.GetOrdinal("Altura")),
                                            reader["Posicao"].ToString(),
                                            new Equipa(reader.GetInt32(reader.GetOrdinal("EquipaID")))
                                        );
                                    }
                                }
                            }
                            break;
                        case DBMS_SQLITE:
                            // Prepara e executa o SQL DML
                            using (SQLiteCommand sqlCommand = new SQLiteCommand())
                            {
                                // Config da ligação
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Connection = ((SQLiteConnection)conn);

                                // SQL DDL
                                sqlCommand.CommandText = "SELECT * FROM Jogador where Id=@Id;";
                                sqlCommand.Parameters.Add(new SQLiteParameter("@Id", id));

                                // Reader recebe os dados da execução da query
                                using (SQLiteDataReader reader = sqlCommand.ExecuteReader())
                                {
                                    // Extração dos dados do reader para a lista, um a um: registo tabela -> new Obj -> Lista<Objs>
                                    if (reader.Read())
                                    {
                                        // Construção do objeto (com construtor mínimo)
                                        // Se objeto tem FKs, Não usar SQL***.get() para construir o objeto fk dentro do construtor. gera exceção.
                                        // Criar o obj FK com o Construtor de Id e depois completar o objeto a seguir à connection.close.
                                        jogador = new Jogador(
                                            reader.GetInt64(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetInt32(reader.GetOrdinal("Idade")),
                                            reader.GetFloat(reader.GetOrdinal("Altura")),
                                            reader["Posicao"].ToString(),
                                            new Equipa(reader.GetInt32(reader.GetOrdinal("EquipaID")))
                                        );
                                    }
                                }
                            }
                            break;
                    }                   
                }
                jogador.equipa = SQL_Equipa.Get(jogador.equipa.id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro...");
                return null;
            }
            return jogador;
        }        
        #endregion

        #region Update

        /// <summary>
        /// Altera um registo da tabela
        /// </summary>
        /// <param name="jogador">Objeto com id a alterar da tabela</param>
        static internal void Set(Jogador jogador)
        {
            //Execução do SQL DML sob controlo do try catch
            try
            {
                // Abre ligação ao DBMS Ativo
                using (DbConnection conn = OpenConnection())
                {
                    // Prepara e executa o SQL DML
                    switch (DBMSactive)
                    {
                        case DBMS_SQLSERVER_BD_LOCAL:
                        case DBMS_SQLSERVER:
                            // Prepara e executa o SQL DML
                            using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "UPDATE Jogador SET "
                                + " Nome = @nome,"
                                + " Idade = @idade,"
                                + " Altura = @altura,"
                                + " Posicao = @posicao,"
                                + " EquipaID = @equipaid"
                                + " WHERE Id = @Id;";
                                sqlCommand.Parameters.Add(new SqlParameter("@Id", jogador.id));
                                sqlCommand.Parameters.Add(new SqlParameter("@nome", jogador.nome));
                                sqlCommand.Parameters.Add(new SqlParameter("@idade", jogador.idade));
                                sqlCommand.Parameters.Add(new SqlParameter("@altura", jogador.altura));
                                sqlCommand.Parameters.Add(new SqlParameter("@posicao", jogador.posicao));
                                sqlCommand.Parameters.Add(new SqlParameter("@equipaid", jogador.equipa.id));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;
                        case DBMS_MYSQL:
                            // Prepara e executa o SQL DML
                            using (MySqlCommand sqlCommand = ((MySqlConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "UPDATE Jogador SET "
                                + " Nome = @nome,"
                                + " Idade = @idade,"
                                + " Altura = @altura,"
                                + " Posicao = @posicao,"
                                + " EquipaID = @equipaid"
                                + " WHERE Id = @Id;";
                                sqlCommand.Parameters.Add(new MySqlParameter("@Id", jogador.id));
                                sqlCommand.Parameters.Add(new MySqlParameter("@nome", jogador.nome));
                                sqlCommand.Parameters.Add(new MySqlParameter("@idade", jogador.idade));
                                sqlCommand.Parameters.Add(new MySqlParameter("@altura", jogador.altura));
                                sqlCommand.Parameters.Add(new MySqlParameter("@posicao", jogador.posicao));
                                sqlCommand.Parameters.Add(new MySqlParameter("@equipaid", jogador.equipa.id));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;
                        case DBMS_SQLITE:
                            // Prepara e executa o SQL DML
                            using (SQLiteCommand sqlCommand = ((SQLiteConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "UPDATE Jogador SET "
                                + " Nome = @nome,"
                                + " Idade = @idade,"
                                + " Altura = @altura,"
                                + " Posicao = @posicao,"
                                + " EquipaID = @equipaid"
                                + " WHERE Id = @Id;";
                                sqlCommand.Parameters.Add(new SQLiteParameter("@Id", jogador.id));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@nome", jogador.nome));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@idade", jogador.idade));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@altura", jogador.altura));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@posicao", jogador.posicao));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@equipaid", jogador.equipa.id));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        #endregion

        #region Delete

        /// <summary>
        /// Delete de um registo da tabela. 
        /// ATENÇÃO: Porque estes objetos são FK noutras tabelas, o delete aplica-se após 
        /// o método checkRelationalIntegrityViolation(), caso contrário pode gerar Exceções
        /// </summary>
        /// <param name="jogador">Objeto com id a apagar da tabela</param>
        static internal void Del(Jogador jogador)
        {
            //Execução do SQL DML sob controlo do try catch
            try
            {
                // Abre ligação ao DBMS Ativo
                using (DbConnection conn = OpenConnection())
                {
                    switch (DBMSactive)
                    {
                        case DBMS_SQLSERVER_BD_LOCAL:
                        case DBMS_SQLSERVER:
                            using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                            {
                                // Prepara e executa o SQL DML
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "DELETE FROM Jogador WHERE Id=@id;";
                                sqlCommand.Parameters.Add(new SqlParameter("@id", jogador.id));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    throw new InvalidProgramException("Erro - del() - sqlserver: ");
                                }
                            }
                            break;
                        case DBMS_MYSQL:
                            using (MySqlCommand sqlCommand = ((MySqlConnection)conn).CreateCommand())
                            {
                                // Prepara e executa o SQL DML
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "DELETE FROM Jogador WHERE Id=@id;";
                                sqlCommand.Parameters.Add(new MySqlParameter("@id", jogador.id));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    throw new InvalidProgramException("Erro - del() - sqlserver: ");
                                }
                            }
                            break;
                        case DBMS_SQLITE:
                            using (SQLiteCommand sqlCommand = ((SQLiteConnection)conn).CreateCommand())
                            {
                                // Prepara e executa o SQL DML
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "DELETE FROM Jogador WHERE Id=@id;";
                                sqlCommand.Parameters.Add(new SQLiteParameter("@id", jogador.id));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    throw new InvalidProgramException("Erro - del() - sqlserver: ");
                                }
                            }
                            break;
                    }                             
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro...");
            }
        }
        #endregion
    }
}

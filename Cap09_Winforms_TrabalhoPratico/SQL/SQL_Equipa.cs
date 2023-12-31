﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using static Cap09_Winforms_TrabalhoPratico.SQL_Connection;
using static Cap09_Winforms_TrabalhoPratico.Settings;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Cap09_Winforms_TrabalhoPratico
{
    /// <summary>
    /// CRUD da entidade Equipa
    /// </summary>
    static internal class SQL_Equipa
    {
        #region Create

        /// <summary>
        /// Adiciona um novo registo à tabela
        /// </summary>
        /// <param name="user"></param>
        static internal void Add(Equipa equipa)
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
                                sqlCommand.CommandText = "INSERT INTO Equipa"
                                + "(Nome, Convocada, Liga)"
                                + "VALUES(@nome,@convocada,@liga);";
                                sqlCommand.Parameters.Add(new SqlParameter("@nome", equipa.nome));
                                sqlCommand.Parameters.Add(new SqlParameter("@convocada", equipa.convocada));
                                sqlCommand.Parameters.Add(new SqlParameter("@liga", equipa.liga));

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
                                sqlCommand.CommandText = "INSERT INTO Equipa"
                                + "(Nome, Convocada, Liga)"
                                + "VALUES(@nome,@convocada,@liga);";
                                sqlCommand.Parameters.Add(new MySqlParameter("@nome", equipa.nome));
                                sqlCommand.Parameters.Add(new MySqlParameter("@convocada", equipa.convocada));
                                sqlCommand.Parameters.Add(new MySqlParameter("@liga", equipa.liga));

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
                                sqlCommand.CommandText = "INSERT INTO Equipa"
                                + "(Nome, Convocada, Liga)"
                                + "VALUES(@nome,@convocada,@liga);";
                                sqlCommand.Parameters.Add(new SQLiteParameter("@nome", equipa.nome));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@convocada", equipa.convocada));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@liga", equipa.liga));

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
        static internal List<Equipa> GetAll()
        {
            List<Equipa> listaEquipas = new List<Equipa>();   // Lista Principal
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
                            query = "SELECT * FROM Equipa;";

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
                                        Equipa equipa = new Equipa(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetBoolean(reader.GetOrdinal("Convocada")),
                                            reader["Liga"].ToString()
                                        );

                                        //adiciona o obj à lista
                                        listaEquipas.Add(equipa);
                                    }
                                }
                            }
                            break;
                        case DBMS_MYSQL:
                            query = "SELECT * FROM Equipa;";

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
                                        Equipa equipa = new Equipa(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetBoolean(reader.GetOrdinal("Convocada")),
                                            reader["Liga"].ToString()
                                        );

                                        //adiciona o obj à lista
                                        listaEquipas.Add(equipa);
                                    }
                                }
                            }
                            break;
                        case DBMS_SQLITE:
                            query = "SELECT * FROM Equipa;";

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
                                        Equipa equipa = new Equipa(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetBoolean(reader.GetOrdinal("Convocada")),
                                            reader["Liga"].ToString()
                                        );

                                        //adiciona o obj à lista
                                        listaEquipas.Add(equipa);
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null;
            }
            return listaEquipas;
        }

        /// <summary>
        /// Obtem um registo completo da tabela através do seu id, converte para obj e devolve.
        /// Há várias ligações - Processo:
        /// 1 - Ligação BD - Extrai o registo BD.
        /// 2 - Completa os objeto da lista principal, preenchendo os obj FK, com base nas listas FK
        ///     Usa um ciclo para correr a lista principal e um ciclo ou obj FK
        /// </summary>
        /// <returns>Devolve um objeto preenchido ou NULL</returns>
        static internal Equipa Get(long id)
        {
            Equipa equipa = null;

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
                                sqlCommand.CommandText = "SELECT * FROM Equipa where Id=@Id;";
                                sqlCommand.Parameters.Add(new SqlParameter("@Id", id));

                                // Reader recebe os dados da execução da query
                                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                                {
                                    // Extração dos dados do reader para a lista, um a um: registo tabela -> new Obj -> Lista<Objs>
                                    if (reader.Read())
                                    {
                                        // Construção do objeto (com construtor mínimo)
                                        // Se objeto tem FKs, Não usar SQL***.get() para construir o objeto fk dentro do construtor. gera exceção.
                                        // Criar o obj FK com o Construtor de Id e depois completar o objeto a seguir à connection.close.
                                        equipa = new Equipa(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetBoolean(reader.GetOrdinal("Convocada")),
                                            reader["Liga"].ToString()
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
                                sqlCommand.CommandText = "SELECT * FROM Equipa where Id=@Id;";
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
                                        equipa = new Equipa(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetBoolean(reader.GetOrdinal("Convocada")),
                                            reader["Liga"].ToString()
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
                                sqlCommand.CommandText = "SELECT * FROM Equipa where Id=@Id;";
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
                                        equipa = new Equipa(
                                            reader.GetInt32(reader.GetOrdinal("ID")),
                                            reader["Nome"].ToString(),
                                            reader.GetBoolean(reader.GetOrdinal("Convocada")),
                                            reader["Liga"].ToString()
                                        );
                                    }
                                }
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro...");
                return null;
            }
            return equipa;
        }        
        #endregion

        #region Update

        /// <summary>
        /// Altera um registo da tabela
        /// </summary>
        /// <param name="equipa">Objeto com id a alterar da tabela</param>
        static internal void Set(Equipa equipa)
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
                            using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "UPDATE Equipa SET "
                                + " Nome = @nome,"
                                + " Convocada = @convocada,"
                                + " Liga = @liga"
                                + " WHERE Id = @Id;";
                                sqlCommand.Parameters.Add(new SqlParameter("@Id", equipa.id));
                                sqlCommand.Parameters.Add(new SqlParameter("@nome", equipa.nome));
                                sqlCommand.Parameters.Add(new SqlParameter("@convocada", equipa.convocada));
                                sqlCommand.Parameters.Add(new SqlParameter("@liga", equipa.liga));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;
                        case DBMS_MYSQL:
                            using (MySqlCommand sqlCommand = ((MySqlConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "UPDATE Equipa SET "
                                + " Nome = @nome,"
                                + " Convocada = @convocada,"
                                + " Liga = @liga"
                                + " WHERE Id = @Id;";
                                sqlCommand.Parameters.Add(new MySqlParameter("@Id", equipa.id));
                                sqlCommand.Parameters.Add(new MySqlParameter("@nome", equipa.nome));
                                sqlCommand.Parameters.Add(new MySqlParameter("@convocada", equipa.convocada));
                                sqlCommand.Parameters.Add(new MySqlParameter("@liga", equipa.liga));

                                // Tenta executar o comando, que é suposto devolver 1
                                if (sqlCommand.ExecuteNonQuery() != 1)
                                {
                                    // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                                    MessageBox.Show("Erro...");
                                }
                            }
                            break;
                        case DBMS_SQLITE:
                            using (SQLiteCommand sqlCommand = ((SQLiteConnection)conn).CreateCommand())
                            {
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.CommandText = "UPDATE Equipa SET "
                                + " Nome = @nome,"
                                + " Convocada = @convocada,"
                                + " Liga = @liga"
                                + " WHERE Id = @Id;";
                                sqlCommand.Parameters.Add(new SQLiteParameter("@Id", equipa.id));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@nome", equipa.nome));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@convocada", equipa.convocada));
                                sqlCommand.Parameters.Add(new SQLiteParameter("@liga", equipa.liga));

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
        /// <param name="equipa">Objeto com id a apagar da tabela</param>
        static internal void Del(Equipa equipa)
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
                                sqlCommand.CommandText = "DELETE FROM Equipa WHERE Id=@id;";
                                sqlCommand.Parameters.Add(new SqlParameter("@id", equipa.id));

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
                                sqlCommand.CommandText = "DELETE FROM Equipa WHERE Id=@id;";
                                sqlCommand.Parameters.Add(new MySqlParameter("@id", equipa.id));

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
                                sqlCommand.CommandText = "DELETE FROM Equipa WHERE Id=@id;";
                                sqlCommand.Parameters.Add(new SQLiteParameter("@id", equipa.id));

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
                MessageBox.Show(e.ToString());
            }
        }

        /// <summary>
        /// Controlo de Violação de Integridade Relacional. 
        /// Aplica-se antes do del(). 
        /// A não utilização em PAR destes métodos, vai gerar Exceções
        /// </summary>
        /// <param name="aluno">Registo a testar</param>
        /// <returns></returns>
        static internal bool CheckRelationalIntegrityViolation(Equipa equipa)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////
            // Controlo de Violação de Inegridade Relacional:
            // Verifica se o registo em delete, existe nas tabelas relacionadas (com FK para esta tabela)
            // Analisar no DER as tabelas a tratar: Turma
            ////////////////////////////////////////////////////////////////////////////////////////////////
            StringBuilder strBuilderFK = new StringBuilder();    // Recebe a info onde há violação de integridade
            strBuilderFK.AppendLine("Para eliminar este registo, precisa primeiro de eliminar os seus movimentos em:");

            // Flag de controlo de violação de interidade, para ativar as mensagens na FormAuxuliarInfo
            bool relationalViolationForFKtables = false;   // ativa-se quando o user é fk em tabelas relacionadas

            int count;  // Acumula o nº de ocorrências positivas:

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Para cada tabela referenciada acima, puxa a lista e verifica se tem o registo a eliminar.
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // verifica se há FKs em Jogador
            count = 0;
            foreach (Jogador jogador in SQL_Jogador.GetAll())
            {
                if (jogador.equipa.id == equipa.id)
                {
                    count++;
                    relationalViolationForFKtables = true;
                }
            }
            if (count > 0) strBuilderFK.AppendLine("- Jogador (" + count + "); ");

            // verifica se há FKs em Treinador
            count = 0;
            foreach (Treinador treinador in SQL_Treinador.GetAll())
            {
                if (treinador.equipa.id == equipa.id)
                {
                    count++;
                    relationalViolationForFKtables = true;
                }
            }
            if (count > 0) strBuilderFK.AppendLine("- Treinador (" + count + "); ");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Comunicação ao equipa.
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Se Flag ativa, há violação de integridade relacional. Informa e devolve true.
            if (relationalViolationForFKtables)
            {
                MessageBox.Show(
                    strBuilderFK.ToString(),    // Corpo da msg
                    "Violação de Integridade Relacional",         // Título
                    MessageBoxButtons.OK,       // Botões
                    MessageBoxIcon.Information  // Icon
                );
                return true;    // Há violação de integridade
            }
            return false;       // Não há violação de integridade
        }
        #endregion
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Windows.Forms;
using static Cap09_Winforms_TrabalhoPratico.SQL_Connection;

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
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro...");
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
                                    reader.GetDouble(reader.GetOrdinal("Altura")),
                                    reader["Posicao"].ToString(),
                                    new Equipa(reader.GetInt64(reader.GetOrdinal("EquipaID")))
                                );

                                //adiciona o obj à lista
                                listaJogadores.Add(jogador);
                            }
                        }
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
                MessageBox.Show("Erro...");
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
                                    reader.GetDouble(reader.GetOrdinal("Altura")),
                                    reader["Posicao"].ToString(),
                                    new Equipa(reader.GetInt64(reader.GetOrdinal("EquipaID")))
                                );
                            }
                        }
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
                    using (MySqlCommand sqlCommand = ((MySqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "UPDATE Jogador SET "
                        + " Nome = @nome,"
                        + " Idade = @idade,"
                        + " Altura = @altura,"
                        + " Posicao = @posicao,"
                        + " EquipaID = @equipaid,"
                        + " WHERE Id = @Id;";
                        sqlCommand.Parameters.Add(new MySqlParameter("@Id", jogador.id));
                        sqlCommand.Parameters.Add(new MySqlParameter("@nome", jogador.nome));
                        sqlCommand.Parameters.Add(new MySqlParameter("@idade", jogador.idade));
                        sqlCommand.Parameters.Add(new MySqlParameter("@altura", jogador.altura));
                        sqlCommand.Parameters.Add(new MySqlParameter("@posicao", jogador.posicao));
                        sqlCommand.Parameters.Add(new MySqlParameter("@equipaid", jogador.equipa));

                        // Tenta executar o comando, que é suposto devolver 1
                        if (sqlCommand.ExecuteNonQuery() != 1)
                        {
                            // Se diferente, inverte o commit e Provoca a excessão saltanto para o catch
                            MessageBox.Show("Erro...");
                        }
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
                            throw new InvalidProgramException("SQL_Utilizador - del() - mysql: ");
                        }
                    }                      
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro...");
            }
        }

        /*
        /// <summary>
        /// Controlo de Violação de Integridade Relacional. 
        /// Aplica-se antes do del(). 
        /// A não utilização em PAR destes métodos, vai gerar Exceções
        /// </summary>
        /// <param name="aluno">Registo a testar</param>
        /// <returns></returns>
        static internal bool CheckRelationalIntegrityViolation(Jogador jogador)
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

            // verifica se há FKs em Jogo
            count = 0;
            foreach (Jogo jogo in SQL_Jogo.GetAll())
            {
                if (jogo.Utilizador1.Id == jogador.Id)
                {
                    count++;
                    relationalViolationForFKtables = true;
                }
                else if(jogo.Utilizador2.Id == jogador.Id)
                {
                    count++;
                    relationalViolationForFKtables = true;
                }
            }
            if (count > 0) strBuilderFK.AppendLine("- Jogo (" + count + "); ");

            // verifica se há FKs em Inventario
            count = 0;
            foreach (Inventario inventario in SQL_Inventario.GetAll())
            {
                if (inventario.Jogador.Id == jogador.Id)
                {
                    count++;
                    relationalViolationForFKtables = true;
                }
            }
            if (count > 0) strBuilderFK.AppendLine("- Inventário (" + count + "); ");

            // verifica se há FKs em Deck
            count = 0;
            foreach (Deck deck in SQL_Deck.GetAll())
            {
                if (deck.Jogador.Id == jogador.Id)
                {
                    count++;
                    relationalViolationForFKtables = true;
                }
            }
            if (count > 0) strBuilderFK.AppendLine("- Deck (" + count + "); ");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Comunicação ao jogador.
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

    */
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap09_Winforms_TrabalhoPratico
{
    /// <summary>
    /// Esta classe é utilizada na criação das equipas, esta contem 4 atributos que destiguem as equipas umas nas outras e contem 3 métodos para a criação , edição e eliminação de uma equipa para participar no calendário de jogos do torneio tartaruga.
    /// </summary>

    [Serializable]
    public class Equipa
    {
        #region Atributos
        /// <summary>
        /// É uma variável do tipo long que recebe o id das equipas, pois as equipas que podem ser criadas são infinitas ou seja o id pode chegar a ter vários digitos, logo tem de ser um long.
        /// </summary>
        private long id;

        /// <summary>
        /// É uma varíavel do tipo String que atribui um nome de cada equipa.
        /// </summary>
        private string nome;

        /// <summary>
        /// É uma variável do tipo boolean que verifica se a equipa está ou não convocada para o torneio tartaruga, se sim a equipa é adicionada à lista de equipas, se não a equipa continua na lista de equipas criadas, mas não se encontra adicionada no torneio.
        /// </summary>
        private bool convocada;

        /// <summary>
        /// É uma variável do tipo string que recebe o nome da liga em que a equipa se encontra no torneio tartaruga.
        /// </summary>
        private string liga;
        #endregion

        #region Construtor
        /// <summary>
        /// Construtor para criar Equipas
        /// </summary>
        /// <param name="nome">nome da equipa</param>
        /// <param name="convocada">checa se esta convocada ou não</param>
        /// <param name="liga">liga da equipa</param>
        public Equipa(string nome, bool convocada, string liga)
        {
            this.nome = nome;
            this.convocada = convocada;
            this.liga = liga;
        }
        #endregion

        #region Getters e Setters
        public string getNome()
        {
            return this.nome;
        }
        public void setNome (string nome)
        {
            this.nome = nome;
        }

        public bool getConvocada()
        {
            return this.convocada;
        }
        public void setConvocada(bool convocada)
        {
            this.convocada = convocada;
        }

        public string getLiga()
        {
            return this.liga;
        }
        public void setLiga(string liga)
        {
            this.liga = liga;
        }
        #endregion
    }
}

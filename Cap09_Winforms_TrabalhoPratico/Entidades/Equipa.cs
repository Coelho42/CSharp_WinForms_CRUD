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
        public long id { get; internal set; }

        /// <summary>
        /// É uma varíavel do tipo String que atribui um nome de cada equipa.
        /// </summary>
        public string nome { get; internal set; }

        /// <summary>
        /// É uma variável do tipo boolean que verifica se a equipa está ou não convocada para o torneio tartaruga, se sim a equipa é adicionada à lista de equipas, se não a equipa continua na lista de equipas criadas, mas não se encontra adicionada no torneio.
        /// </summary>
        public bool convocada { get; internal set; }

        /// <summary>
        /// É uma variável do tipo string que recebe o nome da liga em que a equipa se encontra no torneio tartaruga.
        /// </summary>
        public string liga { get; internal set; }
        #endregion

        #region Construtor

        /// <summary>
        /// Construtor Mínimo
        /// </summary>
        /// <param name="id"></param>
        public Equipa(long id)
        {
            this.id = id;
        }

        /// <summary>
        /// Construtor para criar Equipas
        /// </summary>
        /// <param name="id">id da equipa</param>
        /// <param name="nome">nome da equipa</param>
        /// <param name="convocada">checa se esta convocada ou não</param>
        /// <param name="liga">liga da equipa</param>
        public Equipa(long id, string nome, bool convocada, string liga)
        {
            this.id = id;
            this.nome = nome;
            this.convocada = convocada;
            this.liga = liga;
        }
        #endregion
    }
}

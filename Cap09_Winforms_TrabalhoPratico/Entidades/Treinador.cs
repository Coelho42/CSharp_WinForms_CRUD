using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap09_Winforms_TrabalhoPratico
{
    /// <summary>
    /// Esta classe é utilizada na criação dos Jogadores, esta contem 4 atributos que destiguem os trienadores uns dos outros e contem 3 métodos para a criação , edição e eliminação de um ou mais treinadores para que estes participem no calendário de jogos do torneio tartaruga.
    /// </summary>

    [Serializable]
    public class Treinador
    {
        #region Atributos
        /// <summary>
        /// É uma variável do tipo long que recebe o id dos treinadores, pois os treinadores que podem ser criados são infinitos ou seja o id pode chegar a ter vários digitos, logo tem de ser um long
        /// </summary>
        public long id { get; internal set; }

        /// <summary>
        /// É uma varíavel do tipo String que atribui um nome de cada treinador.
        /// </summary>
        public string nome { get; internal set; }

        /// <summary>
        /// Esta variável é um int encarregue atribuição da idade a cada treinador, a variável é do tipo int e não do tipo long porque os treinadores no máximo tem dois digitos no valor da idade, e não é DateTime, pois não é necessário a informação que diz respeito aos meses e dias, ou seja não são crianças com idades inferiores a 1 ano.
        /// </summary>
        public int idade { get; internal set; }

        /// <summary>
        /// É uma variável do tipo double que recebe a altura dos treinadores, pois as alturas têm no máximo 3 digitos mas tem números décimais, logo tem de ser um long.
        /// </summary>
        public double altura { get; internal set; }


        /// <summary>
        /// É uma variável do tipo double que recebe a altura dos treinadores, pois as alturas têm no máximo 3 digitos mas tem números décimais, logo tem de ser um long.
        /// </summary>
        public string categoria { get; internal set; }

        /// <summary>
        /// Esta varíavel é um boolean que checka se o treinador está inserido numa equipa ou não.
        /// </summary>
        public Equipa equipa { get; internal set; }
        #endregion

        #region Construtor
        /// <summary>
        /// Construtor para criar um treinador
        /// </summary>
        /// <param name="id">id do treinador</param>
        /// <param name="nome">nome do treinador</param>
        /// <param name="idade">idade do treinador</param>
        /// <param name="altura">altura do treinador</param>
        /// <param name="categoria">categoria do treinador</param>
        /// <param name="equipa">equipa do treinador</param>
        public Treinador(long id, string nome, int idade, double altura, string categoria, Equipa equipa)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.categoria = categoria;
            this.equipa = equipa;
        }
        #endregion

    }
}

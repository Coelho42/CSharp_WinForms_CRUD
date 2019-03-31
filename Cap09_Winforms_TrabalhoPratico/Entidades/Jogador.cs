using System;

namespace Cap09_Winforms_TrabalhoPratico
{
    /// <summary>
    /// Esta classe é utilizada na criação dos Jogadores, esta contem 4 atributos que destiguem os jogadores uns dos outros e contem 3 métodos para a criação , edição e eliminação de um ou mais jogadores para que estes participem no calendário de jogos do torneio tartaruga.
    /// </summary>

    [Serializable]
    public class Jogador
    {
        #region Atributos
        /// <summary>
        /// É uma variável do tipo long que recebe o id dos jogadores, pois os jogadores que podem ser criados são infinitos ou seja o id pode chegar a ter vários digitos, logo tem de ser um long
        /// </summary>
        public long id { get; internal set; }

        /// <summary>
        /// É uma varíavel do tipo String que atribui um nome de cada jogador.
        /// </summary>
        public string nome { get; internal set; }

        /// <summary>
        /// Esta variável é um int encarregue atribuição da idade a cada jogador, a variável é do tipo int e não do tipo long porque os jogadores no máximo tem dois digitos no valor da idade, e não é DateTime, pois não é necessário a informação que diz respeito aos meses e dias, ou seja não são crianças com idades inferiores a 1 ano.
        /// </summary>
        public int idade { get; internal set; }

        /// <summary>
        /// É uma variável do tipo double que recebe a altura dos jogadores, pois as alturas têm no máximo 3 digitos mas tem números décimais, logo tem de ser um long.
        /// </summary>
        public double altura { get; internal set; }

        /// <summary>
        /// É um variável do tipo String que indica a posição do Treinador
        /// </summary>
        public string posicao { get; internal set; }

        /// <summary>
        /// É um variável do tipo String que indica a posição do Treinador
        /// </summary>
        public Equipa equipa { get; internal set; }
        #endregion

        #region Construtor
        /// <summary>
        /// Construtor para criar um jogador
        /// </summary>
        /// <param name="id">id do jogador</param>
        /// <param name="nome">nome do jogador</param>
        /// <param name="idade">idade do jogador</param>
        /// <param name="altura">altura do jogador</param>
        /// <param name="posicao">posicao do jogador</param>
        public Jogador(long id, string nome, int idade, double altura, string posicao, Equipa equipa)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.posicao = posicao;
            this.equipa = equipa;
        }
        #endregion
    }
}
    


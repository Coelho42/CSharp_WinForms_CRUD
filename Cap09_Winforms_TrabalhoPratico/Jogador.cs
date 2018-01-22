using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap09_Winforms_TrabalhoPratico
{
    /// <summary>
    /// Esta classe é utilizada na criação dos Jogadores, esta contem 4 atributos que destiguem os jogadores uns dos outros e contem 3 métodos para a criação , edição e eliminação de um ou mais jogadores para que estes participem no calendário de jogos do torneio tartaruga.
    /// </summary>
    
    public class Jogador
    {
        /// <summary>
        /// É uma variável do tipo long que recebe o id dos jogadores, pois os jogadores que podem ser criados são infinitos ou seja o id pode chegar a ter vários digitos, logo tem de ser um long
        /// </summary>
        private long id;

        /// <summary>
        /// É uma varíavel do tipo String que atribui um nome de cada jogador.
        /// </summary>
        private string nome;

        /// <summary>
        /// Esta variável é um int encarregue atribuição da idade a cada jogador, a variável é do tipo int e não do tipo long porque os jogadores no máximo tem dois digitos no valor da idade, e não é DateTime, pois não é necessário a informação que diz respeito aos meses e dias, ou seja não são crianças com idades inferiores a 1 ano.
        /// </summary>
        private int idade;

        /// <summary>
        /// É uma variável do tipo int que recebe a altura dos jogadores, pois as alturas têm no máximo 3 digitos mas tem números décimais, logo tem de ser um long.
        /// </summary>
        private long altura;

        public Jogador(string nome, int idade, long altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getIdade()
        {
            return this.idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public long getAltura()
        {
            return this.altura;
        }
        public void setAltura(long altura)
        {
            this.altura = altura;
        }
    }
}
    


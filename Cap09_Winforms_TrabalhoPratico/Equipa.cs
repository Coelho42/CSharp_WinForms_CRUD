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

    class Equipa
    {
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

        public Equipa(string nome)
        {
            this.nome = nome;
        }

        /// <summary>
        /// Esté é um método que está encarregado da adição das equipas na lista, este tem como parâmetros de entrada os jogadores e os treinadores, e tem como método de saída void.
        /// </summary>
        /// <param name="jogador">Recebe o jogador do tipo classe Jogador para ser criada a equipa</param>
        /// <param name="treinador">Recebe o treinador do tipo classe Treinador para ser criada</param>
        public void Add(ref Jogador jogador, ref Treinador treinador, ref List<Equipa> listaEquipa)
        {
            throw new System.Exception("Not implemented");
        }
        /// <summary>
        /// Esté é um método que está encarregado da edição das equipas na lista, anteriormente criadas, este tem como parâmetros de entrada os jogadores e os treinadores, e tem como método de saída void.
        /// </summary>
        /// <param name="jogador">Recebe o jogador do tipo classe Jogador para ser editado</param>
        /// <param name="treinador">Recebe o treinador do tipo classe Treinador para ser editado</param>
        public void Edit(ref Jogador jogador, ref Treinador treinador, ref List<Equipa> listaEquipa)
        {
            throw new System.Exception("Not implemented");
        }
        /// <summary>
        /// Esté é um método que está encarregado de eliminar equipas na lista,anteriormente criadas ou editadas, este tem como parâmetros de entrada os jogadores e os treinadores, e tem como método de saída void.
        /// </summary>
        /// <param name="jogador">Recebe o jogador do tipo classe Jogador</param>
        /// <param name="treinador">Recebe o treinador do tipo classe Treinador</param>
        public void Delete(ref Jogador jogador, ref Treinador treinador, ref List<Equipa> listaEquipa)
        {
            throw new System.Exception("Not implemented");
        }

        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome (string nome)
        {
            this.nome = nome;
        }
    }
}

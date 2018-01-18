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
    
    class Treinador
    {
        /// <summary>
        /// É uma variável do tipo long que recebe o id dos treinadores, pois os treinadores que podem ser criados são infinitos ou seja o id pode chegar a ter vários digitos, logo tem de ser um long
        /// </summary>
        private long id;

        /// <summary>
        /// É uma varíavel do tipo String que atribui um nome de cada treinador.
        /// </summary>
        private string nome;

        /// <summary>
        /// Esta variável é um int encarregue atribuição da idade a cada treinador, a variável é do tipo int e não do tipo long porque os treinadores no máximo tem dois digitos no valor da idade, e não é DateTime, pois não é necessário a informação que diz respeito aos meses e dias, ou seja não são crianças com idades inferiores a 1 ano.
        /// </summary>
        private int idade;

        /// <summary>
        /// Esta varíavel é um boolean que checka se o treinador está inserido numa equipa ou não.
        /// </summary>
        private bool equipa;


        /// <summary>
        /// Esté é um método que está encarregado da criação dos treinadores na lista, este não tem parâmetros de entrada, e tem como método de saída void.
        /// </summary>
        public void Add(List<Treinador> listaTreinador)
        {
            throw new System.Exception("Not implemented");
        }

        /// <summary>
        /// Esté é um método que está encarregado da edição dos treinadores na lista, este não tem parâmetros de entrada, e tem como método de saída void.
        /// </summary>
        public void Edit(List<Treinador> listaTreinador)
        {
            throw new System.Exception("Not implemented");
        }

        /// <summary>
        /// Esté é um método que está encarregado da eliminação dos treinadores na lista, este não tem parâmetros de entrada, e tem como método de saída void.
        /// </summary>
        public void Delete(List<Treinador> listaTreinador)
        {
            throw new System.Exception("Not implemented");
        }
    }
}

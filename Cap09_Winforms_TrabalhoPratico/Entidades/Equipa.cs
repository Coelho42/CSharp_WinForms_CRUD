using System;
using System.Collections.Generic;
using System.Text;

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
        public int id { get; internal set; }

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
        public Equipa(int id)
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
        public Equipa(int id, string nome, bool convocada, string liga)
        {
            this.id = id;
            this.nome = nome;
            this.convocada = convocada;
            this.liga = liga;
        }

        /// <summary>
        /// Construtor para criar Equipas sem id
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

        #region Construtor simples e com DesSerializador

        /// <summary>
        /// Construtor que DesSerializa a partir de um byte array.
        /// </summary>
        /// <param name="data">Array de bytes para desSerializar</param>
        public Equipa(byte[] data)
        {
            // Como extrair os dados do array se só lá há bytes?
            // 1º sabe-se a ordem com que as props foram serializados
            //    (IsMale, Age, tamanho da string, a string.)
            // 2º Sabe-se o tamanho de cada tipo de dados
            // => temos tudo o que precisamos.

            // extrai a partir do byte 3, um int32 (4bytes) e converte para int32
            // Contem o tamanho da string em bytes
            int tamanhoNome = BitConverter.ToInt32(data, 10);

            // Extrai a partir do 11º byte (10), um byte e converte para bool
            nome = Encoding.UTF8.GetString(data, 14, tamanhoNome);

            // Extrai a partir do byte 11, 2bytes e converte para int16 (2bytes)
            convocada = BitConverter.ToBoolean(data, 14 + tamanhoNome);

            // extrai a partir do byte 3, um int32 (4bytes) e converte para int32
            // Contem o tamanho da string em bytes
            int tamanhoLiga = BitConverter.ToInt32(data, 16 + tamanhoNome);

            // extrai a partir do byte 20, uma string de tamanho nameLength
            liga = Encoding.UTF8.GetString(data, 20 + tamanhoNome, tamanhoLiga);
        }

        #endregion

        #region Serializador

        /// <summary>
        /// Serializa Pessoa para Array de Bytes porque
        /// os sockets transmitem arrays de bytes.
        /// Processo:
        /// 1º Cada atributo ou property é convertida para Bytes, 
        /// através da Classe static BitConverter;
        /// 2º Estes bytes são adicionados a uma Lista de Bytes;
        /// 3º A lista é convertida num array de Bytes que é
        /// finalmente devolvida e entregue ao socket que transmite.
        /// </summary>
        /// <returns>Array de Bytes com os dados da Pessoa</returns>
        public byte[] ToByteArray()
        {
            // Usamos uma Lista de bytes para receber os dados 
            // convertidos pq é mais eficiente.
            List<byte> byteList = new List<byte>();

            // Conversão das properties num array de Bytes;
            // Cada propriedade tem um tipo de dados, que 
            // Cada tipo de dados ocupa um det. nº de bytes. 
            // int32 ocupa 4 bytes, bool ocupa 1 byte, etc.
            // A ideia é converter cada uma das properties e
            // adiciona-las "enfia-las" num array de bytes.
            // No fim temos um array de bytes que pode ser
            // enviado para qq lado, por um socket ou num 
            // ficheiro binário.
            // Notar também, para adicionar os bytes 
            // convertidos para a List, usa-se o AddRange()
            // e não o tradicional Add(). Isto pq está-se a 
            // adicionar vários bytes de cada conversão e não
            // um só byte.  
            byteList.AddRange(BitConverter.GetBytes(nome.Length));          // int 16 bits ocupa 2 bytes
            byteList.AddRange(Encoding.UTF8.GetBytes(nome));       // Bollean ocupa 1 byte
            byteList.AddRange(BitConverter.GetBytes(convocada));          // int 16 bits ocupa 2 bytes
            byteList.AddRange(BitConverter.GetBytes(liga.Length));          // int 16 bits ocupa 2 bytes
            byteList.AddRange(Encoding.UTF8.GetBytes(liga));        // String

            // do outro lado surge um array de bytes. Como 
            // extrair os dados do array se só lá há bytes?

            // Devolução do array de bytes, após conversão da List.
            return byteList.ToArray();
        }

        #endregion
    }
}

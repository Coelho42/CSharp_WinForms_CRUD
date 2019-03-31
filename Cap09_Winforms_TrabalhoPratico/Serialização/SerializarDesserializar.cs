using System;
using System.Collections.Generic;

namespace Cap09_Winforms_TrabalhoPratico
{
    [Serializable]
    class SerializarDesserializar
    {
        #region Variáveis
        List<Equipa> listaEquipasSer = new List<Equipa>();              
        List<Jogador> listaJogadorSer = new List<Jogador>();                
        List<Treinador> listaTreinadorSer = new List<Treinador>();
        #endregion

        #region Construtor
        /// <summary>
        /// Construtor que serializa as listas
        /// </summary>
        /// <param name="listaEquipas">lista de equipas</param>
        /// <param name="listaJogadores">lista de jogadores</param>
        /// <param name="listaTreinadores">lista de treinadores</param>
        /// 
        public SerializarDesserializar(List<Equipa> listaEquipas, List<Jogador> listaJogadores, List<Treinador> listaTreinadores)
        {
            this.listaEquipasSer = listaEquipas;
            this.listaJogadorSer = listaJogadores;
            this.listaTreinadorSer = listaTreinadores;         
        }
        #endregion

        #region Getters & Setters
        public List<Equipa> GetListaEquipasSer()
        {
            return this.listaEquipasSer;
        }

        public void SetListaBossesSer(List<Equipa> listaEquipasSer)
        {
            this.listaEquipasSer = listaEquipasSer;
        }

        public List<Jogador> GetListaJogadorSer()
        {
            return this.listaJogadorSer;
        }

        public void SetListaJogadoresSer(List<Jogador> listaJogadorSer)
        {
            this.listaJogadorSer = listaJogadorSer;
        }

        public List<Treinador> GetListaTreinadoresSer()
        {
            return this.listaTreinadorSer;
        }

        public void SetListaSoldadosSer(List<Treinador> listaTreinadorSer)
        {
            this.listaTreinadorSer = listaTreinadorSer;
        }
        #endregion
    }
}

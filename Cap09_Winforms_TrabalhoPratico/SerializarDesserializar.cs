using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap09_Winforms_TrabalhoPratico
{
    [Serializable]
    class SerializarDesserializar
    {
        List<Equipa> listaEquipasSer = new List<Equipa>();              
        List<Jogador> listaJogadorSer = new List<Jogador>();                
        List<Treinador> listaTreinadorSer = new List<Treinador>();      
     
        public SerializarDesserializar()
        {

        }

       
        public SerializarDesserializar(List<Equipa> listaEquipas, List<Jogador> listaJogadores, List<Treinador> listaTreinadores)
        {
            this.listaEquipasSer = listaEquipas;
            this.listaJogadorSer = listaJogadores;
            this.listaTreinadorSer = listaTreinadores;         
        }

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

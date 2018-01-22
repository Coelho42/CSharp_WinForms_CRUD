using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap09_Winforms_TrabalhoPratico
{
    public partial class Controlo : Form
    {
        static List<Equipa> listaEquipas = new List<Equipa>();

        static List<Jogador> listaJogadores = new List<Jogador>();

        static List<Treinador> listaTreinadores = new List<Treinador>();


        public Controlo()
        {
            InitializeComponent();
        }

        #region Getters & Setters
        public static List<Equipa> GetListaEquipas()
        {
            return listaEquipas;
        }

        public static List<Jogador> GetListaJogadores()
        {
            return listaJogadores;
        }

        public static List<Treinador> GetListaTreinadores()
        {
            return listaTreinadores;
        }
        #endregion

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
        }

        private void equipasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidadeEquipasLista formEquipa = new FormEntidadeEquipasLista();
            formEquipa.ShowDialog();
        }

        private void jogadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidadeJogadoresLista formJogador = new FormEntidadeJogadoresLista();
            formJogador.ShowDialog();
        }

        private void treinadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntidadeTreinadoresLista formTreinador = new FormEntidadeTreinadoresLista();
            formTreinador.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = saveFileDialog.ShowDialog();

            if (DialogResult == DialogResult.OK)
            {
                SerializarDesserializar dados = new SerializarDesserializar(listaEquipas, listaJogadores, listaTreinadores);
                Serializar(saveFileDialog.FileName, dados);
            }               
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult = openFileDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                SerializarDesserializar dados = (SerializarDesserializar)Desserializar(openFileDialog.FileName);
                listaEquipas = dados.GetListaEquipasSer();
                listaJogadores = dados.GetListaJogadorSer();
                listaTreinadores = dados.GetListaTreinadoresSer();
            }            
        }

        /// <summary>
        /// Metodo para serializar
        /// Ao ter no parametro o tipo Object, permite receber ali qualquer objeto
        /// </summary>
        /// <param name="fileLocation"> string com a localização e nome do file onde sera gravado o objeto </param>
        /// <param name="obj"> Objeto a serualizar (Object é o topo da hierarquia dos objetos nas POO) </param>
        public static void Serializar(string fileLocation, Object obj)
        {         
            try
            {
                Stream streamToFile = File.OpenWrite(fileLocation);     // Cria Stream para abrir a escrever no file
                BinaryFormatter bf = new BinaryFormatter();             // Serializador / DesSerializador
                bf.Serialize(streamToFile, obj);                        // Escreve os bits do objeto no file binario
                streamToFile.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("ERRO: Impossivel criar ou abrir o ficheiro.");
                e.ToString();       // Imprimir o erro tecnico
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO: Ocorreu um problema inesperado.");
                e.ToString();       // Imprimir o erro tecnico
            }

        }

        /// <summary>
        /// Metodo para deserializar
        /// recebe a string da localização e o nome do file que recebe o obj e o obj a desserializar
        /// </summary>
        /// <param name="fileLocation"> string com a localização e o nome da file a ser criada </param>
        /// <returns> objeto generico (topo da hierarquia dos objetos - tem que ser convertido com um CAST) </returns>
        public static Object Desserializar(string fileLocation)
        {
            try
            {
                Stream streamFromFile = File.OpenRead(fileLocation);    // Cria Stream
                BinaryFormatter bf = new BinaryFormatter();             // Serializador / DesSerializador
                Object obj = bf.Deserialize(streamFromFile);            // Recebe os 
                return obj;
            }
            catch (IOException e)
            {
                MessageBox.Show("ERRO: Impossivel criar ou abrir o ficheiro.");
                e.ToString();       // Imprimir o erro tecnico
                return null;        // Caso haja um erro, devolve um objeto null
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO: Ocorreu um problema inesperado.");
                e.ToString();       // Imprimir o erro tecnico
                return null;        // Caso haja um erro, devolve um objeto null
            }
        }
    }
}

﻿using Cap09_Winforms_TrabalhoPratico.Sockets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static Cap09_Winforms_TrabalhoPratico.Settings;
using static Cap09_Winforms_TrabalhoPratico.SQL_Connection;

namespace Cap09_Winforms_TrabalhoPratico
{
    public partial class Controlo : Form
    {
        #region Variáveis
        static List<Equipa> listaEquipas = new List<Equipa>();

        static List<Jogador> listaJogadores = new List<Jogador>();

        static List<Treinador> listaTreinadores = new List<Treinador>();
        #endregion

        public Controlo()
        {
            InitializeComponent();
        }

        #region Getters & Setters
        public static List<Equipa> GetListaEquipas()
        {
            listaEquipas = SQL_Equipa.GetAll();
            return listaEquipas;
        }

        public static List<Jogador> GetListaJogadores()
        {
            listaJogadores = SQL_Jogador.GetAll();
            return listaJogadores;
        }

        public static List<Treinador> GetListaTreinadores()
        {
            listaTreinadores = SQL_Treinador.GetAll();
            return listaTreinadores;
        }
        #endregion

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
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

        #region Serializar e Desserializar
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
        #endregion

        /// <summary>
        /// Abre a interface para os Sockets do Servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.IsServer = true;
            FormWork formSockets = new FormWork();
            formSockets.ShowDialog();
        }

        /// <summary>
        /// Abre a interface para os Sockets do Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.IsServer = false;
            FormWork formSockets = new FormWork();
            formSockets.ShowDialog();
        }

        #region CRUDS

        #region Equipa
        private void bDLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeEquipasLista();
            DBMSactive = DBMS_SQLSERVER_BD_LOCAL;
            fr.ShowDialog();
        }

        private void mySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeEquipasLista();
            DBMSactive = DBMS_MYSQL;
            fr.ShowDialog();
        }

        private void sQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeEquipasLista();
            DBMSactive = DBMS_SQLSERVER;
            fr.ShowDialog();
        }

        private void sQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeEquipasLista();
            DBMSactive = DBMS_SQLITE;
            fr.ShowDialog();
        }
        #endregion

        #region Jogador
        private void bDLocalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeJogadoresLista();
            DBMSactive = DBMS_SQLSERVER_BD_LOCAL;
            fr.ShowDialog();
        }

        private void mySQLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeJogadoresLista();
            DBMSactive = DBMS_MYSQL;
            fr.ShowDialog();
        }

        private void sQLServerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeJogadoresLista();
            DBMSactive = DBMS_SQLSERVER;
            fr.ShowDialog();
        }

        private void sQLiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeJogadoresLista();
            DBMSactive = DBMS_SQLITE;
            fr.ShowDialog();
        }
        #endregion

        #region Treinador
        private void bDLocalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeTreinadoresLista();
            DBMSactive = DBMS_SQLSERVER_BD_LOCAL;
            fr.ShowDialog();
        }

        private void mySQLToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeTreinadoresLista();
            DBMSactive = DBMS_MYSQL;
            fr.ShowDialog();
        }

        private void sQLServerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeTreinadoresLista();
            DBMSactive = DBMS_SQLSERVER;
            fr.ShowDialog();
        }

        private void sQLiteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form fr = new FormEntidadeTreinadoresLista();
            DBMSactive = DBMS_SQLITE;
            fr.ShowDialog();
        }
        #endregion

        #endregion
    }
}

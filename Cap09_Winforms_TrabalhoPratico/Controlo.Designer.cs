namespace Cap09_Winforms_TrabalhoPratico
{
    partial class Controlo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuStripOpcoes = new System.Windows.Forms.MenuStrip();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDLocalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treinadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDLocalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLServerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLiteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.socketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOpcoes.SuspendLayout();
            this.menuStripOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "DadosTorneioTartaruga";
            this.saveFileDialog.Filter = "\"Bin files (*.bin)|*.bin";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "bin";
            this.openFileDialog.Filter = "Bin files (*.bin)|*.bin";
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.BackgroundImage = global::Cap09_Winforms_TrabalhoPratico.Properties.Resources.Wallpapper;
            this.panelOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOpcoes.Controls.Add(this.labelTitle);
            this.panelOpcoes.Controls.Add(this.menuStripOpcoes);
            this.panelOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpcoes.Location = new System.Drawing.Point(0, 0);
            this.panelOpcoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(1204, 731);
            this.panelOpcoes.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(37, 42);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(524, 69);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Torneio Tartaruga";
            // 
            // menuStripOpcoes
            // 
            this.menuStripOpcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entidadesToolStripMenuItem,
            this.socketsToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStripOpcoes.Location = new System.Drawing.Point(0, 0);
            this.menuStripOpcoes.Name = "menuStripOpcoes";
            this.menuStripOpcoes.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripOpcoes.Size = new System.Drawing.Size(1204, 28);
            this.menuStripOpcoes.TabIndex = 8;
            this.menuStripOpcoes.Text = "menuStrip1";
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipasToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.treinadoresToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.entidadesToolStripMenuItem.Text = "Principal";
            // 
            // equipasToolStripMenuItem
            // 
            this.equipasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDLocalToolStripMenuItem,
            this.mySQLToolStripMenuItem,
            this.sQLServerToolStripMenuItem,
            this.sQLiteToolStripMenuItem});
            this.equipasToolStripMenuItem.Name = "equipasToolStripMenuItem";
            this.equipasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.equipasToolStripMenuItem.Text = "Equipas";
            // 
            // bDLocalToolStripMenuItem
            // 
            this.bDLocalToolStripMenuItem.Name = "bDLocalToolStripMenuItem";
            this.bDLocalToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bDLocalToolStripMenuItem.Text = "BDLocal";
            this.bDLocalToolStripMenuItem.Click += new System.EventHandler(this.bDLocalToolStripMenuItem_Click);
            // 
            // mySQLToolStripMenuItem
            // 
            this.mySQLToolStripMenuItem.Name = "mySQLToolStripMenuItem";
            this.mySQLToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.mySQLToolStripMenuItem.Text = "MySQL";
            this.mySQLToolStripMenuItem.Click += new System.EventHandler(this.mySQLToolStripMenuItem_Click);
            // 
            // sQLServerToolStripMenuItem
            // 
            this.sQLServerToolStripMenuItem.Name = "sQLServerToolStripMenuItem";
            this.sQLServerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sQLServerToolStripMenuItem.Text = "SQLServer";
            this.sQLServerToolStripMenuItem.Click += new System.EventHandler(this.sQLServerToolStripMenuItem_Click);
            // 
            // sQLiteToolStripMenuItem
            // 
            this.sQLiteToolStripMenuItem.Name = "sQLiteToolStripMenuItem";
            this.sQLiteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sQLiteToolStripMenuItem.Text = "SQLite";
            this.sQLiteToolStripMenuItem.Click += new System.EventHandler(this.sQLiteToolStripMenuItem_Click);
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDLocalToolStripMenuItem1,
            this.mySQLToolStripMenuItem1,
            this.sQLServerToolStripMenuItem1,
            this.sQLiteToolStripMenuItem1});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.jogadoresToolStripMenuItem.Text = "Jogadores";
            // 
            // bDLocalToolStripMenuItem1
            // 
            this.bDLocalToolStripMenuItem1.Name = "bDLocalToolStripMenuItem1";
            this.bDLocalToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.bDLocalToolStripMenuItem1.Text = "BDLocal";
            this.bDLocalToolStripMenuItem1.Click += new System.EventHandler(this.bDLocalToolStripMenuItem1_Click);
            // 
            // mySQLToolStripMenuItem1
            // 
            this.mySQLToolStripMenuItem1.Name = "mySQLToolStripMenuItem1";
            this.mySQLToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.mySQLToolStripMenuItem1.Text = "MySQL";
            this.mySQLToolStripMenuItem1.Click += new System.EventHandler(this.mySQLToolStripMenuItem1_Click);
            // 
            // sQLServerToolStripMenuItem1
            // 
            this.sQLServerToolStripMenuItem1.Name = "sQLServerToolStripMenuItem1";
            this.sQLServerToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.sQLServerToolStripMenuItem1.Text = "SQLServer";
            this.sQLServerToolStripMenuItem1.Click += new System.EventHandler(this.sQLServerToolStripMenuItem1_Click);
            // 
            // sQLiteToolStripMenuItem1
            // 
            this.sQLiteToolStripMenuItem1.Name = "sQLiteToolStripMenuItem1";
            this.sQLiteToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.sQLiteToolStripMenuItem1.Text = "SQLite";
            this.sQLiteToolStripMenuItem1.Click += new System.EventHandler(this.sQLiteToolStripMenuItem1_Click);
            // 
            // treinadoresToolStripMenuItem
            // 
            this.treinadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDLocalToolStripMenuItem2,
            this.mySQLToolStripMenuItem2,
            this.sQLServerToolStripMenuItem2,
            this.sQLiteToolStripMenuItem2});
            this.treinadoresToolStripMenuItem.Name = "treinadoresToolStripMenuItem";
            this.treinadoresToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.treinadoresToolStripMenuItem.Text = "Treinadores";
            // 
            // bDLocalToolStripMenuItem2
            // 
            this.bDLocalToolStripMenuItem2.Name = "bDLocalToolStripMenuItem2";
            this.bDLocalToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.bDLocalToolStripMenuItem2.Text = "BDLocal";
            this.bDLocalToolStripMenuItem2.Click += new System.EventHandler(this.bDLocalToolStripMenuItem2_Click);
            // 
            // mySQLToolStripMenuItem2
            // 
            this.mySQLToolStripMenuItem2.Name = "mySQLToolStripMenuItem2";
            this.mySQLToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.mySQLToolStripMenuItem2.Text = "MySQL";
            this.mySQLToolStripMenuItem2.Click += new System.EventHandler(this.mySQLToolStripMenuItem2_Click);
            // 
            // sQLServerToolStripMenuItem2
            // 
            this.sQLServerToolStripMenuItem2.Name = "sQLServerToolStripMenuItem2";
            this.sQLServerToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.sQLServerToolStripMenuItem2.Text = "SQLServer";
            this.sQLServerToolStripMenuItem2.Click += new System.EventHandler(this.sQLServerToolStripMenuItem2_Click);
            // 
            // sQLiteToolStripMenuItem2
            // 
            this.sQLiteToolStripMenuItem2.Name = "sQLiteToolStripMenuItem2";
            this.sQLiteToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.sQLiteToolStripMenuItem2.Text = "SQLite";
            this.sQLiteToolStripMenuItem2.Click += new System.EventHandler(this.sQLiteToolStripMenuItem2_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // socketsToolStripMenuItem
            // 
            this.socketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.socketsToolStripMenuItem.Name = "socketsToolStripMenuItem";
            this.socketsToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.socketsToolStripMenuItem.Text = "Sockets";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.serverToolStripMenuItem.Text = "Server";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Controlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 731);
            this.Controls.Add(this.panelOpcoes);
            this.MainMenuStrip = this.menuStripOpcoes;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Controlo";
            this.Text = "Torneio Tartaruga";
            this.panelOpcoes.ResumeLayout(false);
            this.panelOpcoes.PerformLayout();
            this.menuStripOpcoes.ResumeLayout(false);
            this.menuStripOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.MenuStrip menuStripOpcoes;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treinadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem socketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDLocalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sQLServerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bDLocalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sQLServerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sQLiteToolStripMenuItem2;
    }
}


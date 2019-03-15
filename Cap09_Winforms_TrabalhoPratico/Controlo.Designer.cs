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
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panelOpcoes.Margin = new System.Windows.Forms.Padding(2);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(903, 594);
            this.panelOpcoes.TabIndex = 3;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Transparent;
            this.labelTitle.Location = new System.Drawing.Point(28, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(426, 55);
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
            this.menuStripOpcoes.Size = new System.Drawing.Size(903, 24);
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
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.entidadesToolStripMenuItem.Text = "Principal";
            // 
            // equipasToolStripMenuItem
            // 
            this.equipasToolStripMenuItem.Name = "equipasToolStripMenuItem";
            this.equipasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.equipasToolStripMenuItem.Text = "Equipas";
            this.equipasToolStripMenuItem.Click += new System.EventHandler(this.equipasToolStripMenuItem_Click);
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.jogadoresToolStripMenuItem.Text = "Jogadores";
            this.jogadoresToolStripMenuItem.Click += new System.EventHandler(this.jogadoresToolStripMenuItem_Click);
            // 
            // treinadoresToolStripMenuItem
            // 
            this.treinadoresToolStripMenuItem.Name = "treinadoresToolStripMenuItem";
            this.treinadoresToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.treinadoresToolStripMenuItem.Text = "Treinadores";
            this.treinadoresToolStripMenuItem.Click += new System.EventHandler(this.treinadoresToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // socketsToolStripMenuItem
            // 
            this.socketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.socketsToolStripMenuItem.Name = "socketsToolStripMenuItem";
            this.socketsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.socketsToolStripMenuItem.Text = "Sockets";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serverToolStripMenuItem.Text = "Server";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Controlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 594);
            this.Controls.Add(this.panelOpcoes);
            this.MainMenuStrip = this.menuStripOpcoes;
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}


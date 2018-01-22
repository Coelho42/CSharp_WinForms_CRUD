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
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOpcoes.SuspendLayout();
            this.menuStripOpcoes.SuspendLayout();
            this.SuspendLayout();
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
            this.equipasToolStripMenuItem.Name = "equipasToolStripMenuItem";
            this.equipasToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.equipasToolStripMenuItem.Text = "Equipas";
            this.equipasToolStripMenuItem.Click += new System.EventHandler(this.equipasToolStripMenuItem_Click);
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.jogadoresToolStripMenuItem.Text = "Jogadores";
            this.jogadoresToolStripMenuItem.Click += new System.EventHandler(this.jogadoresToolStripMenuItem_Click);
            // 
            // treinadoresToolStripMenuItem
            // 
            this.treinadoresToolStripMenuItem.Name = "treinadoresToolStripMenuItem";
            this.treinadoresToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.treinadoresToolStripMenuItem.Text = "Treinadores";
            this.treinadoresToolStripMenuItem.Click += new System.EventHandler(this.treinadoresToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
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
    }
}


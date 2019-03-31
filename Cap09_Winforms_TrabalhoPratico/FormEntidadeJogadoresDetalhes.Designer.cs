namespace Cap09_Winforms_TrabalhoPratico
{
    partial class FormEntidadeJogadoresDetalhes
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
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeJogador = new System.Windows.Forms.Label();
            this.labelAlturaJogador = new System.Windows.Forms.Label();
            this.labelIdadeJogador = new System.Windows.Forms.Label();
            this.buttonAction = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPosicao = new System.Windows.Forms.Label();
            this.textBoxPosicao = new System.Windows.Forms.TextBox();
            this.labelEquipa = new System.Windows.Forms.Label();
            this.comboBoxEquipa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(93, 122);
            this.textBoxAltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAltura.Multiline = true;
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(235, 41);
            this.textBoxAltura.TabIndex = 9;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(93, 75);
            this.textBoxIdade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(235, 41);
            this.textBoxIdade.TabIndex = 8;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(93, 28);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(235, 41);
            this.textBoxNome.TabIndex = 7;
            // 
            // labelNomeJogador
            // 
            this.labelNomeJogador.AutoSize = true;
            this.labelNomeJogador.Location = new System.Drawing.Point(39, 28);
            this.labelNomeJogador.Name = "labelNomeJogador";
            this.labelNomeJogador.Size = new System.Drawing.Size(49, 17);
            this.labelNomeJogador.TabIndex = 11;
            this.labelNomeJogador.Text = "Nome:";
            // 
            // labelAlturaJogador
            // 
            this.labelAlturaJogador.AutoSize = true;
            this.labelAlturaJogador.Location = new System.Drawing.Point(39, 122);
            this.labelAlturaJogador.Name = "labelAlturaJogador";
            this.labelAlturaJogador.Size = new System.Drawing.Size(49, 17);
            this.labelAlturaJogador.TabIndex = 12;
            this.labelAlturaJogador.Text = "Altura:";
            // 
            // labelIdadeJogador
            // 
            this.labelIdadeJogador.AutoSize = true;
            this.labelIdadeJogador.Location = new System.Drawing.Point(39, 75);
            this.labelIdadeJogador.Name = "labelIdadeJogador";
            this.labelIdadeJogador.Size = new System.Drawing.Size(47, 17);
            this.labelIdadeJogador.TabIndex = 13;
            this.labelIdadeJogador.Text = "Idade:";
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(93, 249);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(101, 46);
            this.buttonAction.TabIndex = 14;
            this.buttonAction.Text = "\"Custom\"";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(228, 249);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 46);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPosicao
            // 
            this.labelPosicao.AutoSize = true;
            this.labelPosicao.Location = new System.Drawing.Point(24, 169);
            this.labelPosicao.Name = "labelPosicao";
            this.labelPosicao.Size = new System.Drawing.Size(62, 17);
            this.labelPosicao.TabIndex = 17;
            this.labelPosicao.Text = "Posição:";
            // 
            // textBoxPosicao
            // 
            this.textBoxPosicao.Location = new System.Drawing.Point(93, 169);
            this.textBoxPosicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosicao.Multiline = true;
            this.textBoxPosicao.Name = "textBoxPosicao";
            this.textBoxPosicao.Size = new System.Drawing.Size(235, 41);
            this.textBoxPosicao.TabIndex = 16;
            // 
            // labelEquipa
            // 
            this.labelEquipa.AutoSize = true;
            this.labelEquipa.Location = new System.Drawing.Point(24, 220);
            this.labelEquipa.Name = "labelEquipa";
            this.labelEquipa.Size = new System.Drawing.Size(56, 17);
            this.labelEquipa.TabIndex = 19;
            this.labelEquipa.Text = "Equipa:";
            // 
            // comboBoxEquipa
            // 
            this.comboBoxEquipa.FormattingEnabled = true;
            this.comboBoxEquipa.Location = new System.Drawing.Point(93, 217);
            this.comboBoxEquipa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEquipa.Name = "comboBoxEquipa";
            this.comboBoxEquipa.Size = new System.Drawing.Size(235, 24);
            this.comboBoxEquipa.TabIndex = 20;
            // 
            // FormEntidadeJogadoresDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 307);
            this.Controls.Add(this.comboBoxEquipa);
            this.Controls.Add(this.labelEquipa);
            this.Controls.Add(this.labelPosicao);
            this.Controls.Add(this.textBoxPosicao);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelIdadeJogador);
            this.Controls.Add(this.labelAlturaJogador);
            this.Controls.Add(this.labelNomeJogador);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEntidadeJogadoresDetalhes";
            this.Text = "FormEntidadeJogadoresDetalhes";
            this.Load += new System.EventHandler(this.FormEntidadeJogadoresDetalhes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNomeJogador;
        private System.Windows.Forms.Label labelAlturaJogador;
        private System.Windows.Forms.Label labelIdadeJogador;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPosicao;
        private System.Windows.Forms.TextBox textBoxPosicao;
        private System.Windows.Forms.Label labelEquipa;
        private System.Windows.Forms.ComboBox comboBoxEquipa;
    }
}
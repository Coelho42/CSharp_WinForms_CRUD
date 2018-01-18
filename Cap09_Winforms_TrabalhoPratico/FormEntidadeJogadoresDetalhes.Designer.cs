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
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNomeJogador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIdadeJogador = new System.Windows.Forms.Label();
            this.buttonAction = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(340, 328);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(235, 41);
            this.textBoxIdade.TabIndex = 9;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(340, 219);
            this.textBoxAltura.Multiline = true;
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(235, 41);
            this.textBoxAltura.TabIndex = 8;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(340, 109);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(235, 41);
            this.textBoxNome.TabIndex = 7;
            // 
            // labelNomeJogador
            // 
            this.labelNomeJogador.AutoSize = true;
            this.labelNomeJogador.Location = new System.Drawing.Point(285, 109);
            this.labelNomeJogador.Name = "labelNomeJogador";
            this.labelNomeJogador.Size = new System.Drawing.Size(49, 17);
            this.labelNomeJogador.TabIndex = 11;
            this.labelNomeJogador.Text = "Nome:";
            this.labelNomeJogador.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Altura:";
            // 
            // labelIdadeJogador
            // 
            this.labelIdadeJogador.AutoSize = true;
            this.labelIdadeJogador.Location = new System.Drawing.Point(291, 328);
            this.labelIdadeJogador.Name = "labelIdadeJogador";
            this.labelIdadeJogador.Size = new System.Drawing.Size(47, 17);
            this.labelIdadeJogador.TabIndex = 13;
            this.labelIdadeJogador.Text = "Idade:";
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(340, 418);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(101, 45);
            this.buttonAction.TabIndex = 14;
            this.buttonAction.Text = "Adicionar";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(474, 418);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 45);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormEntidadeJogadoresDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 537);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelIdadeJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNomeJogador);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormEntidadeJogadoresDetalhes";
            this.Text = "FormEntidadeJogadoresDetalhes";
            this.Load += new System.EventHandler(this.FormEntidadeJogadoresDetalhes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNomeJogador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIdadeJogador;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Button buttonCancel;
    }
}
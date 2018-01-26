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
            this.SuspendLayout();
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(61, 232);
            this.textBoxAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAltura.Multiline = true;
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(177, 34);
            this.textBoxAltura.TabIndex = 9;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(61, 143);
            this.textBoxIdade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(177, 34);
            this.textBoxIdade.TabIndex = 8;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(61, 54);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(177, 34);
            this.textBoxNome.TabIndex = 7;
            // 
            // labelNomeJogador
            // 
            this.labelNomeJogador.AutoSize = true;
            this.labelNomeJogador.Location = new System.Drawing.Point(20, 54);
            this.labelNomeJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeJogador.Name = "labelNomeJogador";
            this.labelNomeJogador.Size = new System.Drawing.Size(38, 13);
            this.labelNomeJogador.TabIndex = 11;
            this.labelNomeJogador.Text = "Nome:";
            // 
            // labelAlturaJogador
            // 
            this.labelAlturaJogador.AutoSize = true;
            this.labelAlturaJogador.Location = new System.Drawing.Point(20, 232);
            this.labelAlturaJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlturaJogador.Name = "labelAlturaJogador";
            this.labelAlturaJogador.Size = new System.Drawing.Size(37, 13);
            this.labelAlturaJogador.TabIndex = 12;
            this.labelAlturaJogador.Text = "Altura:";
            // 
            // labelIdadeJogador
            // 
            this.labelIdadeJogador.AutoSize = true;
            this.labelIdadeJogador.Location = new System.Drawing.Point(20, 143);
            this.labelIdadeJogador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdadeJogador.Name = "labelIdadeJogador";
            this.labelIdadeJogador.Size = new System.Drawing.Size(37, 13);
            this.labelIdadeJogador.TabIndex = 13;
            this.labelIdadeJogador.Text = "Idade:";
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(61, 305);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(76, 37);
            this.buttonAction.TabIndex = 14;
            this.buttonAction.Text = "\"Custom\"";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(161, 305);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 37);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEntidadeJogadoresDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 371);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelIdadeJogador);
            this.Controls.Add(this.labelAlturaJogador);
            this.Controls.Add(this.labelNomeJogador);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}
namespace Cap09_Winforms_TrabalhoPratico
{
    partial class FormEntidadeTreinadoresDetalhes
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.labelIdadeTreinador = new System.Windows.Forms.Label();
            this.labelEquipaTreinador = new System.Windows.Forms.Label();
            this.labelNomeTreinador = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.comboBoxEquipa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(174, 208);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 37);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(73, 208);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(76, 37);
            this.buttonAction.TabIndex = 22;
            this.buttonAction.Text = "\"Custom\"";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // labelIdadeTreinador
            // 
            this.labelIdadeTreinador.AutoSize = true;
            this.labelIdadeTreinador.Location = new System.Drawing.Point(33, 67);
            this.labelIdadeTreinador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdadeTreinador.Name = "labelIdadeTreinador";
            this.labelIdadeTreinador.Size = new System.Drawing.Size(37, 13);
            this.labelIdadeTreinador.TabIndex = 21;
            this.labelIdadeTreinador.Text = "Idade:";
            // 
            // labelEquipaTreinador
            // 
            this.labelEquipaTreinador.AutoSize = true;
            this.labelEquipaTreinador.Location = new System.Drawing.Point(26, 182);
            this.labelEquipaTreinador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipaTreinador.Name = "labelEquipaTreinador";
            this.labelEquipaTreinador.Size = new System.Drawing.Size(43, 13);
            this.labelEquipaTreinador.TabIndex = 20;
            this.labelEquipaTreinador.Text = "Equipa:";
            // 
            // labelNomeTreinador
            // 
            this.labelNomeTreinador.AutoSize = true;
            this.labelNomeTreinador.Location = new System.Drawing.Point(32, 29);
            this.labelNomeTreinador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeTreinador.Name = "labelNomeTreinador";
            this.labelNomeTreinador.Size = new System.Drawing.Size(38, 13);
            this.labelNomeTreinador.TabIndex = 19;
            this.labelNomeTreinador.Text = "Nome:";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(73, 67);
            this.textBoxIdade.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(177, 34);
            this.textBoxIdade.TabIndex = 18;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(73, 29);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(177, 34);
            this.textBoxNome.TabIndex = 16;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(14, 143);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(55, 13);
            this.labelCategoria.TabIndex = 27;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(32, 105);
            this.labelAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(37, 13);
            this.labelAltura.TabIndex = 26;
            this.labelAltura.Text = "Altura:";
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(73, 143);
            this.textBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCategoria.Multiline = true;
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(177, 34);
            this.textBoxCategoria.TabIndex = 25;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(73, 105);
            this.textBoxAltura.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAltura.Multiline = true;
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(177, 34);
            this.textBoxAltura.TabIndex = 24;
            // 
            // comboBoxEquipa
            // 
            this.comboBoxEquipa.FormattingEnabled = true;
            this.comboBoxEquipa.Location = new System.Drawing.Point(73, 182);
            this.comboBoxEquipa.Name = "comboBoxEquipa";
            this.comboBoxEquipa.Size = new System.Drawing.Size(177, 21);
            this.comboBoxEquipa.TabIndex = 28;
            // 
            // FormEntidadeTreinadoresDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 259);
            this.Controls.Add(this.comboBoxEquipa);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelIdadeTreinador);
            this.Controls.Add(this.labelEquipaTreinador);
            this.Controls.Add(this.labelNomeTreinador);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEntidadeTreinadoresDetalhes";
            this.Text = "FormEntidadeTreinadoresDetalhes";
            this.Load += new System.EventHandler(this.FormEntidadeTreinadoresDetalhes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label labelIdadeTreinador;
        private System.Windows.Forms.Label labelEquipaTreinador;
        private System.Windows.Forms.Label labelNomeTreinador;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.ComboBox comboBoxEquipa;
    }
}
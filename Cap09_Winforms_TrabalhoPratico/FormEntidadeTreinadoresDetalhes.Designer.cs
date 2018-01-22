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
            this.textBoxEquipa = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(394, 382);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 45);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(260, 382);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(101, 45);
            this.buttonAction.TabIndex = 22;
            this.buttonAction.Text = "\"Custom\"";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // labelIdadeTreinador
            // 
            this.labelIdadeTreinador.AutoSize = true;
            this.labelIdadeTreinador.Location = new System.Drawing.Point(207, 184);
            this.labelIdadeTreinador.Name = "labelIdadeTreinador";
            this.labelIdadeTreinador.Size = new System.Drawing.Size(47, 17);
            this.labelIdadeTreinador.TabIndex = 21;
            this.labelIdadeTreinador.Text = "Idade:";
            // 
            // labelEquipaTreinador
            // 
            this.labelEquipaTreinador.AutoSize = true;
            this.labelEquipaTreinador.Location = new System.Drawing.Point(162, 289);
            this.labelEquipaTreinador.Name = "labelEquipaTreinador";
            this.labelEquipaTreinador.Size = new System.Drawing.Size(92, 17);
            this.labelEquipaTreinador.TabIndex = 20;
            this.labelEquipaTreinador.Text = "Tem Equipa?";
            // 
            // labelNomeTreinador
            // 
            this.labelNomeTreinador.AutoSize = true;
            this.labelNomeTreinador.Location = new System.Drawing.Point(205, 73);
            this.labelNomeTreinador.Name = "labelNomeTreinador";
            this.labelNomeTreinador.Size = new System.Drawing.Size(49, 17);
            this.labelNomeTreinador.TabIndex = 19;
            this.labelNomeTreinador.Text = "Nome:";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(260, 184);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(235, 41);
            this.textBoxIdade.TabIndex = 18;
            // 
            // textBoxEquipa
            // 
            this.textBoxEquipa.Location = new System.Drawing.Point(260, 289);
            this.textBoxEquipa.Multiline = true;
            this.textBoxEquipa.Name = "textBoxEquipa";
            this.textBoxEquipa.Size = new System.Drawing.Size(235, 41);
            this.textBoxEquipa.TabIndex = 17;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(260, 73);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(235, 41);
            this.textBoxNome.TabIndex = 16;
            // 
            // FormEntidadeTreinadoresDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 475);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelIdadeTreinador);
            this.Controls.Add(this.labelEquipaTreinador);
            this.Controls.Add(this.labelNomeTreinador);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxEquipa);
            this.Controls.Add(this.textBoxNome);
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
        private System.Windows.Forms.TextBox textBoxEquipa;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}
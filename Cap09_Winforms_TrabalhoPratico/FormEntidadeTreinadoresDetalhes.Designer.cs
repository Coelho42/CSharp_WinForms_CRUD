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
            this.buttonCancel.Location = new System.Drawing.Point(178, 324);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 37);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(77, 324);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.labelIdadeTreinador.Location = new System.Drawing.Point(37, 164);
            this.labelIdadeTreinador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdadeTreinador.Name = "labelIdadeTreinador";
            this.labelIdadeTreinador.Size = new System.Drawing.Size(37, 13);
            this.labelIdadeTreinador.TabIndex = 21;
            this.labelIdadeTreinador.Text = "Idade:";
            // 
            // labelEquipaTreinador
            // 
            this.labelEquipaTreinador.AutoSize = true;
            this.labelEquipaTreinador.Location = new System.Drawing.Point(4, 249);
            this.labelEquipaTreinador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipaTreinador.Name = "labelEquipaTreinador";
            this.labelEquipaTreinador.Size = new System.Drawing.Size(70, 13);
            this.labelEquipaTreinador.TabIndex = 20;
            this.labelEquipaTreinador.Text = "Tem Equipa?";
            // 
            // labelNomeTreinador
            // 
            this.labelNomeTreinador.AutoSize = true;
            this.labelNomeTreinador.Location = new System.Drawing.Point(36, 73);
            this.labelNomeTreinador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeTreinador.Name = "labelNomeTreinador";
            this.labelNomeTreinador.Size = new System.Drawing.Size(38, 13);
            this.labelNomeTreinador.TabIndex = 19;
            this.labelNomeTreinador.Text = "Nome:";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(77, 164);
            this.textBoxIdade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(177, 34);
            this.textBoxIdade.TabIndex = 18;
            // 
            // textBoxEquipa
            // 
            this.textBoxEquipa.Location = new System.Drawing.Point(77, 249);
            this.textBoxEquipa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEquipa.Multiline = true;
            this.textBoxEquipa.Name = "textBoxEquipa";
            this.textBoxEquipa.Size = new System.Drawing.Size(177, 34);
            this.textBoxEquipa.TabIndex = 17;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(77, 73);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(177, 34);
            this.textBoxNome.TabIndex = 16;
            // 
            // FormEntidadeTreinadoresDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 386);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelIdadeTreinador);
            this.Controls.Add(this.labelEquipaTreinador);
            this.Controls.Add(this.labelNomeTreinador);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxEquipa);
            this.Controls.Add(this.textBoxNome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
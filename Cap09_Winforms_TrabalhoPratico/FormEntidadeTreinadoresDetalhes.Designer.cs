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
            this.labelAlturaTreinador = new System.Windows.Forms.Label();
            this.labelNomeTreinador = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 374);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 45);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(261, 374);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(101, 45);
            this.buttonAction.TabIndex = 22;
            this.buttonAction.Text = "Varia";
            this.buttonAction.UseVisualStyleBackColor = true;
            // 
            // labelIdadeTreinador
            // 
            this.labelIdadeTreinador.AutoSize = true;
            this.labelIdadeTreinador.Location = new System.Drawing.Point(208, 284);
            this.labelIdadeTreinador.Name = "labelIdadeTreinador";
            this.labelIdadeTreinador.Size = new System.Drawing.Size(47, 17);
            this.labelIdadeTreinador.TabIndex = 21;
            this.labelIdadeTreinador.Text = "Idade:";
            // 
            // labelAlturaTreinador
            // 
            this.labelAlturaTreinador.AutoSize = true;
            this.labelAlturaTreinador.Location = new System.Drawing.Point(206, 175);
            this.labelAlturaTreinador.Name = "labelAlturaTreinador";
            this.labelAlturaTreinador.Size = new System.Drawing.Size(49, 17);
            this.labelAlturaTreinador.TabIndex = 20;
            this.labelAlturaTreinador.Text = "Altura:";
            // 
            // labelNomeTreinador
            // 
            this.labelNomeTreinador.AutoSize = true;
            this.labelNomeTreinador.Location = new System.Drawing.Point(206, 65);
            this.labelNomeTreinador.Name = "labelNomeTreinador";
            this.labelNomeTreinador.Size = new System.Drawing.Size(49, 17);
            this.labelNomeTreinador.TabIndex = 19;
            this.labelNomeTreinador.Text = "Nome:";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(261, 284);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(235, 41);
            this.textBoxIdade.TabIndex = 18;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(261, 175);
            this.textBoxAltura.Multiline = true;
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(235, 41);
            this.textBoxAltura.TabIndex = 17;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(261, 65);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(235, 41);
            this.textBoxNome.TabIndex = 16;
            // 
            // FormEntidadeTreinadoresDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 481);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelIdadeTreinador);
            this.Controls.Add(this.labelAlturaTreinador);
            this.Controls.Add(this.labelNomeTreinador);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormEntidadeTreinadoresDetalhes";
            this.Text = "FormEntidadeTreinadoresDetalhes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label labelIdadeTreinador;
        private System.Windows.Forms.Label labelAlturaTreinador;
        private System.Windows.Forms.Label labelNomeTreinador;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}
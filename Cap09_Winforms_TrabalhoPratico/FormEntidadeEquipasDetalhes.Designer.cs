namespace Cap09_Winforms_TrabalhoPratico
{
    partial class FormEntidadeEquipasDetalhes
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
            this.labelEquipaLugar = new System.Windows.Forms.Label();
            this.labelEquipaConvocada = new System.Windows.Forms.Label();
            this.labelNomeEquipas = new System.Windows.Forms.Label();
            this.textBoxLugar = new System.Windows.Forms.TextBox();
            this.textBoxConvocada = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(398, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 45);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(264, 363);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(101, 45);
            this.buttonAction.TabIndex = 30;
            this.buttonAction.Text = "Varia";
            this.buttonAction.UseVisualStyleBackColor = true;
            // 
            // labelEquipaLugar
            // 
            this.labelEquipaLugar.AutoSize = true;
            this.labelEquipaLugar.Location = new System.Drawing.Point(209, 284);
            this.labelEquipaLugar.Name = "labelEquipaLugar";
            this.labelEquipaLugar.Size = new System.Drawing.Size(49, 17);
            this.labelEquipaLugar.TabIndex = 29;
            this.labelEquipaLugar.Text = "Lugar:";
            // 
            // labelEquipaConvocada
            // 
            this.labelEquipaConvocada.AutoSize = true;
            this.labelEquipaConvocada.Location = new System.Drawing.Point(175, 172);
            this.labelEquipaConvocada.Name = "labelEquipaConvocada";
            this.labelEquipaConvocada.Size = new System.Drawing.Size(83, 17);
            this.labelEquipaConvocada.TabIndex = 28;
            this.labelEquipaConvocada.Text = "Convocada:";
            this.labelEquipaConvocada.Click += new System.EventHandler(this.labelEquipaConvocada_Click);
            // 
            // labelNomeEquipas
            // 
            this.labelNomeEquipas.AutoSize = true;
            this.labelNomeEquipas.Location = new System.Drawing.Point(209, 65);
            this.labelNomeEquipas.Name = "labelNomeEquipas";
            this.labelNomeEquipas.Size = new System.Drawing.Size(49, 17);
            this.labelNomeEquipas.TabIndex = 27;
            this.labelNomeEquipas.Text = "Nome:";
            // 
            // textBoxLugar
            // 
            this.textBoxLugar.Location = new System.Drawing.Point(264, 284);
            this.textBoxLugar.Multiline = true;
            this.textBoxLugar.Name = "textBoxLugar";
            this.textBoxLugar.Size = new System.Drawing.Size(235, 41);
            this.textBoxLugar.TabIndex = 26;
            // 
            // textBoxConvocada
            // 
            this.textBoxConvocada.Location = new System.Drawing.Point(264, 172);
            this.textBoxConvocada.Multiline = true;
            this.textBoxConvocada.Name = "textBoxConvocada";
            this.textBoxConvocada.Size = new System.Drawing.Size(235, 41);
            this.textBoxConvocada.TabIndex = 25;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(264, 65);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(235, 41);
            this.textBoxNome.TabIndex = 24;
            // 
            // FormEntidadeEquipasDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 475);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelEquipaLugar);
            this.Controls.Add(this.labelEquipaConvocada);
            this.Controls.Add(this.labelNomeEquipas);
            this.Controls.Add(this.textBoxLugar);
            this.Controls.Add(this.textBoxConvocada);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormEntidadeEquipasDetalhes";
            this.Text = "FormEntidadeEquipasDetalhes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label labelEquipaLugar;
        private System.Windows.Forms.Label labelEquipaConvocada;
        private System.Windows.Forms.Label labelNomeEquipas;
        private System.Windows.Forms.TextBox textBoxLugar;
        private System.Windows.Forms.TextBox textBoxConvocada;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}
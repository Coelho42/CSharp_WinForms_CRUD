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
            this.labelEquipaLiga = new System.Windows.Forms.Label();
            this.labelEquipaConvocada = new System.Windows.Forms.Label();
            this.labelNomeEquipas = new System.Windows.Forms.Label();
            this.textBoxLiga = new System.Windows.Forms.TextBox();
            this.textBoxConvocada = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(392, 363);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 46);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(259, 363);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(101, 46);
            this.buttonAction.TabIndex = 30;
            this.buttonAction.Text = "\"Custom\"";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // labelEquipaLiga
            // 
            this.labelEquipaLiga.AutoSize = true;
            this.labelEquipaLiga.Location = new System.Drawing.Point(204, 284);
            this.labelEquipaLiga.Name = "labelEquipaLiga";
            this.labelEquipaLiga.Size = new System.Drawing.Size(39, 17);
            this.labelEquipaLiga.TabIndex = 29;
            this.labelEquipaLiga.Text = "Liga:";
            // 
            // labelEquipaConvocada
            // 
            this.labelEquipaConvocada.AutoSize = true;
            this.labelEquipaConvocada.Location = new System.Drawing.Point(170, 172);
            this.labelEquipaConvocada.Name = "labelEquipaConvocada";
            this.labelEquipaConvocada.Size = new System.Drawing.Size(83, 17);
            this.labelEquipaConvocada.TabIndex = 28;
            this.labelEquipaConvocada.Text = "Convocada:";
            // 
            // labelNomeEquipas
            // 
            this.labelNomeEquipas.AutoSize = true;
            this.labelNomeEquipas.Location = new System.Drawing.Point(204, 65);
            this.labelNomeEquipas.Name = "labelNomeEquipas";
            this.labelNomeEquipas.Size = new System.Drawing.Size(49, 17);
            this.labelNomeEquipas.TabIndex = 27;
            this.labelNomeEquipas.Text = "Nome:";
            // 
            // textBoxLiga
            // 
            this.textBoxLiga.Location = new System.Drawing.Point(259, 284);
            this.textBoxLiga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLiga.Multiline = true;
            this.textBoxLiga.Name = "textBoxLiga";
            this.textBoxLiga.Size = new System.Drawing.Size(235, 41);
            this.textBoxLiga.TabIndex = 26;
            // 
            // textBoxConvocada
            // 
            this.textBoxConvocada.Location = new System.Drawing.Point(259, 172);
            this.textBoxConvocada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxConvocada.Multiline = true;
            this.textBoxConvocada.Name = "textBoxConvocada";
            this.textBoxConvocada.Size = new System.Drawing.Size(235, 41);
            this.textBoxConvocada.TabIndex = 25;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(259, 65);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.Controls.Add(this.labelEquipaLiga);
            this.Controls.Add(this.labelEquipaConvocada);
            this.Controls.Add(this.labelNomeEquipas);
            this.Controls.Add(this.textBoxLiga);
            this.Controls.Add(this.textBoxConvocada);
            this.Controls.Add(this.textBoxNome);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEntidadeEquipasDetalhes";
            this.Text = "FormEntidadeEquipasDetalhes";
            this.Load += new System.EventHandler(this.FormEntidadeEquipasDetalhes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Label labelEquipaLiga;
        private System.Windows.Forms.Label labelEquipaConvocada;
        private System.Windows.Forms.Label labelNomeEquipas;
        private System.Windows.Forms.TextBox textBoxLiga;
        private System.Windows.Forms.TextBox textBoxConvocada;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}
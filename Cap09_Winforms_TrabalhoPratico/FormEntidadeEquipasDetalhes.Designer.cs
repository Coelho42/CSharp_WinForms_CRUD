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
            this.buttonCancel.Location = new System.Drawing.Point(180, 140);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(76, 37);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(80, 140);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(76, 37);
            this.buttonAction.TabIndex = 30;
            this.buttonAction.Text = "\"Custom\"";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // labelEquipaLiga
            // 
            this.labelEquipaLiga.AutoSize = true;
            this.labelEquipaLiga.Location = new System.Drawing.Point(38, 102);
            this.labelEquipaLiga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipaLiga.Name = "labelEquipaLiga";
            this.labelEquipaLiga.Size = new System.Drawing.Size(30, 13);
            this.labelEquipaLiga.TabIndex = 29;
            this.labelEquipaLiga.Text = "Liga:";
            // 
            // labelEquipaConvocada
            // 
            this.labelEquipaConvocada.AutoSize = true;
            this.labelEquipaConvocada.Location = new System.Drawing.Point(13, 64);
            this.labelEquipaConvocada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipaConvocada.Name = "labelEquipaConvocada";
            this.labelEquipaConvocada.Size = new System.Drawing.Size(65, 13);
            this.labelEquipaConvocada.TabIndex = 28;
            this.labelEquipaConvocada.Text = "Convocada:";
            // 
            // labelNomeEquipas
            // 
            this.labelNomeEquipas.AutoSize = true;
            this.labelNomeEquipas.Location = new System.Drawing.Point(38, 26);
            this.labelNomeEquipas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeEquipas.Name = "labelNomeEquipas";
            this.labelNomeEquipas.Size = new System.Drawing.Size(38, 13);
            this.labelNomeEquipas.TabIndex = 27;
            this.labelNomeEquipas.Text = "Nome:";
            // 
            // textBoxLiga
            // 
            this.textBoxLiga.Location = new System.Drawing.Point(79, 102);
            this.textBoxLiga.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLiga.Multiline = true;
            this.textBoxLiga.Name = "textBoxLiga";
            this.textBoxLiga.Size = new System.Drawing.Size(177, 34);
            this.textBoxLiga.TabIndex = 26;
            // 
            // textBoxConvocada
            // 
            this.textBoxConvocada.Location = new System.Drawing.Point(79, 64);
            this.textBoxConvocada.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConvocada.Multiline = true;
            this.textBoxConvocada.Name = "textBoxConvocada";
            this.textBoxConvocada.Size = new System.Drawing.Size(177, 34);
            this.textBoxConvocada.TabIndex = 25;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(79, 26);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(177, 34);
            this.textBoxNome.TabIndex = 24;
            // 
            // FormEntidadeEquipasDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 196);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.labelEquipaLiga);
            this.Controls.Add(this.labelEquipaConvocada);
            this.Controls.Add(this.labelNomeEquipas);
            this.Controls.Add(this.textBoxLiga);
            this.Controls.Add(this.textBoxConvocada);
            this.Controls.Add(this.textBoxNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
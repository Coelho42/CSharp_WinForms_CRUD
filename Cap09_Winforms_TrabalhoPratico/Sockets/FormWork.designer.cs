namespace Cap09_Winforms_TrabalhoPratico.Sockets
{
    partial class FormWork
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsMale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.buttonEquipas = new System.Windows.Forms.Button();
            this.buttonJogadores = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmAge,
            this.clmIsMale});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(322, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(368, 220);
            this.dataGridView.TabIndex = 2;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nome";
            this.clmName.MaxInputLength = 20;
            this.clmName.Name = "clmName";
            this.clmName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmName.Width = 160;
            // 
            // clmAge
            // 
            this.clmAge.HeaderText = "Idade";
            this.clmAge.MaxInputLength = 2;
            this.clmAge.Name = "clmAge";
            this.clmAge.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmIsMale
            // 
            this.clmIsMale.HeaderText = "Macho";
            this.clmIsMale.MaxInputLength = 5;
            this.clmIsMale.Name = "clmIsMale";
            this.clmIsMale.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(206, 31);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(83, 20);
            this.textBoxIPAddress.TabIndex = 22;
            this.textBoxIPAddress.Text = "127.0.0.1";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(206, 12);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(17, 13);
            this.labelIP.TabIndex = 21;
            this.labelIP.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 11);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(106, 40);
            this.buttonConnect.TabIndex = 20;
            this.buttonConnect.Text = "Ligar";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionState.ForeColor = System.Drawing.Color.DarkRed;
            this.labelConnectionState.Location = new System.Drawing.Point(124, 10);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(76, 41);
            this.labelConnectionState.TabIndex = 30;
            this.labelConnectionState.Text = "OFF";
            this.labelConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelConnectionState.Click += new System.EventHandler(this.labelConnectionState_Click);
            // 
            // buttonEquipas
            // 
            this.buttonEquipas.Location = new System.Drawing.Point(12, 85);
            this.buttonEquipas.Name = "buttonEquipas";
            this.buttonEquipas.Size = new System.Drawing.Size(277, 45);
            this.buttonEquipas.TabIndex = 31;
            this.buttonEquipas.Text = "Equipas";
            this.buttonEquipas.UseVisualStyleBackColor = true;
            // 
            // buttonJogadores
            // 
            this.buttonJogadores.Location = new System.Drawing.Point(12, 136);
            this.buttonJogadores.Name = "buttonJogadores";
            this.buttonJogadores.Size = new System.Drawing.Size(277, 45);
            this.buttonJogadores.TabIndex = 32;
            this.buttonJogadores.Text = "Jogadores";
            this.buttonJogadores.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 45);
            this.button3.TabIndex = 33;
            this.button3.Text = "Treinadores";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(704, 248);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonJogadores);
            this.Controls.Add(this.buttonEquipas);
            this.Controls.Add(this.labelConnectionState);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxIPAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormWork";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsMale;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelConnectionState;
        private System.Windows.Forms.Button buttonEquipas;
        private System.Windows.Forms.Button buttonJogadores;
        private System.Windows.Forms.Button button3;
    }
}


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
            this.dataGridViewEquipas = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsMale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.buttonEquipas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEquipas
            // 
            this.dataGridViewEquipas.AllowUserToAddRows = false;
            this.dataGridViewEquipas.AllowUserToDeleteRows = false;
            this.dataGridViewEquipas.AllowUserToOrderColumns = true;
            this.dataGridViewEquipas.AllowUserToResizeRows = false;
            this.dataGridViewEquipas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmAge,
            this.clmIsMale});
            this.dataGridViewEquipas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEquipas.Location = new System.Drawing.Point(16, 130);
            this.dataGridViewEquipas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEquipas.Name = "dataGridViewEquipas";
            this.dataGridViewEquipas.RowHeadersVisible = false;
            this.dataGridViewEquipas.Size = new System.Drawing.Size(365, 271);
            this.dataGridViewEquipas.TabIndex = 2;
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
            this.clmAge.HeaderText = "Convocada";
            this.clmAge.MaxInputLength = 2;
            this.clmAge.Name = "clmAge";
            this.clmAge.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmIsMale
            // 
            this.clmIsMale.HeaderText = "Liga";
            this.clmIsMale.MaxInputLength = 5;
            this.clmIsMale.Name = "clmIsMale";
            this.clmIsMale.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(272, 41);
            this.textBoxIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(109, 22);
            this.textBoxIPAddress.TabIndex = 22;
            this.textBoxIPAddress.Text = "127.0.0.1";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(272, 17);
            this.labelIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(20, 17);
            this.labelIP.TabIndex = 21;
            this.labelIP.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(16, 14);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(141, 49);
            this.buttonConnect.TabIndex = 20;
            this.buttonConnect.Text = "Ligar";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionState.ForeColor = System.Drawing.Color.DarkRed;
            this.labelConnectionState.Location = new System.Drawing.Point(163, 12);
            this.labelConnectionState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(101, 50);
            this.labelConnectionState.TabIndex = 30;
            this.labelConnectionState.Text = "OFF";
            this.labelConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEquipas
            // 
            this.buttonEquipas.Location = new System.Drawing.Point(16, 67);
            this.buttonEquipas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEquipas.Name = "buttonEquipas";
            this.buttonEquipas.Size = new System.Drawing.Size(365, 55);
            this.buttonEquipas.TabIndex = 31;
            this.buttonEquipas.Text = "Equipas";
            this.buttonEquipas.UseVisualStyleBackColor = true;
            this.buttonEquipas.Click += new System.EventHandler(this.buttonEquipas_Click);
            // 
            // FormWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(399, 414);
            this.Controls.Add(this.buttonEquipas);
            this.Controls.Add(this.labelConnectionState);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.dataGridViewEquipas);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textBoxIPAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormWork";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridViewEquipas;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelConnectionState;
        private System.Windows.Forms.Button buttonEquipas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsMale;
    }
}


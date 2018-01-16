namespace Cap09_Winforms_TrabalhoPratico
{
    partial class Form1
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1204, 100);
            this.panelTitle.TabIndex = 0;
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.Controls.Add(this.button5);
            this.panelOpcoes.Controls.Add(this.button4);
            this.panelOpcoes.Controls.Add(this.button3);
            this.panelOpcoes.Controls.Add(this.button2);
            this.panelOpcoes.Controls.Add(this.button1);
            this.panelOpcoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpcoes.Location = new System.Drawing.Point(0, 100);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(1204, 631);
            this.panelOpcoes.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(602, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jogadores";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(602, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Treinadores";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(602, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Equipas";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(602, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(341, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(602, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "Acerca de:";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 731);
            this.Controls.Add(this.panelOpcoes);
            this.Controls.Add(this.panelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}


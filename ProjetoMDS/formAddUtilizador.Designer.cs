namespace ProjetoMDS
{
    partial class formAddUtilizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddUtilizador));
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.dtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtHoraSaida = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(106, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(174, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(106, 45);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(174, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo Utilizador:";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Médico",
            "Rececionista",
            "Administrador"});
            this.cbTipo.Location = new System.Drawing.Point(106, 71);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(174, 21);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 242);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar Utilizador";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtHoraSaida);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtHoraEntrada);
            this.groupBox2.Controls.Add(this.cbEspecialidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 107);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes de Médico";
            this.groupBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Especialidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hora de Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hora de Saída:";
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Items.AddRange(new object[] {
            "Pediatria",
            "Dermatologia",
            "Cardiologia",
            "Radiografia",
            "Infectologia"});
            this.cbEspecialidade.Location = new System.Drawing.Point(100, 19);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(174, 21);
            this.cbEspecialidade.TabIndex = 3;
            // 
            // dtHoraEntrada
            // 
            this.dtHoraEntrada.CustomFormat = "HH:mm";
            this.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraEntrada.Location = new System.Drawing.Point(100, 46);
            this.dtHoraEntrada.Name = "dtHoraEntrada";
            this.dtHoraEntrada.ShowUpDown = true;
            this.dtHoraEntrada.Size = new System.Drawing.Size(174, 20);
            this.dtHoraEntrada.TabIndex = 4;
            // 
            // dtHoraSaida
            // 
            this.dtHoraSaida.CustomFormat = "HH:mm";
            this.dtHoraSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHoraSaida.Location = new System.Drawing.Point(100, 72);
            this.dtHoraSaida.Name = "dtHoraSaida";
            this.dtHoraSaida.ShowUpDown = true;
            this.dtHoraSaida.Size = new System.Drawing.Size(174, 20);
            this.dtHoraSaida.TabIndex = 5;
            // 
            // formAddUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 263);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAddUtilizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Utilizador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtHoraSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtHoraEntrada;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
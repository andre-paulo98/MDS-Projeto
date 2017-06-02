namespace ProjetoMDS {
    partial class formAddPaciente {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddPaciente));
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.tb_nacionalidade = new System.Windows.Forms.TextBox();
            this.dp_data_nasc = new System.Windows.Forms.DateTimePicker();
            this.tb_codposta = new System.Windows.Forms.MaskedTextBox();
            this.tb_nif = new System.Windows.Forms.MaskedTextBox();
            this.tb_cc = new System.Windows.Forms.MaskedTextBox();
            this.tb_sns = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_avatar
            // 
            this.pb_avatar.ErrorImage = null;
            this.pb_avatar.InitialImage = null;
            this.pb_avatar.Location = new System.Drawing.Point(12, 12);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(123, 122);
            this.pb_avatar.TabIndex = 0;
            this.pb_avatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Morada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo Postal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nacionalidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "NIF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nº do CC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nº do SNS";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(12, 253);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(123, 23);
            this.bt_cancelar.TabIndex = 9;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Location = new System.Drawing.Point(378, 253);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(126, 23);
            this.bt_guardar.TabIndex = 10;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(200, 9);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(304, 20);
            this.tb_nome.TabIndex = 11;
            // 
            // tb_morada
            // 
            this.tb_morada.Location = new System.Drawing.Point(200, 61);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(304, 20);
            this.tb_morada.TabIndex = 13;
            // 
            // tb_nacionalidade
            // 
            this.tb_nacionalidade.Location = new System.Drawing.Point(234, 118);
            this.tb_nacionalidade.Name = "tb_nacionalidade";
            this.tb_nacionalidade.Size = new System.Drawing.Size(270, 20);
            this.tb_nacionalidade.TabIndex = 15;
            // 
            // dp_data_nasc
            // 
            this.dp_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_data_nasc.Location = new System.Drawing.Point(266, 35);
            this.dp_data_nasc.Name = "dp_data_nasc";
            this.dp_data_nasc.Size = new System.Drawing.Size(86, 20);
            this.dp_data_nasc.TabIndex = 17;
            // 
            // tb_codposta
            // 
            this.tb_codposta.Location = new System.Drawing.Point(234, 91);
            this.tb_codposta.Mask = "0000-999";
            this.tb_codposta.Name = "tb_codposta";
            this.tb_codposta.Size = new System.Drawing.Size(54, 20);
            this.tb_codposta.TabIndex = 18;
            // 
            // tb_nif
            // 
            this.tb_nif.Location = new System.Drawing.Point(78, 155);
            this.tb_nif.Mask = "000000000";
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(69, 20);
            this.tb_nif.TabIndex = 19;
            // 
            // tb_cc
            // 
            this.tb_cc.Location = new System.Drawing.Point(78, 181);
            this.tb_cc.Mask = "000000000";
            this.tb_cc.Name = "tb_cc";
            this.tb_cc.Size = new System.Drawing.Size(69, 20);
            this.tb_cc.TabIndex = 20;
            // 
            // tb_sns
            // 
            this.tb_sns.Location = new System.Drawing.Point(78, 207);
            this.tb_sns.Mask = "000000000";
            this.tb_sns.Name = "tb_sns";
            this.tb_sns.Size = new System.Drawing.Size(69, 20);
            this.tb_sns.TabIndex = 21;
            // 
            // formAddPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 290);
            this.Controls.Add(this.tb_sns);
            this.Controls.Add(this.tb_cc);
            this.Controls.Add(this.tb_nif);
            this.Controls.Add(this.tb_codposta);
            this.Controls.Add(this.dp_data_nasc);
            this.Controls.Add(this.tb_nacionalidade);
            this.Controls.Add(this.tb_morada);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_avatar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAddPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.TextBox tb_nacionalidade;
        private System.Windows.Forms.DateTimePicker dp_data_nasc;
        private System.Windows.Forms.MaskedTextBox tb_codposta;
        private System.Windows.Forms.MaskedTextBox tb_nif;
        private System.Windows.Forms.MaskedTextBox tb_cc;
        private System.Windows.Forms.MaskedTextBox tb_sns;
    }
}
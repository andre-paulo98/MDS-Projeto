namespace ProjetoMDS {
    partial class formListaPacientes {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n_sns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bt_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.n_cc,
            this.n_sns,
            this.ativo});
            this.dataGridView1.Location = new System.Drawing.Point(30, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.Frozen = true;
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // n_cc
            // 
            this.n_cc.Frozen = true;
            this.n_cc.HeaderText = "Nº CC";
            this.n_cc.Name = "n_cc";
            this.n_cc.ReadOnly = true;
            // 
            // n_sns
            // 
            this.n_sns.Frozen = true;
            this.n_sns.HeaderText = "Nº SNS";
            this.n_sns.Name = "n_sns";
            this.n_sns.ReadOnly = true;
            // 
            // ativo
            // 
            this.ativo.Frozen = true;
            this.ativo.HeaderText = "Ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(30, 457);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(118, 30);
            this.bt_novo.TabIndex = 1;
            this.bt_novo.Text = "Novo Paciente";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // formListaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 499);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formListaPacientes";
            this.Text = "formListaPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn n_sns;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativo;
        private System.Windows.Forms.Button bt_novo;
    }
}
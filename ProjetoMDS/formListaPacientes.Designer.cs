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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formListaPacientes));
            this.dgv_pacientes = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_shs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pacientes
            // 
            this.dgv_pacientes.AllowUserToAddRows = false;
            this.dgv_pacientes.AllowUserToDeleteRows = false;
            this.dgv_pacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_pacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.N_cc,
            this.N_shs});
            this.dgv_pacientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_pacientes.Location = new System.Drawing.Point(30, 29);
            this.dgv_pacientes.MultiSelect = false;
            this.dgv_pacientes.Name = "dgv_pacientes";
            this.dgv_pacientes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pacientes.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pacientes.Size = new System.Drawing.Size(520, 412);
            this.dgv_pacientes.TabIndex = 0;
            this.dgv_pacientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pacientes_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // N_cc
            // 
            this.N_cc.DataPropertyName = "N_cc";
            this.N_cc.HeaderText = "Nº de Cartão do Cidadão";
            this.N_cc.Name = "N_cc";
            this.N_cc.ReadOnly = true;
            // 
            // N_shs
            // 
            this.N_shs.DataPropertyName = "N_sns";
            this.N_shs.HeaderText = "Nº do Serviço Nacional de Saude";
            this.N_shs.Name = "N_shs";
            this.N_shs.ReadOnly = true;
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
            this.Controls.Add(this.dgv_pacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formListaPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_shs;
        private System.Windows.Forms.DataGridView dgv_pacientes;
    }
}
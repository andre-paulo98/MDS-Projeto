namespace ProjetoMDS
{
    partial class formUtilizadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formUtilizadores));
            this.lbUser = new System.Windows.Forms.ListBox();
            this.btAdicionarNovo = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.FormattingEnabled = true;
            this.lbUser.Location = new System.Drawing.Point(36, 53);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(498, 160);
            this.lbUser.TabIndex = 0;
            // 
            // btAdicionarNovo
            // 
            this.btAdicionarNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionarNovo.Location = new System.Drawing.Point(311, 227);
            this.btAdicionarNovo.Name = "btAdicionarNovo";
            this.btAdicionarNovo.Size = new System.Drawing.Size(120, 23);
            this.btAdicionarNovo.TabIndex = 1;
            this.btAdicionarNovo.Text = "Adicionar Utilizador";
            this.btAdicionarNovo.UseVisualStyleBackColor = true;
            this.btAdicionarNovo.Click += new System.EventHandler(this.btAdicionarNovo_Click);
            // 
            // btRemover
            // 
            this.btRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemover.Location = new System.Drawing.Point(459, 227);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 2;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Utilizadores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionarNovo);
            this.Controls.Add(this.lbUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(577, 300);
            this.Name = "formUtilizadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formUtilizadores_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUser;
        private System.Windows.Forms.Button btAdicionarNovo;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Label label1;
    }
}
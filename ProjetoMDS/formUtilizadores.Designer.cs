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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btAdicionarNovo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(498, 160);
            this.listBox1.TabIndex = 0;
            // 
            // btAdicionarNovo
            // 
            this.btAdicionarNovo.Location = new System.Drawing.Point(331, 227);
            this.btAdicionarNovo.Name = "btAdicionarNovo";
            this.btAdicionarNovo.Size = new System.Drawing.Size(120, 23);
            this.btAdicionarNovo.TabIndex = 1;
            this.btAdicionarNovo.Text = "Adicionar Utilizador";
            this.btAdicionarNovo.UseVisualStyleBackColor = true;
            this.btAdicionarNovo.Click += new System.EventHandler(this.btAdicionarNovo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(474, 227);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // formUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 262);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAdicionarNovo);
            this.Controls.Add(this.listBox1);
            this.Name = "formUtilizadores";
            this.Text = "formUtilizadores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btAdicionarNovo;
        private System.Windows.Forms.Button btCancelar;
    }
}
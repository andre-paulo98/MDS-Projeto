namespace ProjetoMDS {
    partial class formMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            this.btUsers = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUsers
            // 
            this.btUsers.Image = ((System.Drawing.Image)(resources.GetObject("btUsers.Image")));
            this.btUsers.Location = new System.Drawing.Point(37, 53);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(125, 99);
            this.btUsers.TabIndex = 2;
            this.btUsers.Text = "Utilizadores";
            this.btUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btUsers.UseVisualStyleBackColor = true;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btConsultas
            // 
            this.btConsultas.Location = new System.Drawing.Point(237, 53);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(75, 23);
            this.btConsultas.TabIndex = 3;
            this.btConsultas.Text = "button1";
            this.btConsultas.UseVisualStyleBackColor = true;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 193);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.btUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMenu";
            this.Text = "formMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Button btConsultas;
    }
}
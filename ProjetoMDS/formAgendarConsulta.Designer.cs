namespace ProjetoMDS
{
    partial class formAgendarConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAgendarConsulta));
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.horaPicker = new System.Windows.Forms.DateTimePicker();
            this.cbEsp = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataPicker
            // 
            this.dataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPicker.Location = new System.Drawing.Point(56, 25);
            this.dataPicker.Name = "dataPicker";
            this.dataPicker.Size = new System.Drawing.Size(82, 20);
            this.dataPicker.TabIndex = 0;
            // 
            // horaPicker
            // 
            this.horaPicker.CustomFormat = "H:m";
            this.horaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.horaPicker.Location = new System.Drawing.Point(226, 25);
            this.horaPicker.Name = "horaPicker";
            this.horaPicker.ShowUpDown = true;
            this.horaPicker.Size = new System.Drawing.Size(50, 20);
            this.horaPicker.TabIndex = 1;
            // 
            // cbEsp
            // 
            this.cbEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsp.FormattingEnabled = true;
            this.cbEsp.Items.AddRange(new object[] {
            "Pediatria",
            "Dermatologia",
            "Cardiologia",
            "Radiografia",
            "Infectologia"});
            this.cbEsp.Location = new System.Drawing.Point(20, 83);
            this.cbEsp.Name = "cbEsp";
            this.cbEsp.Size = new System.Drawing.Size(154, 21);
            this.cbEsp.TabIndex = 2;
            this.cbEsp.SelectedIndexChanged += new System.EventHandler(this.cbEsp_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 160);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Especialidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Medicos Disponíveis";
            // 
            // formAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbEsp);
            this.Controls.Add(this.horaPicker);
            this.Controls.Add(this.dataPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAgendarConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataPicker;
        private System.Windows.Forms.DateTimePicker horaPicker;
        private System.Windows.Forms.ComboBox cbEsp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
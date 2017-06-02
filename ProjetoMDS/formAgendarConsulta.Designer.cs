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
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.horaPicker = new System.Windows.Forms.DateTimePicker();
            this.cbEsp = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataPicker
            // 
            this.dataPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPicker.Location = new System.Drawing.Point(58, 25);
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
            this.cbEsp.Location = new System.Drawing.Point(31, 92);
            this.cbEsp.Name = "cbEsp";
            this.cbEsp.Size = new System.Drawing.Size(154, 21);
            this.cbEsp.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 133);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 160);
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
            // formAgendarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbEsp);
            this.Controls.Add(this.horaPicker);
            this.Controls.Add(this.dataPicker);
            this.Name = "formAgendarConsulta";
            this.Text = "formAgendarConsulta";
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
    }
}
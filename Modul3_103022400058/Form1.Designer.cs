namespace Modul3_103022400058
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConvert = new Button();
            cmbBox_awal = new ComboBox();
            txtBox_awal = new TextBox();
            txtBox_akhir = new TextBox();
            label4 = new Label();
            cbmBox_akhir = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 80);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Satuan Awal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 80);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Nilai Awal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 147);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Nilai Akhir";
            label3.Click += label3_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(462, 284);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(94, 29);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "convert";
            btnConvert.UseVisualStyleBackColor = true;
            // 
            // cmbBox_awal
            // 
            cmbBox_awal.FormattingEnabled = true;
            cmbBox_awal.Items.AddRange(new object[] { "Celcius ", "Fahrenheit", "Kelvin", "Reamur" });
            cmbBox_awal.Location = new Point(96, 103);
            cmbBox_awal.Name = "cmbBox_awal";
            cmbBox_awal.Size = new Size(151, 28);
            cmbBox_awal.TabIndex = 4;
            cmbBox_awal.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtBox_awal
            // 
            txtBox_awal.Location = new Point(350, 103);
            txtBox_awal.Name = "txtBox_awal";
            txtBox_awal.Size = new Size(212, 27);
            txtBox_awal.TabIndex = 5;
            // 
            // txtBox_akhir
            // 
            txtBox_akhir.Location = new Point(350, 183);
            txtBox_akhir.Name = "txtBox_akhir";
            txtBox_akhir.ReadOnly = true;
            txtBox_akhir.Size = new Size(206, 27);
            txtBox_akhir.TabIndex = 6;
            txtBox_akhir.TextChanged += txtBox_akhir_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 147);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 7;
            label4.Text = "Satuan Akhir";
            // 
            // cbmBox_akhir
            // 
            cbmBox_akhir.FormattingEnabled = true;
            cbmBox_akhir.Items.AddRange(new object[] { "Celcius ", "Fahrenheit", "Kelvin", "Reamur" });
            cbmBox_akhir.Location = new Point(96, 182);
            cbmBox_akhir.Name = "cbmBox_akhir";
            cbmBox_akhir.Size = new Size(156, 28);
            cbmBox_akhir.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbmBox_akhir);
            Controls.Add(label4);
            Controls.Add(txtBox_akhir);
            Controls.Add(txtBox_awal);
            Controls.Add(cmbBox_awal);
            Controls.Add(btnConvert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConvert;
        private ComboBox cmbBox_awal;
        private TextBox txtBox_awal;
        private TextBox txtBox_akhir;
        private Label label4;
        private ComboBox cbmBox_akhir;
    }
}

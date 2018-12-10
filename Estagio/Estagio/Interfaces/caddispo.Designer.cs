namespace Estagio
{
    partial class caddispo
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncadprof = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxInicio = new System.Windows.Forms.ComboBox();
            this.cboxFim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cboxSemana = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Voltar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncadprof
            // 
            this.btncadprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadprof.Location = new System.Drawing.Point(15, 160);
            this.btncadprof.Name = "btncadprof";
            this.btncadprof.Size = new System.Drawing.Size(273, 33);
            this.btncadprof.TabIndex = 23;
            this.btncadprof.Text = "Cadastrar Disponibilidade";
            this.btncadprof.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(111, 45);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "tempo de início";
            // 
            // cboxInicio
            // 
            this.cboxInicio.FormattingEnabled = true;
            this.cboxInicio.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.cboxInicio.Location = new System.Drawing.Point(189, 44);
            this.cboxInicio.Name = "cboxInicio";
            this.cboxInicio.Size = new System.Drawing.Size(99, 21);
            this.cboxInicio.TabIndex = 27;
            // 
            // cboxFim
            // 
            this.cboxFim.FormattingEnabled = true;
            this.cboxFim.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.cboxFim.Location = new System.Drawing.Point(189, 84);
            this.cboxFim.Name = "cboxFim";
            this.cboxFim.Size = new System.Drawing.Size(99, 21);
            this.cboxFim.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "tempo de fim";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(111, 85);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 29;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboxSemana
            // 
            this.cboxSemana.FormattingEnabled = true;
            this.cboxSemana.Items.AddRange(new object[] {
            "SEG",
            "TER",
            "QUA",
            "QUI",
            "SEX",
            "SAB"});
            this.cboxSemana.Location = new System.Drawing.Point(209, 123);
            this.cboxSemana.Name = "cboxSemana";
            this.cboxSemana.Size = new System.Drawing.Size(79, 21);
            this.cboxSemana.TabIndex = 31;
            // 
            // caddispo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 207);
            this.Controls.Add(this.cboxSemana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.cboxFim);
            this.Controls.Add(this.cboxInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadprof);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "caddispo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "caddispo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncadprof;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxInicio;
        private System.Windows.Forms.ComboBox cboxFim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox cboxSemana;
    }
}
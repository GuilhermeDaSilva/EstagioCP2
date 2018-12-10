namespace Estagio
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcadprof = new System.Windows.Forms.Label();
            this.lblgradehorprofs = new System.Windows.Forms.Label();
            this.lblcalendsemanal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcadprof
            // 
            this.lblcadprof.AutoSize = true;
            this.lblcadprof.BackColor = System.Drawing.Color.Red;
            this.lblcadprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadprof.ForeColor = System.Drawing.Color.Black;
            this.lblcadprof.Location = new System.Drawing.Point(12, 200);
            this.lblcadprof.Name = "lblcadprof";
            this.lblcadprof.Size = new System.Drawing.Size(169, 20);
            this.lblcadprof.TabIndex = 1;
            this.lblcadprof.Text = "Cadastrar professor";
            this.lblcadprof.Click += new System.EventHandler(this.lblcadprof_Click);
            // 
            // lblgradehorprofs
            // 
            this.lblgradehorprofs.AutoSize = true;
            this.lblgradehorprofs.BackColor = System.Drawing.Color.Red;
            this.lblgradehorprofs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgradehorprofs.ForeColor = System.Drawing.Color.Black;
            this.lblgradehorprofs.Location = new System.Drawing.Point(12, 245);
            this.lblgradehorprofs.Name = "lblgradehorprofs";
            this.lblgradehorprofs.Size = new System.Drawing.Size(254, 20);
            this.lblgradehorprofs.TabIndex = 2;
            this.lblgradehorprofs.Text = "Grade horária dos professores";
            this.lblgradehorprofs.Click += new System.EventHandler(this.lblgradehorprofs_Click);
            // 
            // lblcalendsemanal
            // 
            this.lblcalendsemanal.AutoSize = true;
            this.lblcalendsemanal.BackColor = System.Drawing.Color.Red;
            this.lblcalendsemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalendsemanal.ForeColor = System.Drawing.Color.Black;
            this.lblcalendsemanal.Location = new System.Drawing.Point(12, 291);
            this.lblcalendsemanal.Name = "lblcalendsemanal";
            this.lblcalendsemanal.Size = new System.Drawing.Size(167, 20);
            this.lblcalendsemanal.TabIndex = 3;
            this.lblcalendsemanal.Text = "Calendário semanal";
            this.lblcalendsemanal.Click += new System.EventHandler(this.lblcalendsemanal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estagio.Properties.Resources._1494531511_logo_cp2;
            this.pictureBox1.Location = new System.Drawing.Point(61, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sair";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcalendsemanal);
            this.Controls.Add(this.lblgradehorprofs);
            this.Controls.Add(this.lblcadprof);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcadprof;
        private System.Windows.Forms.Label lblgradehorprofs;
        private System.Windows.Forms.Label lblcalendsemanal;
        private System.Windows.Forms.Label label1;
    }
}


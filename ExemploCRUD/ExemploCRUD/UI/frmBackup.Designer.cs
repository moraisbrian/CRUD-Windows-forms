﻿namespace ExemploCRUD.UI
{
    partial class frmBackup
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
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(110, 51);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(92, 48);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar Backup";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(110, 121);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(92, 48);
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.Text = "Restaurar Backup";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bak";
            this.openFileDialog1.Filter = "Backup|*.bak";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bak";
            this.saveFileDialog1.Filter = "Backup|*.bak";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 247);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnGerar);
            this.Name = "frmBackup";
            this.Text = "frmBackup";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
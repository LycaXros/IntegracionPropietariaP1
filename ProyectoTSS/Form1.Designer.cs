namespace ProyectoTSS
{
    partial class Form1
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
            this.btnOpenNomina = new System.Windows.Forms.Button();
            this.btnOpenRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenNomina
            // 
            this.btnOpenNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNomina.Location = new System.Drawing.Point(62, 58);
            this.btnOpenNomina.Name = "btnOpenNomina";
            this.btnOpenNomina.Size = new System.Drawing.Size(200, 88);
            this.btnOpenNomina.TabIndex = 0;
            this.btnOpenNomina.Text = "Ver Nomina";
            this.btnOpenNomina.UseVisualStyleBackColor = true;
            this.btnOpenNomina.Click += new System.EventHandler(this.btnOpenNomina_Click);
            // 
            // btnOpenRead
            // 
            this.btnOpenRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRead.Location = new System.Drawing.Point(62, 225);
            this.btnOpenRead.Name = "btnOpenRead";
            this.btnOpenRead.Size = new System.Drawing.Size(200, 88);
            this.btnOpenRead.TabIndex = 1;
            this.btnOpenRead.Text = "Leer Archivo";
            this.btnOpenRead.UseVisualStyleBackColor = true;
            this.btnOpenRead.Click += new System.EventHandler(this.btnOpenRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 380);
            this.Controls.Add(this.btnOpenRead);
            this.Controls.Add(this.btnOpenNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto TSS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNomina;
        private System.Windows.Forms.Button btnOpenRead;
    }
}


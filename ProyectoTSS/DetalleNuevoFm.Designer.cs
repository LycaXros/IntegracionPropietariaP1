namespace ProyectoTSS
{
    partial class DetalleNuevoFm
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbxTD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSISR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCuetna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpenNomina
            // 
            this.btnOpenNomina.Enabled = false;
            this.btnOpenNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNomina.Location = new System.Drawing.Point(28, 260);
            this.btnOpenNomina.Name = "btnOpenNomina";
            this.btnOpenNomina.Size = new System.Drawing.Size(200, 88);
            this.btnOpenNomina.TabIndex = 1;
            this.btnOpenNomina.Text = "Guardar";
            this.btnOpenNomina.UseVisualStyleBackColor = true;
            this.btnOpenNomina.Click += new System.EventHandler(this.btnOpenNomina_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 88);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTD
            // 
            this.cbxTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTD.FormattingEnabled = true;
            this.cbxTD.Items.AddRange(new object[] {
            "Pasaporte",
            "Cedula",
            "RNC"});
            this.cbxTD.Location = new System.Drawing.Point(12, 53);
            this.cbxTD.Name = "cbxTD";
            this.cbxTD.Size = new System.Drawing.Size(190, 33);
            this.cbxTD.TabIndex = 3;
            this.cbxTD.SelectedIndexChanged += new System.EventHandler(this.cbxTD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "NSS";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(477, 53);
            this.maskedTextBox1.Mask = "99999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 30);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(208, 53);
            this.txtDocumento.MaxLength = 15;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(243, 30);
            this.txtDocumento.TabIndex = 5;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(12, 129);
            this.txtSalario.MaxLength = 10;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(243, 30);
            this.txtSalario.TabIndex = 12;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Salario ISR";
            // 
            // txtSISR
            // 
            this.txtSISR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSISR.Location = new System.Drawing.Point(265, 129);
            this.txtSISR.MaxLength = 10;
            this.txtSISR.Name = "txtSISR";
            this.txtSISR.Size = new System.Drawing.Size(243, 30);
            this.txtSISR.TabIndex = 14;
            this.txtSISR.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtSISR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressOnlyNumber);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Numero Cuenta";
            // 
            // TxtCuetna
            // 
            this.TxtCuetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuetna.Location = new System.Drawing.Point(12, 198);
            this.TxtCuetna.MaxLength = 20;
            this.TxtCuetna.Name = "TxtCuetna";
            this.TxtCuetna.Size = new System.Drawing.Size(243, 30);
            this.TxtCuetna.TabIndex = 16;
            this.TxtCuetna.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.TxtCuetna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // DetalleNuevoFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 377);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtCuetna);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSISR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenNomina);
            this.Name = "DetalleNuevoFm";
            this.Text = "DetalleNuevoFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenNomina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxTD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSISR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCuetna;
    }
}
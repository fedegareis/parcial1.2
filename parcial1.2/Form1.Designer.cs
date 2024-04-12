namespace parcial1._2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtbcod = new System.Windows.Forms.MaskedTextBox();
            this.txtapell = new System.Windows.Forms.TextBox();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.cmbdest = new System.Windows.Forms.ComboBox();
            this.dtpreserva = new System.Windows.Forms.DateTimePicker();
            this.dtpsalida = new System.Windows.Forms.DateTimePicker();
            this.cbvacuna = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbmenor = new System.Windows.Forms.RadioButton();
            this.rbadulto = new System.Windows.Forms.RadioButton();
            this.rbanciano = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbcod
            // 
            this.mtbcod.Location = new System.Drawing.Point(172, 42);
            this.mtbcod.Mask = "LL-000";
            this.mtbcod.Name = "mtbcod";
            this.mtbcod.Size = new System.Drawing.Size(100, 20);
            this.mtbcod.TabIndex = 0;
            // 
            // txtapell
            // 
            this.txtapell.Location = new System.Drawing.Point(172, 80);
            this.txtapell.Name = "txtapell";
            this.txtapell.Size = new System.Drawing.Size(100, 20);
            this.txtapell.TabIndex = 1;
            // 
            // txtnomb
            // 
            this.txtnomb.Location = new System.Drawing.Point(172, 118);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(100, 20);
            this.txtnomb.TabIndex = 2;
            // 
            // cmbdest
            // 
            this.cmbdest.FormattingEnabled = true;
            this.cmbdest.Location = new System.Drawing.Point(172, 162);
            this.cmbdest.Name = "cmbdest";
            this.cmbdest.Size = new System.Drawing.Size(121, 21);
            this.cmbdest.TabIndex = 3;
            // 
            // dtpreserva
            // 
            this.dtpreserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpreserva.Location = new System.Drawing.Point(172, 208);
            this.dtpreserva.Name = "dtpreserva";
            this.dtpreserva.Size = new System.Drawing.Size(100, 20);
            this.dtpreserva.TabIndex = 4;
            // 
            // dtpsalida
            // 
            this.dtpsalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsalida.Location = new System.Drawing.Point(172, 249);
            this.dtpsalida.Name = "dtpsalida";
            this.dtpsalida.Size = new System.Drawing.Size(100, 20);
            this.dtpsalida.TabIndex = 5;
            // 
            // cbvacuna
            // 
            this.cbvacuna.AutoSize = true;
            this.cbvacuna.Location = new System.Drawing.Point(172, 284);
            this.cbvacuna.Name = "cbvacuna";
            this.cbvacuna.Size = new System.Drawing.Size(15, 14);
            this.cbvacuna.TabIndex = 6;
            this.cbvacuna.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbanciano);
            this.groupBox1.Controls.Add(this.rbadulto);
            this.groupBox1.Controls.Add(this.rbmenor);
            this.groupBox1.Location = new System.Drawing.Point(172, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo Etario";
            // 
            // rbmenor
            // 
            this.rbmenor.AutoSize = true;
            this.rbmenor.Location = new System.Drawing.Point(28, 42);
            this.rbmenor.Name = "rbmenor";
            this.rbmenor.Size = new System.Drawing.Size(55, 17);
            this.rbmenor.TabIndex = 0;
            this.rbmenor.TabStop = true;
            this.rbmenor.Text = "Menor";
            this.rbmenor.UseVisualStyleBackColor = true;
            // 
            // rbadulto
            // 
            this.rbadulto.AutoSize = true;
            this.rbadulto.Location = new System.Drawing.Point(120, 42);
            this.rbadulto.Name = "rbadulto";
            this.rbadulto.Size = new System.Drawing.Size(54, 17);
            this.rbadulto.TabIndex = 1;
            this.rbadulto.TabStop = true;
            this.rbadulto.Text = "Mayor";
            this.rbadulto.UseVisualStyleBackColor = true;
            // 
            // rbanciano
            // 
            this.rbanciano.AutoSize = true;
            this.rbanciano.Location = new System.Drawing.Point(221, 42);
            this.rbanciano.Name = "rbanciano";
            this.rbanciano.Size = new System.Drawing.Size(64, 17);
            this.rbanciano.TabIndex = 2;
            this.rbanciano.TabStop = true;
            this.rbanciano.Text = "Jubilado";
            this.rbanciano.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo de Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fecha de Reserva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Plan de Vacunacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbvacuna);
            this.Controls.Add(this.dtpsalida);
            this.Controls.Add(this.dtpreserva);
            this.Controls.Add(this.cmbdest);
            this.Controls.Add(this.txtnomb);
            this.Controls.Add(this.txtapell);
            this.Controls.Add(this.mtbcod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbcod;
        private System.Windows.Forms.TextBox txtapell;
        private System.Windows.Forms.TextBox txtnomb;
        private System.Windows.Forms.ComboBox cmbdest;
        private System.Windows.Forms.DateTimePicker dtpreserva;
        private System.Windows.Forms.DateTimePicker dtpsalida;
        private System.Windows.Forms.CheckBox cbvacuna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbanciano;
        private System.Windows.Forms.RadioButton rbadulto;
        private System.Windows.Forms.RadioButton rbmenor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}


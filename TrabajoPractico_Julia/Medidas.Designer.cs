namespace TrabajoPractico_Julia
{
    partial class Medidas
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKilogramos = new System.Windows.Forms.TextBox();
            this.txtLibras = new System.Windows.Forms.TextBox();
            this.txtGramos = new System.Windows.Forms.TextBox();
            this.txtDecagramos = new System.Windows.Forms.TextBox();
            this.txtOnzas = new System.Windows.Forms.TextBox();
            this.txtMiligramos = new System.Windows.Forms.TextBox();
            this.txtToneladasMetricas = new System.Windows.Forms.TextBox();
            this.txtToneladas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(6, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(437, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtToneladas);
            this.groupBox2.Controls.Add(this.txtToneladasMetricas);
            this.groupBox2.Controls.Add(this.txtMiligramos);
            this.groupBox2.Controls.Add(this.txtOnzas);
            this.groupBox2.Controls.Add(this.txtDecagramos);
            this.groupBox2.Controls.Add(this.txtGramos);
            this.groupBox2.Controls.Add(this.txtLibras);
            this.groupBox2.Controls.Add(this.txtKilogramos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(208, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 271);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilogramos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gramos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Decagramos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Onzas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miligramos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Toneladas métricas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Toneladas";
            // 
            // txtKilogramos
            // 
            this.txtKilogramos.Location = new System.Drawing.Point(34, 65);
            this.txtKilogramos.Name = "txtKilogramos";
            this.txtKilogramos.Size = new System.Drawing.Size(54, 20);
            this.txtKilogramos.TabIndex = 8;
            // 
            // txtLibras
            // 
            this.txtLibras.Enabled = false;
            this.txtLibras.Location = new System.Drawing.Point(104, 65);
            this.txtLibras.Name = "txtLibras";
            this.txtLibras.Size = new System.Drawing.Size(64, 20);
            this.txtLibras.TabIndex = 9;
            // 
            // txtGramos
            // 
            this.txtGramos.Enabled = false;
            this.txtGramos.Location = new System.Drawing.Point(34, 123);
            this.txtGramos.Name = "txtGramos";
            this.txtGramos.Size = new System.Drawing.Size(54, 20);
            this.txtGramos.TabIndex = 10;
            // 
            // txtDecagramos
            // 
            this.txtDecagramos.Enabled = false;
            this.txtDecagramos.Location = new System.Drawing.Point(104, 123);
            this.txtDecagramos.Name = "txtDecagramos";
            this.txtDecagramos.Size = new System.Drawing.Size(64, 20);
            this.txtDecagramos.TabIndex = 11;
            // 
            // txtOnzas
            // 
            this.txtOnzas.Enabled = false;
            this.txtOnzas.Location = new System.Drawing.Point(34, 175);
            this.txtOnzas.Name = "txtOnzas";
            this.txtOnzas.Size = new System.Drawing.Size(55, 20);
            this.txtOnzas.TabIndex = 12;
            // 
            // txtMiligramos
            // 
            this.txtMiligramos.Enabled = false;
            this.txtMiligramos.Location = new System.Drawing.Point(104, 175);
            this.txtMiligramos.Name = "txtMiligramos";
            this.txtMiligramos.Size = new System.Drawing.Size(64, 20);
            this.txtMiligramos.TabIndex = 13;
            // 
            // txtToneladasMetricas
            // 
            this.txtToneladasMetricas.Enabled = false;
            this.txtToneladasMetricas.Location = new System.Drawing.Point(104, 223);
            this.txtToneladasMetricas.Name = "txtToneladasMetricas";
            this.txtToneladasMetricas.Size = new System.Drawing.Size(64, 20);
            this.txtToneladasMetricas.TabIndex = 14;
            // 
            // txtToneladas
            // 
            this.txtToneladas.Enabled = false;
            this.txtToneladas.Location = new System.Drawing.Point(34, 223);
            this.txtToneladas.Name = "txtToneladas";
            this.txtToneladas.Size = new System.Drawing.Size(55, 20);
            this.txtToneladas.TabIndex = 15;
            // 
            // Medidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Medidas";
            this.Text = "Medidas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtToneladas;
        private System.Windows.Forms.TextBox txtToneladasMetricas;
        private System.Windows.Forms.TextBox txtMiligramos;
        private System.Windows.Forms.TextBox txtOnzas;
        private System.Windows.Forms.TextBox txtDecagramos;
        private System.Windows.Forms.TextBox txtGramos;
        private System.Windows.Forms.TextBox txtLibras;
        private System.Windows.Forms.TextBox txtKilogramos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
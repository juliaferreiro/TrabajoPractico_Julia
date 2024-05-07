namespace TrabajoPractico_Julia
{
    partial class EstadoCivil
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPasatiempo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbViudo = new System.Windows.Forms.RadioButton();
            this.rdbDivorciado = new System.Windows.Forms.RadioButton();
            this.rdbUnionLibre = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(439, 96);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPasatiempo);
            this.groupBox2.Location = new System.Drawing.Point(391, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 133);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txtPasatiempo
            // 
            this.txtPasatiempo.Location = new System.Drawing.Point(22, 19);
            this.txtPasatiempo.Multiline = true;
            this.txtPasatiempo.Name = "txtPasatiempo";
            this.txtPasatiempo.Size = new System.Drawing.Size(156, 98);
            this.txtPasatiempo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUnionLibre);
            this.groupBox1.Controls.Add(this.rdbDivorciado);
            this.groupBox1.Controls.Add(this.rdbViudo);
            this.groupBox1.Controls.Add(this.rdbCasado);
            this.groupBox1.Controls.Add(this.rdbSoltero);
            this.groupBox1.Location = new System.Drawing.Point(183, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Location = new System.Drawing.Point(6, 34);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(69, 17);
            this.rdbSoltero.TabIndex = 0;
            this.rdbSoltero.TabStop = true;
            this.rdbSoltero.Text = "Soltero/a";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(6, 57);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(72, 17);
            this.rdbCasado.TabIndex = 1;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado/a";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbViudo
            // 
            this.rdbViudo.AutoSize = true;
            this.rdbViudo.Location = new System.Drawing.Point(6, 80);
            this.rdbViudo.Name = "rdbViudo";
            this.rdbViudo.Size = new System.Drawing.Size(63, 17);
            this.rdbViudo.TabIndex = 2;
            this.rdbViudo.TabStop = true;
            this.rdbViudo.Text = "Viudo/a";
            this.rdbViudo.UseVisualStyleBackColor = true;
            // 
            // rdbDivorciado
            // 
            this.rdbDivorciado.AutoSize = true;
            this.rdbDivorciado.Location = new System.Drawing.Point(6, 103);
            this.rdbDivorciado.Name = "rdbDivorciado";
            this.rdbDivorciado.Size = new System.Drawing.Size(87, 17);
            this.rdbDivorciado.TabIndex = 3;
            this.rdbDivorciado.TabStop = true;
            this.rdbDivorciado.Text = "Divorciado/a";
            this.rdbDivorciado.UseVisualStyleBackColor = true;
            // 
            // rdbUnionLibre
            // 
            this.rdbUnionLibre.AutoSize = true;
            this.rdbUnionLibre.Location = new System.Drawing.Point(6, 123);
            this.rdbUnionLibre.Name = "rdbUnionLibre";
            this.rdbUnionLibre.Size = new System.Drawing.Size(75, 17);
            this.rdbUnionLibre.TabIndex = 4;
            this.rdbUnionLibre.TabStop = true;
            this.rdbUnionLibre.Text = "Unión libre";
            this.rdbUnionLibre.UseVisualStyleBackColor = true;
            // 
            // EstadoCivil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EstadoCivil";
            this.Text = "EstadoCivil";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPasatiempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUnionLibre;
        private System.Windows.Forms.RadioButton rdbDivorciado;
        private System.Windows.Forms.RadioButton rdbViudo;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSoltero;
    }
}
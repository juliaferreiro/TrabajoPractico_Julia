namespace TrabajoPractico_Julia
{
    partial class Fotografia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdb6x8 = new System.Windows.Forms.RadioButton();
            this.rdb4x6 = new System.Windows.Forms.RadioButton();
            this.rdb5x7 = new System.Windows.Forms.RadioButton();
            this.rdb3x4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(27, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impresión Digital ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPagar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtInput);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(27, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 288);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad a pagar";
            // 
            // txtPagar
            // 
            this.txtPagar.Enabled = false;
            this.txtPagar.Location = new System.Drawing.Point(155, 259);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(78, 20);
            this.txtPagar.TabIndex = 6;
            this.txtPagar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdb6x8);
            this.groupBox4.Controls.Add(this.rdb4x6);
            this.groupBox4.Controls.Add(this.rdb5x7);
            this.groupBox4.Controls.Add(this.rdb3x4);
            this.groupBox4.Location = new System.Drawing.Point(21, 147);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 89);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Medidas";
            // 
            // rdb6x8
            // 
            this.rdb6x8.AutoSize = true;
            this.rdb6x8.Location = new System.Drawing.Point(140, 52);
            this.rdb6x8.Name = "rdb6x8";
            this.rdb6x8.Size = new System.Drawing.Size(42, 17);
            this.rdb6x8.TabIndex = 3;
            this.rdb6x8.TabStop = true;
            this.rdb6x8.Text = "6x8";
            this.rdb6x8.UseVisualStyleBackColor = true;
            // 
            // rdb4x6
            // 
            this.rdb4x6.AutoSize = true;
            this.rdb4x6.Location = new System.Drawing.Point(31, 52);
            this.rdb4x6.Name = "rdb4x6";
            this.rdb4x6.Size = new System.Drawing.Size(42, 17);
            this.rdb4x6.TabIndex = 2;
            this.rdb4x6.TabStop = true;
            this.rdb4x6.Text = "4x6";
            this.rdb4x6.UseVisualStyleBackColor = true;
            // 
            // rdb5x7
            // 
            this.rdb5x7.AutoSize = true;
            this.rdb5x7.Location = new System.Drawing.Point(140, 19);
            this.rdb5x7.Name = "rdb5x7";
            this.rdb5x7.Size = new System.Drawing.Size(42, 17);
            this.rdb5x7.TabIndex = 1;
            this.rdb5x7.TabStop = true;
            this.rdb5x7.Text = "5x7";
            this.rdb5x7.UseVisualStyleBackColor = true;
            // 
            // rdb3x4
            // 
            this.rdb3x4.AutoSize = true;
            this.rdb3x4.Location = new System.Drawing.Point(31, 19);
            this.rdb3x4.Name = "rdb3x4";
            this.rdb3x4.Size = new System.Drawing.Size(42, 17);
            this.rdb3x4.TabIndex = 0;
            this.rdb3x4.TabStop = true;
            this.rdb3x4.Text = "3x4";
            this.rdb3x4.UseVisualStyleBackColor = true;
            this.rdb3x4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbTipo);
            this.groupBox3.Location = new System.Drawing.Point(21, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 54);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de fotos";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "",
            "Color",
            "Blanco y negro"});
            this.cmbTipo.Location = new System.Drawing.Point(93, 19);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(119, 21);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(114, 22);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(78, 20);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de fotos";
            // 
            // Fotografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fotografia";
            this.Text = "Fotografia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPagar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdb6x8;
        private System.Windows.Forms.RadioButton rdb4x6;
        private System.Windows.Forms.RadioButton rdb5x7;
        private System.Windows.Forms.RadioButton rdb3x4;
        private System.Windows.Forms.Label label3;
    }
}
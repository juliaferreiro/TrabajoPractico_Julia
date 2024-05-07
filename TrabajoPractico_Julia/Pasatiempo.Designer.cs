namespace TrabajoPractico_Julia
{
    partial class Pasatiempo
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chkLeer = new System.Windows.Forms.CheckBox();
            this.chkBailar = new System.Windows.Forms.CheckBox();
            this.chkComer = new System.Windows.Forms.CheckBox();
            this.chkTV = new System.Windows.Forms.CheckBox();
            this.txtPasatiempo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTV);
            this.groupBox1.Controls.Add(this.chkComer);
            this.groupBox1.Controls.Add(this.chkBailar);
            this.groupBox1.Controls.Add(this.chkLeer);
            this.groupBox1.Location = new System.Drawing.Point(186, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasatiempo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPasatiempo);
            this.groupBox2.Location = new System.Drawing.Point(394, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(442, 83);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chkLeer
            // 
            this.chkLeer.AutoSize = true;
            this.chkLeer.Location = new System.Drawing.Point(12, 34);
            this.chkLeer.Name = "chkLeer";
            this.chkLeer.Size = new System.Drawing.Size(47, 17);
            this.chkLeer.TabIndex = 0;
            this.chkLeer.Text = "Leer";
            this.chkLeer.UseVisualStyleBackColor = true;
            // 
            // chkBailar
            // 
            this.chkBailar.AutoSize = true;
            this.chkBailar.Location = new System.Drawing.Point(12, 66);
            this.chkBailar.Name = "chkBailar";
            this.chkBailar.Size = new System.Drawing.Size(52, 17);
            this.chkBailar.TabIndex = 1;
            this.chkBailar.Text = "Bailar";
            this.chkBailar.UseVisualStyleBackColor = true;
            // 
            // chkComer
            // 
            this.chkComer.AutoSize = true;
            this.chkComer.Location = new System.Drawing.Point(12, 98);
            this.chkComer.Name = "chkComer";
            this.chkComer.Size = new System.Drawing.Size(56, 17);
            this.chkComer.TabIndex = 2;
            this.chkComer.Text = "Comer";
            this.chkComer.UseVisualStyleBackColor = true;
            // 
            // chkTV
            // 
            this.chkTV.AutoSize = true;
            this.chkTV.Location = new System.Drawing.Point(12, 128);
            this.chkTV.Name = "chkTV";
            this.chkTV.Size = new System.Drawing.Size(62, 17);
            this.chkTV.TabIndex = 3;
            this.chkTV.Text = "Ver T.V";
            this.chkTV.UseVisualStyleBackColor = true;
            // 
            // txtPasatiempo
            // 
            this.txtPasatiempo.Location = new System.Drawing.Point(22, 19);
            this.txtPasatiempo.Multiline = true;
            this.txtPasatiempo.Name = "txtPasatiempo";
            this.txtPasatiempo.Size = new System.Drawing.Size(156, 98);
            this.txtPasatiempo.TabIndex = 0;
            // 
            // Pasatiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pasatiempo";
            this.Text = "Pasatiempo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkTV;
        private System.Windows.Forms.CheckBox chkComer;
        private System.Windows.Forms.CheckBox chkBailar;
        private System.Windows.Forms.CheckBox chkLeer;
        private System.Windows.Forms.TextBox txtPasatiempo;
    }
}
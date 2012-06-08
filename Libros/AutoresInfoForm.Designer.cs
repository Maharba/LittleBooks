namespace Libros
{
    partial class AutoresInfoForm
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
            this.txtLugarMuerte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkVive = new System.Windows.Forms.CheckBox();
            this.dtMuerte = new System.Windows.Forms.DateTimePicker();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtLugarMuerte);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLugarNacimiento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkVive);
            this.groupBox1.Controls.Add(this.dtMuerte);
            this.groupBox1.Controls.Add(this.dtNacimiento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNacionalidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // txtLugarMuerte
            // 
            this.txtLugarMuerte.Location = new System.Drawing.Point(359, 80);
            this.txtLugarMuerte.Name = "txtLugarMuerte";
            this.txtLugarMuerte.Size = new System.Drawing.Size(100, 20);
            this.txtLugarMuerte.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lugar";
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(359, 55);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(100, 20);
            this.txtLugarNacimiento.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lugar";
            // 
            // chkVive
            // 
            this.chkVive.AutoSize = true;
            this.chkVive.Location = new System.Drawing.Point(474, 82);
            this.chkVive.Name = "chkVive";
            this.chkVive.Size = new System.Drawing.Size(76, 17);
            this.chkVive.TabIndex = 10;
            this.chkVive.Text = "Sigue vivo";
            this.chkVive.UseVisualStyleBackColor = true;
            this.chkVive.CheckedChanged += new System.EventHandler(this.chkVive_CheckedChanged);
            // 
            // dtMuerte
            // 
            this.dtMuerte.Location = new System.Drawing.Point(101, 81);
            this.dtMuerte.Name = "dtMuerte";
            this.dtMuerte.Size = new System.Drawing.Size(200, 20);
            this.dtMuerte.TabIndex = 9;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Location = new System.Drawing.Point(101, 55);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtNacimiento.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(99, 107);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Muerte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(301, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(423, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(504, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AutoresInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 192);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AutoresInfoForm";
            this.Text = "Autor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoresInfoForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkVive;
        private System.Windows.Forms.DateTimePicker dtMuerte;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLugarMuerte;
        private System.Windows.Forms.Label label5;
    }
}
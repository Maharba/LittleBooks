namespace Libros
{
    partial class LibrosInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxAutor = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataSet = new Libros.librosDataSet();
            this.txtTituloOriginal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.autoresTableAdapter = new Libros.librosDataSetTableAdapters.autoresTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(357, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(276, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxAutor);
            this.groupBox1.Controls.Add(this.txtTituloOriginal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // cbxAutor
            // 
            this.cbxAutor.DataSource = this.autoresBindingSource;
            this.cbxAutor.DisplayMember = "Nombre";
            this.cbxAutor.FormattingEnabled = true;
            this.cbxAutor.Location = new System.Drawing.Point(101, 55);
            this.cbxAutor.Name = "cbxAutor";
            this.cbxAutor.Size = new System.Drawing.Size(143, 21);
            this.cbxAutor.TabIndex = 7;
            this.cbxAutor.ValueMember = "IdAutor";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataMember = "autores";
            this.autoresBindingSource.DataSource = this.librosDataSet;
            // 
            // librosDataSet
            // 
            this.librosDataSet.DataSetName = "librosDataSet";
            this.librosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTituloOriginal
            // 
            this.txtTituloOriginal.Location = new System.Drawing.Point(101, 81);
            this.txtTituloOriginal.Name = "txtTituloOriginal";
            this.txtTituloOriginal.Size = new System.Drawing.Size(301, 20);
            this.txtTituloOriginal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título Original";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(101, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(301, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // autoresTableAdapter
            // 
            this.autoresTableAdapter.ClearBeforeFill = true;
            // 
            // LibrosInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 171);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LibrosInfoForm";
            this.Text = "Libro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LibrosInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.LibrosInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxAutor;
        private System.Windows.Forms.TextBox txtTituloOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private librosDataSet librosDataSet;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private librosDataSetTableAdapters.autoresTableAdapter autoresTableAdapter;
    }
}
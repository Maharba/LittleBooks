namespace Libros
{
    partial class ResenhasInfoForm
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
            this.cbxLibro = new System.Windows.Forms.ComboBox();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosDataSet = new Libros.librosDataSet();
            this.txtResenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.librosTableAdapter = new Libros.librosDataSetTableAdapters.librosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(337, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(256, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxLibro);
            this.groupBox1.Controls.Add(this.txtResenha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 203);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // cbxLibro
            // 
            this.cbxLibro.DataSource = this.librosBindingSource;
            this.cbxLibro.DisplayMember = "Titulo";
            this.cbxLibro.FormattingEnabled = true;
            this.cbxLibro.Location = new System.Drawing.Point(82, 30);
            this.cbxLibro.Name = "cbxLibro";
            this.cbxLibro.Size = new System.Drawing.Size(143, 21);
            this.cbxLibro.TabIndex = 7;
            this.cbxLibro.ValueMember = "Id";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.librosDataSet;
            // 
            // librosDataSet
            // 
            this.librosDataSet.DataSetName = "librosDataSet";
            this.librosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtResenha
            // 
            this.txtResenha.Location = new System.Drawing.Point(82, 57);
            this.txtResenha.Multiline = true;
            this.txtResenha.Name = "txtResenha";
            this.txtResenha.Size = new System.Drawing.Size(301, 130);
            this.txtResenha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libro";
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // ResenhasInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 256);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResenhasInfoForm";
            this.Text = "Reseña";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResenhasInfoForm_FormClosing);
            this.Load += new System.EventHandler(this.ResenhasInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxLibro;
        private System.Windows.Forms.TextBox txtResenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private librosDataSet librosDataSet;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private librosDataSetTableAdapters.librosTableAdapter librosTableAdapter;
    }
}
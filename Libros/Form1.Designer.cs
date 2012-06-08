namespace Libros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnResenha = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseñasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLibros
            // 
            this.btnLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.Image = ((System.Drawing.Image)(resources.GetObject("btnLibros.Image")));
            this.btnLibros.Location = new System.Drawing.Point(43, 166);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(190, 183);
            this.btnLibros.TabIndex = 0;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnResenha
            // 
            this.btnResenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResenha.Image = ((System.Drawing.Image)(resources.GetObject("btnResenha.Image")));
            this.btnResenha.Location = new System.Drawing.Point(479, 166);
            this.btnResenha.Name = "btnResenha";
            this.btnResenha.Size = new System.Drawing.Size(190, 183);
            this.btnResenha.TabIndex = 1;
            this.btnResenha.Text = "Reseñas";
            this.btnResenha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResenha.UseVisualStyleBackColor = true;
            this.btnResenha.Click += new System.EventHandler(this.btnResenha_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.Image = ((System.Drawing.Image)(resources.GetObject("btnAutores.Image")));
            this.btnAutores.Location = new System.Drawing.Point(262, 166);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(190, 183);
            this.btnAutores.TabIndex = 2;
            this.btnAutores.Text = "Autores";
            this.btnAutores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(218, 17);
            this.toolStripStatusLabel2.Text = "Realizado por Abraham Chacón Landois";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(146, 17);
            this.toolStripStatusLabel3.Text = "maharbazster@gmail.com";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel4.Text = "Copyright © 2011";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(171, 17);
            this.toolStripStatusLabel5.Text = "Todos los derechos reservados.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "LittleBooks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Beta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "by Maharba";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.autoresToolStripMenuItem,
            this.reseñasToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // reseñasToolStripMenuItem
            // 
            this.reseñasToolStripMenuItem.Name = "reseñasToolStripMenuItem";
            this.reseñasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reseñasToolStripMenuItem.Text = "Reseñas";
            this.reseñasToolStripMenuItem.Click += new System.EventHandler(this.reseñasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenciasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // preferenciasToolStripMenuItem
            // 
            this.preferenciasToolStripMenuItem.Name = "preferenciasToolStripMenuItem";
            this.preferenciasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.preferenciasToolStripMenuItem.Text = "Preferencias";
            this.preferenciasToolStripMenuItem.Click += new System.EventHandler(this.preferenciasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnResenha);
            this.Controls.Add(this.btnLibros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LittleBooks";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnResenha;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseñasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}


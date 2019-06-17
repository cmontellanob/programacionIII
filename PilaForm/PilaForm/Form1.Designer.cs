namespace PilaForm
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
            this.TbInsertar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TbEliminar = new System.Windows.Forms.TabPage();
            this.Tbmostrar = new System.Windows.Forms.TabPage();
            this.Txtinsertar = new System.Windows.Forms.TextBox();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.lblvalor = new System.Windows.Forms.Label();
            this.mostrar = new System.Windows.Forms.ListBox();
            this.Btnmostrar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnmosdin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbInsertar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TbEliminar.SuspendLayout();
            this.Tbmostrar.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbInsertar
            // 
            this.TbInsertar.Controls.Add(this.tabPage1);
            this.TbInsertar.Controls.Add(this.TbEliminar);
            this.TbInsertar.Controls.Add(this.Tbmostrar);
            this.TbInsertar.Controls.Add(this.tabPage2);
            this.TbInsertar.Location = new System.Drawing.Point(37, 95);
            this.TbInsertar.Name = "TbInsertar";
            this.TbInsertar.SelectedIndex = 0;
            this.TbInsertar.Size = new System.Drawing.Size(363, 244);
            this.TbInsertar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnInsertar);
            this.tabPage1.Controls.Add(this.Txtinsertar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TbEliminar
            // 
            this.TbEliminar.Controls.Add(this.lblvalor);
            this.TbEliminar.Controls.Add(this.Btneliminar);
            this.TbEliminar.Location = new System.Drawing.Point(4, 22);
            this.TbEliminar.Name = "TbEliminar";
            this.TbEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.TbEliminar.Size = new System.Drawing.Size(355, 218);
            this.TbEliminar.TabIndex = 1;
            this.TbEliminar.Text = "Eliminar";
            this.TbEliminar.UseVisualStyleBackColor = true;
            // 
            // Tbmostrar
            // 
            this.Tbmostrar.Controls.Add(this.Btnmostrar);
            this.Tbmostrar.Controls.Add(this.mostrar);
            this.Tbmostrar.Location = new System.Drawing.Point(4, 22);
            this.Tbmostrar.Name = "Tbmostrar";
            this.Tbmostrar.Padding = new System.Windows.Forms.Padding(3);
            this.Tbmostrar.Size = new System.Drawing.Size(355, 218);
            this.Tbmostrar.TabIndex = 2;
            this.Tbmostrar.Text = "Mostrar";
            this.Tbmostrar.UseVisualStyleBackColor = true;
            // 
            // Txtinsertar
            // 
            this.Txtinsertar.Location = new System.Drawing.Point(41, 57);
            this.Txtinsertar.Name = "Txtinsertar";
            this.Txtinsertar.Size = new System.Drawing.Size(100, 20);
            this.Txtinsertar.TabIndex = 0;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(184, 53);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(75, 23);
            this.BtnInsertar.TabIndex = 1;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(165, 67);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(75, 23);
            this.Btneliminar.TabIndex = 0;
            this.Btneliminar.Text = "Eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(69, 72);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(35, 13);
            this.lblvalor.TabIndex = 1;
            this.lblvalor.Text = "label1";
            // 
            // mostrar
            // 
            this.mostrar.FormattingEnabled = true;
            this.mostrar.Location = new System.Drawing.Point(35, 47);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(120, 95);
            this.mostrar.TabIndex = 0;
            // 
            // Btnmostrar
            // 
            this.Btnmostrar.Location = new System.Drawing.Point(183, 79);
            this.Btnmostrar.Name = "Btnmostrar";
            this.Btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.Btnmostrar.TabIndex = 1;
            this.Btnmostrar.Text = "Mostrar";
            this.Btnmostrar.UseVisualStyleBackColor = true;
            this.Btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnmosdin);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(355, 218);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Mostrar Dinamicamente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnmosdin
            // 
            this.btnmosdin.Location = new System.Drawing.Point(228, 44);
            this.btnmosdin.Name = "btnmosdin";
            this.btnmosdin.Size = new System.Drawing.Size(75, 23);
            this.btnmosdin.TabIndex = 0;
            this.btnmosdin.Text = "Mostrar";
            this.btnmosdin.UseVisualStyleBackColor = true;
            this.btnmosdin.Click += new System.EventHandler(this.btnmosdin_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(36, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 142);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TbInsertar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TbEliminar.ResumeLayout(false);
            this.TbEliminar.PerformLayout();
            this.Tbmostrar.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbInsertar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TbEliminar;
        private System.Windows.Forms.TabPage Tbmostrar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox Txtinsertar;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnmostrar;
        private System.Windows.Forms.ListBox mostrar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmosdin;
    }
}



namespace Segundo_Parcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCargar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonArchivo = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(12, 45);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(94, 34);
            this.buttonCargar.TabIndex = 0;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado
            // 
            this.resultado.FormattingEnabled = true;
            this.resultado.ItemHeight = 20;
            this.resultado.Location = new System.Drawing.Point(596, 27);
            this.resultado.MultiColumn = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(148, 184);
            this.resultado.Sorted = true;
            this.resultado.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(419, 288);
            this.textBox1.TabIndex = 2;
            // 
            // buttonArchivo
            // 
            this.buttonArchivo.Location = new System.Drawing.Point(650, 397);
            this.buttonArchivo.Name = "buttonArchivo";
            this.buttonArchivo.Size = new System.Drawing.Size(94, 32);
            this.buttonArchivo.TabIndex = 3;
            this.buttonArchivo.Text = "Archivo";
            this.buttonArchivo.UseVisualStyleBackColor = true;
            this.buttonArchivo.Click += new System.EventHandler(this.Archivo_Click);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(12, 102);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(90, 34);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonArchivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.buttonCargar);
            this.Name = "Form1";
            this.Text = "Nombres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.ListBox resultado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonArchivo;
        private System.Windows.Forms.Button buttonNombres;
    }
}


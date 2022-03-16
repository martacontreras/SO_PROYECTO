
namespace Parchís
{
    partial class Iniciarsesión
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciarsesión));
            this.entrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.registrarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.LightSalmon;
            this.entrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entrar.Location = new System.Drawing.Point(589, 275);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(130, 48);
            this.entrar.TabIndex = 3;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(299, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 39);
            this.textBox1.TabIndex = 4;
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contraseña.Location = new System.Drawing.Point(299, 300);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(253, 39);
            this.contraseña.TabIndex = 5;
            // 
            // registrarse
            // 
            this.registrarse.BackColor = System.Drawing.Color.LightSalmon;
            this.registrarse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.registrarse.Location = new System.Drawing.Point(321, 389);
            this.registrarse.Name = "registrarse";
            this.registrarse.Size = new System.Drawing.Size(185, 49);
            this.registrarse.TabIndex = 6;
            this.registrarse.Text = "Regristrarse";
            this.registrarse.UseVisualStyleBackColor = false;
            this.registrarse.Click += new System.EventHandler(this.registrarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(228, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Si no estas registrado, pulsa el botón registrarse";
            // 
            // Iniciarsesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarse);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.entrar);
            this.DoubleBuffered = true;
            this.Name = "Iniciarsesión";
            this.Text = "Iniciarsesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button registrarse;
        private System.Windows.Forms.Label label1;
    }
}
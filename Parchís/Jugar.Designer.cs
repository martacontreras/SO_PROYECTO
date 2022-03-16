
namespace Parchís
{
    partial class Jugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jugar));
            this.jugar_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jugar_
            // 
            this.jugar_.BackColor = System.Drawing.Color.LightSalmon;
            this.jugar_.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.jugar_.Location = new System.Drawing.Point(279, 280);
            this.jugar_.Name = "jugar_";
            this.jugar_.Size = new System.Drawing.Size(207, 74);
            this.jugar_.TabIndex = 0;
            this.jugar_.Text = "Jugar";
            this.jugar_.UseVisualStyleBackColor = false;
            this.jugar_.Click += new System.EventHandler(this.jugar__Click);
            // 
            // Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jugar_);
            this.DoubleBuffered = true;
            this.Name = "Jugar";
            this.Text = "Jugar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jugar_;
    }
}


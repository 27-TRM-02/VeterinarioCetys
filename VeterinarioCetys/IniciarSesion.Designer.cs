
namespace VeterinarioCetys
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.loginBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dniText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonHaseo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBoton
            // 
            this.loginBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBoton.Location = new System.Drawing.Point(108, 205);
            this.loginBoton.Name = "loginBoton";
            this.loginBoton.Size = new System.Drawing.Size(283, 31);
            this.loginBoton.TabIndex = 1;
            this.loginBoton.Text = "Iniciar Sesión";
            this.loginBoton.UseVisualStyleBackColor = true;
            this.loginBoton.Click += new System.EventHandler(this.loginBoton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dniText
            // 
            this.dniText.Location = new System.Drawing.Point(233, 69);
            this.dniText.Name = "dniText";
            this.dniText.Size = new System.Drawing.Size(158, 20);
            this.dniText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(233, 127);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(158, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonHaseo
            // 
            this.botonHaseo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonHaseo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonHaseo.Location = new System.Drawing.Point(175, 265);
            this.botonHaseo.Name = "botonHaseo";
            this.botonHaseo.Size = new System.Drawing.Size(139, 75);
            this.botonHaseo.TabIndex = 6;
            this.botonHaseo.Text = "Hasear bbdd";
            this.botonHaseo.UseVisualStyleBackColor = true;
            this.botonHaseo.Click += new System.EventHandler(this.botonHaseo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::VeterinarioCetys.Properties.Resources.index1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 384);
            this.Controls.Add(this.botonHaseo);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBoton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IniciarSesion";
            this.Text = "INICIAR SESIÓN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dniText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonHaseo;
    }
}


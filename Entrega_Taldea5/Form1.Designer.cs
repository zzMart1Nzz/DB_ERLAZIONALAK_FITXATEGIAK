namespace Entrega_Taldea5
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.IniciarS_L = new System.Windows.Forms.Label();
            this.erabiltzailea_L = new System.Windows.Forms.Label();
            this.pasahitza_L = new System.Windows.Forms.Label();
            this.txtErabiltzailea = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSaioHasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IniciarS_L
            // 
            this.IniciarS_L.AutoSize = true;
            this.IniciarS_L.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarS_L.Location = new System.Drawing.Point(268, 151);
            this.IniciarS_L.Name = "IniciarS_L";
            this.IniciarS_L.Size = new System.Drawing.Size(834, 200);
            this.IniciarS_L.TabIndex = 0;
            this.IniciarS_L.Text = "Saioa Hasi";
            this.IniciarS_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IniciarS_L.Click += new System.EventHandler(this.label1_Click);
            // 
            // erabiltzailea_L
            // 
            this.erabiltzailea_L.AutoSize = true;
            this.erabiltzailea_L.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erabiltzailea_L.Location = new System.Drawing.Point(66, 417);
            this.erabiltzailea_L.Name = "erabiltzailea_L";
            this.erabiltzailea_L.Size = new System.Drawing.Size(405, 76);
            this.erabiltzailea_L.TabIndex = 1;
            this.erabiltzailea_L.Text = "Erabiltzailea:";
            this.erabiltzailea_L.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pasahitza_L
            // 
            this.pasahitza_L.AutoSize = true;
            this.pasahitza_L.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasahitza_L.Location = new System.Drawing.Point(66, 637);
            this.pasahitza_L.Name = "pasahitza_L";
            this.pasahitza_L.Size = new System.Drawing.Size(318, 76);
            this.pasahitza_L.TabIndex = 2;
            this.pasahitza_L.Text = "Pasahitza:";
            this.pasahitza_L.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtErabiltzailea
            // 
            this.txtErabiltzailea.Font = new System.Drawing.Font("Trebuchet MS", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErabiltzailea.Location = new System.Drawing.Point(78, 519);
            this.txtErabiltzailea.Name = "txtErabiltzailea";
            this.txtErabiltzailea.Size = new System.Drawing.Size(1169, 62);
            this.txtErabiltzailea.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Trebuchet MS", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(78, 741);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(1169, 62);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnSaioHasi
            // 
            this.btnSaioHasi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSaioHasi.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaioHasi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaioHasi.Location = new System.Drawing.Point(411, 892);
            this.btnSaioHasi.Name = "btnSaioHasi";
            this.btnSaioHasi.Size = new System.Drawing.Size(608, 73);
            this.btnSaioHasi.TabIndex = 5;
            this.btnSaioHasi.Text = "Saioa Hasi";
            this.btnSaioHasi.UseVisualStyleBackColor = false;
            this.btnSaioHasi.Click += new System.EventHandler(this.btnSaioHasi_Click);
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1339, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1212, 1093);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2541, 1090);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaioHasi);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtErabiltzailea);
            this.Controls.Add(this.pasahitza_L);
            this.Controls.Add(this.erabiltzailea_L);
            this.Controls.Add(this.IniciarS_L);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IniciarS_L;
        private System.Windows.Forms.Label erabiltzailea_L;
        private System.Windows.Forms.Label pasahitza_L;
        private System.Windows.Forms.TextBox txtErabiltzailea;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSaioHasi;
        private System.Windows.Forms.Label label1;
    }
}


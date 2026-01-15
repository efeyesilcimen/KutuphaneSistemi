namespace EfeKutuphane
{
    partial class LoginForm
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
            txtKullaniciAd = new TextBox();
            txtSifre = new TextBox();
            lblKullaniciAd = new Label();
            lblSifre = new Label();
            btnGiris = new Button();
            SuspendLayout();
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(320, 107);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(166, 27);
            txtKullaniciAd.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(320, 197);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(166, 27);
            txtSifre.TabIndex = 1;
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.Location = new Point(356, 66);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(92, 20);
            lblKullaniciAd.TabIndex = 2;
            lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(386, 164);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(39, 20);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.PaleTurquoise;
            btnGiris.Location = new Point(320, 291);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(166, 53);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGiris);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAd);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAd);
            Name = "LoginForm";
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAd;
        private TextBox txtSifre;
        private Label lblKullaniciAd;
        private Label lblSifre;
        private Button btnGiris;
    }
}
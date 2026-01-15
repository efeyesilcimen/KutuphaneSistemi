namespace EfeKutuphane
{
    partial class UyePanel
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
            dgvKitaplarim = new DataGridView();
            cmbUyeKitapSec = new ComboBox();
            btnTalepEt = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplarim).BeginInit();
            SuspendLayout();
            // 
            // dgvKitaplarim
            // 
            dgvKitaplarim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplarim.Location = new Point(155, 120);
            dgvKitaplarim.Name = "dgvKitaplarim";
            dgvKitaplarim.RowHeadersWidth = 51;
            dgvKitaplarim.Size = new Size(457, 188);
            dgvKitaplarim.TabIndex = 0;
            // 
            // cmbUyeKitapSec
            // 
            cmbUyeKitapSec.BackColor = SystemColors.ControlLightLight;
            cmbUyeKitapSec.FormattingEnabled = true;
            cmbUyeKitapSec.Location = new Point(507, 356);
            cmbUyeKitapSec.Name = "cmbUyeKitapSec";
            cmbUyeKitapSec.Size = new Size(191, 28);
            cmbUyeKitapSec.TabIndex = 1;
            // 
            // btnTalepEt
            // 
            btnTalepEt.BackColor = Color.AntiqueWhite;
            btnTalepEt.Location = new Point(273, 335);
            btnTalepEt.Name = "btnTalepEt";
            btnTalepEt.Size = new Size(207, 68);
            btnTalepEt.TabIndex = 2;
            btnTalepEt.Text = "Yeni Kitap Talebi Oluştur";
            btnTalepEt.UseVisualStyleBackColor = false;
            btnTalepEt.Click += btnTalepEt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(205, 57);
            label1.Name = "label1";
            label1.Size = new Size(365, 25);
            label1.TabIndex = 3;
            label1.Text = "KÜTÜPHANEYE HOŞ GELDİNİZ";
            // 
            // UyePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnTalepEt);
            Controls.Add(cmbUyeKitapSec);
            Controls.Add(dgvKitaplarim);
            Name = "UyePanel";
            Text = "Üye Paneli";
            Load += UyePanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplarim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKitaplarim;
        private ComboBox cmbUyeKitapSec;
        private Button btnTalepEt;
        private Label label1;
    }
}
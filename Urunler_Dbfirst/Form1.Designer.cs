namespace Urunler_Dbfirst
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.inaktifButton = new System.Windows.Forms.Button();
            this.atifButton = new System.Windows.Forms.Button();
            this.mrnaButton = new System.Windows.Forms.Button();
            this.digerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inaktifButton
            // 
            this.inaktifButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.inaktifButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inaktifButton.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inaktifButton.ForeColor = System.Drawing.Color.White;
            this.inaktifButton.Location = new System.Drawing.Point(100, 36);
            this.inaktifButton.Name = "inaktifButton";
            this.inaktifButton.Size = new System.Drawing.Size(186, 150);
            this.inaktifButton.TabIndex = 0;
            this.inaktifButton.Text = "İnaktif";
            this.inaktifButton.UseVisualStyleBackColor = false;
            this.inaktifButton.Click += new System.EventHandler(this.inaktifButton_Click);
            // 
            // atifButton
            // 
            this.atifButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.atifButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.atifButton.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.atifButton.ForeColor = System.Drawing.Color.White;
            this.atifButton.Location = new System.Drawing.Point(379, 36);
            this.atifButton.Name = "atifButton";
            this.atifButton.Size = new System.Drawing.Size(186, 150);
            this.atifButton.TabIndex = 1;
            this.atifButton.Text = "Aktif";
            this.atifButton.UseVisualStyleBackColor = false;
            this.atifButton.Click += new System.EventHandler(this.atifButton_Click);
            // 
            // mrnaButton
            // 
            this.mrnaButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mrnaButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mrnaButton.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mrnaButton.ForeColor = System.Drawing.Color.White;
            this.mrnaButton.Location = new System.Drawing.Point(99, 241);
            this.mrnaButton.Name = "mrnaButton";
            this.mrnaButton.Size = new System.Drawing.Size(186, 150);
            this.mrnaButton.TabIndex = 2;
            this.mrnaButton.Text = "m-RNA";
            this.mrnaButton.UseVisualStyleBackColor = false;
            // 
            // digerButton
            // 
            this.digerButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.digerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.digerButton.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digerButton.ForeColor = System.Drawing.Color.White;
            this.digerButton.Location = new System.Drawing.Point(379, 241);
            this.digerButton.Name = "digerButton";
            this.digerButton.Size = new System.Drawing.Size(186, 150);
            this.digerButton.TabIndex = 3;
            this.digerButton.Text = "Diğer";
            this.digerButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.digerButton);
            this.Controls.Add(this.mrnaButton);
            this.Controls.Add(this.atifButton);
            this.Controls.Add(this.inaktifButton);
            this.Name = "Form1";
            this.Text = "Ürün Seçimi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inaktifButton;
        private System.Windows.Forms.Button atifButton;
        private System.Windows.Forms.Button mrnaButton;
        private System.Windows.Forms.Button digerButton;
    }
}


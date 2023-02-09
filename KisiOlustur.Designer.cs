namespace Tekstil
{
    partial class KisiOlustur
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
            this.TxtAd = new System.Windows.Forms.Label();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.TxtOlusturAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.AutoSize = true;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(71, 75);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(66, 38);
            this.TxtAd.TabIndex = 0;
            this.TxtAd.Text = "Ad:";
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOlustur.Location = new System.Drawing.Point(115, 132);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(254, 56);
            this.BtnOlustur.TabIndex = 1;
            this.BtnOlustur.Text = "Kişi Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // TxtOlusturAd
            // 
            this.TxtOlusturAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOlusturAd.Location = new System.Drawing.Point(134, 67);
            this.TxtOlusturAd.Name = "TxtOlusturAd";
            this.TxtOlusturAd.Size = new System.Drawing.Size(235, 45);
            this.TxtOlusturAd.TabIndex = 2;
            // 
            // KisiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 294);
            this.Controls.Add(this.TxtOlusturAd);
            this.Controls.Add(this.BtnOlustur);
            this.Controls.Add(this.TxtAd);
            this.Name = "KisiOlustur";
            this.Text = "KisiOlustur";
            this.Load += new System.EventHandler(this.KisiOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtAd;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.TextBox TxtOlusturAd;
    }
}
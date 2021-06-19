
namespace BorsaUyg
{
    partial class AlisEmri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlisEmri));
            this.back = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUrun = new System.Windows.Forms.TextBox();
            this.tbMiktar = new System.Windows.Forms.TextBox();
            this.tbFiyat = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnAlisEmri = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(373, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(30, 27);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 23;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(198)))), ((int)(((byte)(235)))));
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(409, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 22;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ÜRÜN ADI: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "MİKTAR(kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "FİYAT(tl):";
            // 
            // tbUrun
            // 
            this.tbUrun.Location = new System.Drawing.Point(143, 146);
            this.tbUrun.Name = "tbUrun";
            this.tbUrun.Size = new System.Drawing.Size(100, 20);
            this.tbUrun.TabIndex = 27;
            // 
            // tbMiktar
            // 
            this.tbMiktar.Location = new System.Drawing.Point(143, 184);
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.Size = new System.Drawing.Size(100, 20);
            this.tbMiktar.TabIndex = 28;
            // 
            // tbFiyat
            // 
            this.tbFiyat.Location = new System.Drawing.Point(143, 219);
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbFiyat.TabIndex = 29;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(143, 255);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(213, 17);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İstenilen kriterler oluştuğunda haber ver.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(143, 278);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(289, 17);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "İstenilen kriterler gerçekleştiğinde alış emrini gerçekleştir.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnAlisEmri
            // 
            this.btnAlisEmri.Location = new System.Drawing.Point(143, 314);
            this.btnAlisEmri.Name = "btnAlisEmri";
            this.btnAlisEmri.Size = new System.Drawing.Size(130, 27);
            this.btnAlisEmri.TabIndex = 32;
            this.btnAlisEmri.Text = "ALIŞ EMRİ OLUŞTUR";
            this.btnAlisEmri.UseVisualStyleBackColor = true;
            this.btnAlisEmri.Click += new System.EventHandler(this.btnAlisEmri_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "ALIŞ EMRİ VERMEK İSTEDİĞİNİZ ÜRÜNÜN BİLGİLERİNİ GİRİNİZ";
            // 
            // AlisEmri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAlisEmri);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.tbMiktar);
            this.Controls.Add(this.tbUrun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlisEmri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlişEmri";
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUrun;
        private System.Windows.Forms.TextBox tbMiktar;
        private System.Windows.Forms.TextBox tbFiyat;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnAlisEmri;
        private System.Windows.Forms.Label label4;
    }
}
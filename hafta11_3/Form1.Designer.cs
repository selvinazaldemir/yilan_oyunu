
namespace hafta11_3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PB_1 = new System.Windows.Forms.PictureBox();
            this.pb_canli = new System.Windows.Forms.PictureBox();
            this.pb_Yildiz = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lb_puan = new System.Windows.Forms.Label();
            this.lb_sure = new System.Windows.Forms.Label();
            this.lb_kalan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_canli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Yildiz)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_1
            // 
            this.PB_1.Location = new System.Drawing.Point(11, 43);
            this.PB_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PB_1.Name = "PB_1";
            this.PB_1.Size = new System.Drawing.Size(472, 311);
            this.PB_1.TabIndex = 0;
            this.PB_1.TabStop = false;
            // 
            // pb_canli
            // 
            this.pb_canli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_canli.BackgroundImage")));
            this.pb_canli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_canli.Location = new System.Drawing.Point(11, 43);
            this.pb_canli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_canli.Name = "pb_canli";
            this.pb_canli.Size = new System.Drawing.Size(49, 53);
            this.pb_canli.TabIndex = 1;
            this.pb_canli.TabStop = false;
            // 
            // pb_Yildiz
            // 
            this.pb_Yildiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Yildiz.BackgroundImage")));
            this.pb_Yildiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Yildiz.Location = new System.Drawing.Point(76, 43);
            this.pb_Yildiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Yildiz.Name = "pb_Yildiz";
            this.pb_Yildiz.Size = new System.Drawing.Size(38, 41);
            this.pb_Yildiz.TabIndex = 2;
            this.pb_Yildiz.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lb_puan
            // 
            this.lb_puan.AutoSize = true;
            this.lb_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_puan.Location = new System.Drawing.Point(22, 7);
            this.lb_puan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_puan.Name = "lb_puan";
            this.lb_puan.Size = new System.Drawing.Size(85, 24);
            this.lb_puan.TabIndex = 3;
            this.lb_puan.Text = "Puan = 0";
            // 
            // lb_sure
            // 
            this.lb_sure.AutoSize = true;
            this.lb_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sure.Location = new System.Drawing.Point(184, 7);
            this.lb_sure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sure.Name = "lb_sure";
            this.lb_sure.Size = new System.Drawing.Size(101, 24);
            this.lb_sure.TabIndex = 4;
            this.lb_sure.Text = "Süre = 100";
            // 
            // lb_kalan
            // 
            this.lb_kalan.AutoSize = true;
            this.lb_kalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_kalan.Location = new System.Drawing.Point(346, 7);
            this.lb_kalan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_kalan.Name = "lb_kalan";
            this.lb_kalan.Size = new System.Drawing.Size(143, 24);
            this.lb_kalan.TabIndex = 5;
            this.lb_kalan.Text = "Kalan Süre = 60";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(496, 365);
            this.Controls.Add(this.lb_kalan);
            this.Controls.Add(this.lb_sure);
            this.Controls.Add(this.lb_puan);
            this.Controls.Add(this.pb_Yildiz);
            this.Controls.Add(this.pb_canli);
            this.Controls.Add(this.PB_1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "OYUN UYGULAMASI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PB_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_canli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Yildiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_1;
        private System.Windows.Forms.PictureBox pb_canli;
        private System.Windows.Forms.PictureBox pb_Yildiz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lb_puan;
        private System.Windows.Forms.Label lb_sure;
        private System.Windows.Forms.Label lb_kalan;
    }
}


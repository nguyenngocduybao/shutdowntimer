namespace shutdowntimer
{
    partial class Form1
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
            this.lb_Shutdown = new System.Windows.Forms.Label();
            this.lb_Restart = new System.Windows.Forms.Label();
            this.lb_Sleep = new System.Windows.Forms.Label();
            this.lb_Time = new System.Windows.Forms.Label();
            this.numeric_Gio = new System.Windows.Forms.NumericUpDown();
            this.numeric_Phut = new System.Windows.Forms.NumericUpDown();
            this.numeric_Giay = new System.Windows.Forms.NumericUpDown();
            this.pic_Sleep = new System.Windows.Forms.PictureBox();
            this.pic_Restart = new System.Windows.Forms.PictureBox();
            this.pic_Shutdown = new System.Windows.Forms.PictureBox();
            this.lb_Gio = new System.Windows.Forms.Label();
            this.lb_Phut = new System.Windows.Forms.Label();
            this.lb_Giay = new System.Windows.Forms.Label();
            this.btn_ShutDown = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Gio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Phut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Giay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Shutdown)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Shutdown
            // 
            this.lb_Shutdown.AutoSize = true;
            this.lb_Shutdown.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Shutdown.ForeColor = System.Drawing.Color.Lime;
            this.lb_Shutdown.Location = new System.Drawing.Point(72, 35);
            this.lb_Shutdown.Name = "lb_Shutdown";
            this.lb_Shutdown.Size = new System.Drawing.Size(97, 20);
            this.lb_Shutdown.TabIndex = 3;
            this.lb_Shutdown.Text = "Tắt máy liền.";
            // 
            // lb_Restart
            // 
            this.lb_Restart.AutoSize = true;
            this.lb_Restart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Restart.ForeColor = System.Drawing.Color.Lime;
            this.lb_Restart.Location = new System.Drawing.Point(72, 188);
            this.lb_Restart.Name = "lb_Restart";
            this.lb_Restart.Size = new System.Drawing.Size(104, 20);
            this.lb_Restart.TabIndex = 4;
            this.lb_Restart.Text = "Restart ngay.";
            // 
            // lb_Sleep
            // 
            this.lb_Sleep.AutoSize = true;
            this.lb_Sleep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Sleep.ForeColor = System.Drawing.Color.Lime;
            this.lb_Sleep.Location = new System.Drawing.Point(72, 358);
            this.lb_Sleep.Name = "lb_Sleep";
            this.lb_Sleep.Size = new System.Drawing.Size(73, 20);
            this.lb_Sleep.TabIndex = 5;
            this.lb_Sleep.Text = "Ngủ gấp.";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Time.ForeColor = System.Drawing.Color.Lime;
            this.lb_Time.Location = new System.Drawing.Point(287, 221);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(158, 20);
            this.lb_Time.TabIndex = 7;
            this.lb_Time.Text = "Hẹn giờ: Tắt máy sau";
            // 
            // numeric_Gio
            // 
            this.numeric_Gio.Location = new System.Drawing.Point(291, 257);
            this.numeric_Gio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_Gio.Name = "numeric_Gio";
            this.numeric_Gio.Size = new System.Drawing.Size(66, 26);
            this.numeric_Gio.TabIndex = 8;
            // 
            // numeric_Phut
            // 
            this.numeric_Phut.Location = new System.Drawing.Point(291, 305);
            this.numeric_Phut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numeric_Phut.Name = "numeric_Phut";
            this.numeric_Phut.Size = new System.Drawing.Size(66, 26);
            this.numeric_Phut.TabIndex = 9;
            this.numeric_Phut.ValueChanged += new System.EventHandler(this.numeric_Phut_ValueChanged);
            // 
            // numeric_Giay
            // 
            this.numeric_Giay.Location = new System.Drawing.Point(291, 352);
            this.numeric_Giay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numeric_Giay.Name = "numeric_Giay";
            this.numeric_Giay.Size = new System.Drawing.Size(66, 26);
            this.numeric_Giay.TabIndex = 10;
            this.numeric_Giay.ValueChanged += new System.EventHandler(this.numeric_Giay_ValueChanged);
            // 
            // pic_Sleep
            // 
            this.pic_Sleep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_Sleep.Image = global::shutdowntimer.Properties.Resources.Windows_Stand_By_icon;
            this.pic_Sleep.Location = new System.Drawing.Point(76, 381);
            this.pic_Sleep.Name = "pic_Sleep";
            this.pic_Sleep.Size = new System.Drawing.Size(100, 100);
            this.pic_Sleep.TabIndex = 2;
            this.pic_Sleep.TabStop = false;
            this.pic_Sleep.Click += new System.EventHandler(this.pic_Sleep_Click);
            // 
            // pic_Restart
            // 
            this.pic_Restart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_Restart.Image = global::shutdowntimer.Properties.Resources.Restart;
            this.pic_Restart.Location = new System.Drawing.Point(76, 211);
            this.pic_Restart.Name = "pic_Restart";
            this.pic_Restart.Size = new System.Drawing.Size(100, 100);
            this.pic_Restart.TabIndex = 1;
            this.pic_Restart.TabStop = false;
            this.pic_Restart.Click += new System.EventHandler(this.pic_Restart_Click);
            // 
            // pic_Shutdown
            // 
            this.pic_Shutdown.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pic_Shutdown.Image = global::shutdowntimer.Properties.Resources.ShutDown;
            this.pic_Shutdown.Location = new System.Drawing.Point(76, 58);
            this.pic_Shutdown.Name = "pic_Shutdown";
            this.pic_Shutdown.Size = new System.Drawing.Size(100, 100);
            this.pic_Shutdown.TabIndex = 0;
            this.pic_Shutdown.TabStop = false;
            this.pic_Shutdown.Click += new System.EventHandler(this.pic_Shutdown_Click);
            // 
            // lb_Gio
            // 
            this.lb_Gio.AutoSize = true;
            this.lb_Gio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Gio.ForeColor = System.Drawing.Color.Lime;
            this.lb_Gio.Location = new System.Drawing.Point(374, 263);
            this.lb_Gio.Name = "lb_Gio";
            this.lb_Gio.Size = new System.Drawing.Size(34, 20);
            this.lb_Gio.TabIndex = 11;
            this.lb_Gio.Text = "Giờ";
            // 
            // lb_Phut
            // 
            this.lb_Phut.AutoSize = true;
            this.lb_Phut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Phut.ForeColor = System.Drawing.Color.Lime;
            this.lb_Phut.Location = new System.Drawing.Point(374, 311);
            this.lb_Phut.Name = "lb_Phut";
            this.lb_Phut.Size = new System.Drawing.Size(42, 20);
            this.lb_Phut.TabIndex = 12;
            this.lb_Phut.Text = "Phút";
            // 
            // lb_Giay
            // 
            this.lb_Giay.AutoSize = true;
            this.lb_Giay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Giay.ForeColor = System.Drawing.Color.Lime;
            this.lb_Giay.Location = new System.Drawing.Point(374, 354);
            this.lb_Giay.Name = "lb_Giay";
            this.lb_Giay.Size = new System.Drawing.Size(41, 20);
            this.lb_Giay.TabIndex = 13;
            this.lb_Giay.Text = "Giây";
            // 
            // btn_ShutDown
            // 
            this.btn_ShutDown.Location = new System.Drawing.Point(291, 394);
            this.btn_ShutDown.Name = "btn_ShutDown";
            this.btn_ShutDown.Size = new System.Drawing.Size(125, 36);
            this.btn_ShutDown.TabIndex = 14;
            this.btn_ShutDown.Text = "Shut down";
            this.btn_ShutDown.UseVisualStyleBackColor = true;
            this.btn_ShutDown.Click += new System.EventHandler(this.btn_ShutDown_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(291, 445);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(125, 36);
            this.btn_Restart.TabIndex = 15;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(457, 445);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(111, 36);
            this.btn_Huy.TabIndex = 16;
            this.btn_Huy.Text = "Hủy lệnh";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 547);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.btn_ShutDown);
            this.Controls.Add(this.lb_Giay);
            this.Controls.Add(this.lb_Phut);
            this.Controls.Add(this.lb_Gio);
            this.Controls.Add(this.numeric_Giay);
            this.Controls.Add(this.numeric_Phut);
            this.Controls.Add(this.numeric_Gio);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.lb_Sleep);
            this.Controls.Add(this.lb_Restart);
            this.Controls.Add(this.lb_Shutdown);
            this.Controls.Add(this.pic_Sleep);
            this.Controls.Add(this.pic_Restart);
            this.Controls.Add(this.pic_Shutdown);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Gio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Phut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Giay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Shutdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Shutdown;
        private System.Windows.Forms.PictureBox pic_Restart;
        private System.Windows.Forms.PictureBox pic_Sleep;
        private System.Windows.Forms.Label lb_Shutdown;
        private System.Windows.Forms.Label lb_Restart;
        private System.Windows.Forms.Label lb_Sleep;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.NumericUpDown numeric_Gio;
        private System.Windows.Forms.NumericUpDown numeric_Phut;
        private System.Windows.Forms.NumericUpDown numeric_Giay;
        private System.Windows.Forms.Label lb_Gio;
        private System.Windows.Forms.Label lb_Phut;
        private System.Windows.Forms.Label lb_Giay;
        private System.Windows.Forms.Button btn_ShutDown;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Huy;
    }
}


namespace TH9
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.btntaomang = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mởFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKiemTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaoMang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số N";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(276, 139);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(222, 30);
            this.txtnhap.TabIndex = 1;
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Location = new System.Drawing.Point(99, 215);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(225, 57);
            this.btnkiemtra.TabIndex = 2;
            this.btnkiemtra.Text = "Kiểm tra số hoàn hảo";
            this.btnkiemtra.UseVisualStyleBackColor = true;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // btntaomang
            // 
            this.btntaomang.Location = new System.Drawing.Point(427, 215);
            this.btntaomang.Name = "btntaomang";
            this.btntaomang.Size = new System.Drawing.Size(168, 57);
            this.btntaomang.TabIndex = 3;
            this.btntaomang.Text = "Tạo mảng";
            this.btntaomang.UseVisualStyleBackColor = true;
            this.btntaomang.Click += new System.EventHandler(this.btntaomang_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(169, 303);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(155, 57);
            this.btnlamlai.TabIndex = 4;
            this.btnlamlai.Text = "Làm lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(427, 303);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(147, 57);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFromToolStripMenuItem,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mởFromToolStripMenuItem
            // 
            this.mởFromToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKiemTra,
            this.mnuTaoMang});
            this.mởFromToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mởFromToolStripMenuItem.Name = "mởFromToolStripMenuItem";
            this.mởFromToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.mởFromToolStripMenuItem.Text = "Mở from";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(69, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuKiemTra
            // 
            this.mnuKiemTra.Name = "mnuKiemTra";
            this.mnuKiemTra.Size = new System.Drawing.Size(261, 26);
            this.mnuKiemTra.Text = "Kiểm tra số hoàn hảo";
            this.mnuKiemTra.Click += new System.EventHandler(this.mnuKiemTra_Click);
            // 
            // mnuTaoMang
            // 
            this.mnuTaoMang.Name = "mnuTaoMang";
            this.mnuTaoMang.Size = new System.Drawing.Size(261, 26);
            this.mnuTaoMang.Text = "Tạo mảng";
            this.mnuTaoMang.Click += new System.EventHandler(this.mnuTaoMang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 619);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btntaomang);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form Chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.Button btntaomang;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mởFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuKiemTra;
        private System.Windows.Forms.ToolStripMenuItem mnuTaoMang;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}


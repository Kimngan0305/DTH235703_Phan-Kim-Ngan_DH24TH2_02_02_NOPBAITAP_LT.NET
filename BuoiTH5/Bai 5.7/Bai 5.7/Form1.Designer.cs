namespace Bai_5._7
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttongmang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttongchan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttongle = new System.Windows.Forms.TextBox();
            this.btntong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdotang = new System.Windows.Forms.RadioButton();
            this.rdogiam = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.txtso = new System.Windows.Forms.TextBox();
            this.btnthaythe = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(330, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng Số Nguyên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mảng :";
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(129, 76);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(477, 30);
            this.txtnhap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết quả :";
            this.label3.UseMnemonic = false;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(129, 132);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(477, 30);
            this.txtkq.TabIndex = 4;
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(671, 74);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(136, 40);
            this.btnxuat.TabIndex = 5;
            this.btnxuat.Text = "Xuất mảng";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(671, 125);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(136, 43);
            this.btnlamlai.TabIndex = 6;
            this.btnlamlai.Text = "Làm lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntong);
            this.groupBox1.Controls.Add(this.txttongle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttongchan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttongmang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng mảng ";
            // 
            // txttongmang
            // 
            this.txttongmang.Location = new System.Drawing.Point(119, 29);
            this.txttongmang.Name = "txttongmang";
            this.txttongmang.Size = new System.Drawing.Size(100, 30);
            this.txttongmang.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tổng chẵn ";
            // 
            // txttongchan
            // 
            this.txttongchan.Location = new System.Drawing.Point(119, 65);
            this.txttongchan.Name = "txttongchan";
            this.txttongchan.Size = new System.Drawing.Size(100, 30);
            this.txttongchan.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng lẻ ";
            // 
            // txttongle
            // 
            this.txttongle.Location = new System.Drawing.Point(119, 109);
            this.txttongle.Name = "txttongle";
            this.txttongle.Size = new System.Drawing.Size(100, 30);
            this.txttongle.TabIndex = 8;
            // 
            // btntong
            // 
            this.btntong.Location = new System.Drawing.Point(249, 35);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(75, 99);
            this.btntong.TabIndex = 8;
            this.btntong.Text = "Tổng";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntim);
            this.groupBox2.Controls.Add(this.txtmin);
            this.groupBox2.Controls.Add(this.txtmax);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(445, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 152);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Max Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Min";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(109, 36);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(100, 30);
            this.txtmax.TabIndex = 2;
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(109, 84);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(100, 30);
            this.txtmin.TabIndex = 3;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(255, 37);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 77);
            this.btntim.TabIndex = 4;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.rdogiam);
            this.groupBox3.Controls.Add(this.rdotang);
            this.groupBox3.Location = new System.Drawing.Point(17, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 138);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sắp xếp";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnthaythe);
            this.groupBox4.Controls.Add(this.txtso);
            this.groupBox4.Controls.Add(this.txtvitri);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(435, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 138);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thay thế";
            // 
            // rdotang
            // 
            this.rdotang.AutoSize = true;
            this.rdotang.Location = new System.Drawing.Point(27, 40);
            this.rdotang.Name = "rdotang";
            this.rdotang.Size = new System.Drawing.Size(131, 26);
            this.rdotang.TabIndex = 0;
            this.rdotang.TabStop = true;
            this.rdotang.Text = "Sắp xếp tăng";
            this.rdotang.UseVisualStyleBackColor = true;
            // 
            // rdogiam
            // 
            this.rdogiam.AutoSize = true;
            this.rdogiam.Location = new System.Drawing.Point(24, 84);
            this.rdogiam.Name = "rdogiam";
            this.rdogiam.Size = new System.Drawing.Size(137, 26);
            this.rdogiam.TabIndex = 1;
            this.rdogiam.TabStop = true;
            this.rdogiam.Text = "Sắp xếp giảm";
            this.rdogiam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 81);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sắp xếp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Vị trí thay thế";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số thay thế";
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(129, 34);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(100, 30);
            this.txtvitri.TabIndex = 2;
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(129, 86);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 30);
            this.txtso.TabIndex = 3;
            // 
            // btnthaythe
            // 
            this.btnthaythe.Location = new System.Drawing.Point(267, 34);
            this.btnthaythe.Name = "btnthaythe";
            this.btnthaythe.Size = new System.Drawing.Size(75, 82);
            this.btnthaythe.TabIndex = 0;
            this.btnthaythe.Text = "Thay thế";
            this.btnthaythe.UseVisualStyleBackColor = true;
            this.btnthaythe.Click += new System.EventHandler(this.btnthaythe_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(346, 521);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(122, 34);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 567);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mảng Số Nguyên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttongchan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttongmang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.TextBox txttongle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdogiam;
        private System.Windows.Forms.RadioButton rdotang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnthaythe;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnthoat;
    }
}


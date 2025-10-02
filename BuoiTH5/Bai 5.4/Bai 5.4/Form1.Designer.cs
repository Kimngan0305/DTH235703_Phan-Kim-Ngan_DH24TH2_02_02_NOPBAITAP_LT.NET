namespace Bai_5._4
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radchunhat = new System.Windows.Forms.RadioButton();
            this.radtamgiac = new System.Windows.Forms.RadioButton();
            this.radvuong = new System.Windows.Forms.RadioButton();
            this.radtron = new System.Windows.Forms.RadioButton();
            this.btnthuchien = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.lbla = new System.Windows.Forms.Label();
            this.txtchieurong = new System.Windows.Forms.TextBox();
            this.lblchieurong = new System.Windows.Forms.Label();
            this.txtchieudai = new System.Windows.Forms.TextBox();
            this.lblchieudai = new System.Windows.Forms.Label();
            this.txtbankinh = new System.Windows.Forms.TextBox();
            this.lblbankinh = new System.Windows.Forms.Label();
            this.txtcanh = new System.Windows.Forms.TextBox();
            this.lblcanh = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(196, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Chu Vi và Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(255, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hình Tròn - Hình Vuông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(239, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hình Tam Giác - Hình Chữ Nhật";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radchunhat);
            this.groupBox1.Controls.Add(this.radtamgiac);
            this.groupBox1.Controls.Add(this.radvuong);
            this.groupBox1.Controls.Add(this.radtron);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(190, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // radchunhat
            // 
            this.radchunhat.AutoSize = true;
            this.radchunhat.Location = new System.Drawing.Point(204, 79);
            this.radchunhat.Name = "radchunhat";
            this.radchunhat.Size = new System.Drawing.Size(149, 26);
            this.radchunhat.TabIndex = 3;
            this.radchunhat.TabStop = true;
            this.radchunhat.Text = "Hình Chữ Nhật";
            this.radchunhat.UseVisualStyleBackColor = true;
            this.radchunhat.CheckedChanged += new System.EventHandler(this.radchunhat_CheckedChanged);
            // 
            // radtamgiac
            // 
            this.radtamgiac.AutoSize = true;
            this.radtamgiac.Location = new System.Drawing.Point(202, 29);
            this.radtamgiac.Name = "radtamgiac";
            this.radtamgiac.Size = new System.Drawing.Size(151, 26);
            this.radtamgiac.TabIndex = 2;
            this.radtamgiac.TabStop = true;
            this.radtamgiac.Text = "Hình Tam Giác";
            this.radtamgiac.UseVisualStyleBackColor = true;
            this.radtamgiac.CheckedChanged += new System.EventHandler(this.radtamgiac_CheckedChanged);
            // 
            // radvuong
            // 
            this.radvuong.AutoSize = true;
            this.radvuong.Location = new System.Drawing.Point(13, 75);
            this.radvuong.Name = "radvuong";
            this.radvuong.Size = new System.Drawing.Size(123, 26);
            this.radvuong.TabIndex = 1;
            this.radvuong.TabStop = true;
            this.radvuong.Text = "Hình Vuông";
            this.radvuong.UseVisualStyleBackColor = true;
            this.radvuong.CheckedChanged += new System.EventHandler(this.radvuong_CheckedChanged);
            // 
            // radtron
            // 
            this.radtron.AutoSize = true;
            this.radtron.Location = new System.Drawing.Point(13, 29);
            this.radtron.Name = "radtron";
            this.radtron.Size = new System.Drawing.Size(111, 26);
            this.radtron.TabIndex = 0;
            this.radtron.TabStop = true;
            this.radtron.Text = "Hình Tròn";
            this.radtron.UseVisualStyleBackColor = true;
            this.radtron.CheckedChanged += new System.EventHandler(this.radtron_CheckedChanged);
            // 
            // btnthuchien
            // 
            this.btnthuchien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthuchien.Location = new System.Drawing.Point(190, 365);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(111, 42);
            this.btnthuchien.TabIndex = 4;
            this.btnthuchien.Text = "Thực Hiện";
            this.btnthuchien.UseVisualStyleBackColor = true;
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreset.Location = new System.Drawing.Point(325, 365);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(115, 42);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(470, 365);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(117, 42);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtc);
            this.groupBox2.Controls.Add(this.lblc);
            this.groupBox2.Controls.Add(this.txtb);
            this.groupBox2.Controls.Add(this.lblb);
            this.groupBox2.Controls.Add(this.txta);
            this.groupBox2.Controls.Add(this.lbla);
            this.groupBox2.Controls.Add(this.txtchieurong);
            this.groupBox2.Controls.Add(this.lblchieurong);
            this.groupBox2.Controls.Add(this.txtchieudai);
            this.groupBox2.Controls.Add(this.lblchieudai);
            this.groupBox2.Controls.Add(this.txtbankinh);
            this.groupBox2.Controls.Add(this.lblbankinh);
            this.groupBox2.Controls.Add(this.txtcanh);
            this.groupBox2.Controls.Add(this.lblcanh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(705, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 253);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "thông tin";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(784, 344);
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(412, 22);
            this.txtkq.TabIndex = 15;
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblkq.Location = new System.Drawing.Point(701, 343);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(77, 22);
            this.lblkq.TabIndex = 14;
            this.lblkq.Text = "Kết quả:";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(308, 132);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 30);
            this.txtc.TabIndex = 13;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(267, 133);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(29, 22);
            this.lblc.TabIndex = 12;
            this.lblc.Text = "C:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(302, 79);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 30);
            this.txtb.TabIndex = 11;
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(271, 87);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(29, 22);
            this.lblb.TabIndex = 10;
            this.lblb.Text = "B:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(302, 28);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 30);
            this.txta.TabIndex = 9;
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(266, 31);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(30, 22);
            this.lbla.TabIndex = 8;
            this.lbla.Text = "A:";
            // 
            // txtchieurong
            // 
            this.txtchieurong.Location = new System.Drawing.Point(114, 183);
            this.txtchieurong.Name = "txtchieurong";
            this.txtchieurong.Size = new System.Drawing.Size(100, 30);
            this.txtchieurong.TabIndex = 7;
            // 
            // lblchieurong
            // 
            this.lblchieurong.AutoSize = true;
            this.lblchieurong.Location = new System.Drawing.Point(6, 186);
            this.lblchieurong.Name = "lblchieurong";
            this.lblchieurong.Size = new System.Drawing.Size(102, 22);
            this.lblchieurong.TabIndex = 6;
            this.lblchieurong.Text = "Chiều rộng:";
            // 
            // txtchieudai
            // 
            this.txtchieudai.Location = new System.Drawing.Point(97, 130);
            this.txtchieudai.Name = "txtchieudai";
            this.txtchieudai.Size = new System.Drawing.Size(100, 30);
            this.txtchieudai.TabIndex = 5;
            // 
            // lblchieudai
            // 
            this.lblchieudai.AutoSize = true;
            this.lblchieudai.Location = new System.Drawing.Point(6, 140);
            this.lblchieudai.Name = "lblchieudai";
            this.lblchieudai.Size = new System.Drawing.Size(92, 22);
            this.lblchieudai.TabIndex = 4;
            this.lblchieudai.Text = "Chiều dài:";
            // 
            // txtbankinh
            // 
            this.txtbankinh.Location = new System.Drawing.Point(97, 80);
            this.txtbankinh.Name = "txtbankinh";
            this.txtbankinh.Size = new System.Drawing.Size(100, 30);
            this.txtbankinh.TabIndex = 3;
            // 
            // lblbankinh
            // 
            this.lblbankinh.AutoSize = true;
            this.lblbankinh.Location = new System.Drawing.Point(6, 88);
            this.lblbankinh.Name = "lblbankinh";
            this.lblbankinh.Size = new System.Drawing.Size(85, 22);
            this.lblbankinh.TabIndex = 2;
            this.lblbankinh.Text = "Bán kính:";
            // 
            // txtcanh
            // 
            this.txtcanh.Location = new System.Drawing.Point(79, 32);
            this.txtcanh.Name = "txtcanh";
            this.txtcanh.Size = new System.Drawing.Size(100, 30);
            this.txtcanh.TabIndex = 1;
            // 
            // lblcanh
            // 
            this.lblcanh.AutoSize = true;
            this.lblcanh.Location = new System.Drawing.Point(17, 40);
            this.lblcanh.Name = "lblcanh";
            this.lblcanh.Size = new System.Drawing.Size(56, 22);
            this.lblcanh.TabIndex = 0;
            this.lblcanh.Text = "Cạnh:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 485);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tìm Chu Vi và Diện Tích";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radchunhat;
        private System.Windows.Forms.RadioButton radtamgiac;
        private System.Windows.Forms.RadioButton radvuong;
        private System.Windows.Forms.RadioButton radtron;
        private System.Windows.Forms.Button btnthuchien;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblcanh;
        private System.Windows.Forms.TextBox txtchieurong;
        private System.Windows.Forms.Label lblchieurong;
        private System.Windows.Forms.TextBox txtchieudai;
        private System.Windows.Forms.Label lblchieudai;
        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.TextBox txtcanh;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lbla;
    }
}


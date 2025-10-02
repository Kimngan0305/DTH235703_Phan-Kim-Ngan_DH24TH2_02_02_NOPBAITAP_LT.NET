namespace Bai_5._5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.btndem = new System.Windows.Forms.Button();
            this.btntong = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btntang = new System.Windows.Forms.Button();
            this.btnsaptang = new System.Windows.Forms.Button();
            this.btnsapgiam = new System.Windows.Forms.Button();
            this.lblmang = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblmang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(73, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mảng Gốc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblkq);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(73, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // btnxuat
            // 
            this.btnxuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxuat.Location = new System.Drawing.Point(73, 242);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(278, 40);
            this.btnxuat.TabIndex = 2;
            this.btnxuat.Text = "Xuất mảng ngẫu nhiên";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btntinhtong
            // 
            this.btntinhtong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntinhtong.Location = new System.Drawing.Point(73, 288);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(278, 40);
            this.btntinhtong.TabIndex = 3;
            this.btntinhtong.Text = "Tính tổng giá trị mảng";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.btntinhtong_Click);
            // 
            // btndem
            // 
            this.btndem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btndem.Location = new System.Drawing.Point(73, 334);
            this.btndem.Name = "btndem";
            this.btndem.Size = new System.Drawing.Size(278, 40);
            this.btndem.TabIndex = 4;
            this.btndem.Text = "Đếm số phần tử lẻ";
            this.btndem.UseVisualStyleBackColor = true;
            this.btndem.Click += new System.EventHandler(this.btndem_Click);
            // 
            // btntong
            // 
            this.btntong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntong.Location = new System.Drawing.Point(73, 380);
            this.btntong.Name = "btntong";
            this.btntong.Size = new System.Drawing.Size(278, 40);
            this.btntong.TabIndex = 5;
            this.btntong.Text = "Tổng giá trị phần tử lẻ";
            this.btntong.UseVisualStyleBackColor = true;
            this.btntong.Click += new System.EventHandler(this.btntong_Click);
            // 
            // btntim
            // 
            this.btntim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btntim.Location = new System.Drawing.Point(409, 242);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(279, 40);
            this.btntim.TabIndex = 6;
            this.btntim.Text = "Tìm phần tử nhỏ nhất";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btntang
            // 
            this.btntang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntang.Location = new System.Drawing.Point(409, 288);
            this.btntang.Name = "btntang";
            this.btntang.Size = new System.Drawing.Size(279, 40);
            this.btntang.TabIndex = 7;
            this.btntang.Text = "Tăng mỗi Ptử mảng lên 2";
            this.btntang.UseVisualStyleBackColor = true;
            this.btntang.Click += new System.EventHandler(this.btntang_Click);
            // 
            // btnsaptang
            // 
            this.btnsaptang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsaptang.Location = new System.Drawing.Point(409, 334);
            this.btnsaptang.Name = "btnsaptang";
            this.btnsaptang.Size = new System.Drawing.Size(279, 40);
            this.btnsaptang.TabIndex = 8;
            this.btnsaptang.Text = "Sắp mảng tăng";
            this.btnsaptang.UseVisualStyleBackColor = true;
            this.btnsaptang.Click += new System.EventHandler(this.btnsaptang_Click);
            // 
            // btnsapgiam
            // 
            this.btnsapgiam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsapgiam.Location = new System.Drawing.Point(409, 380);
            this.btnsapgiam.Name = "btnsapgiam";
            this.btnsapgiam.Size = new System.Drawing.Size(279, 40);
            this.btnsapgiam.TabIndex = 9;
            this.btnsapgiam.Text = "Sắp mảng giảm";
            this.btnsapgiam.UseVisualStyleBackColor = true;
            this.btnsapgiam.Click += new System.EventHandler(this.btnsapgiam_Click);
            // 
            // lblmang
            // 
            this.lblmang.BackColor = System.Drawing.Color.White;
            this.lblmang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmang.Location = new System.Drawing.Point(32, 36);
            this.lblmang.Name = "lblmang";
            this.lblmang.Size = new System.Drawing.Size(539, 29);
            this.lblmang.TabIndex = 0;
            this.lblmang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblkq
            // 
            this.lblkq.BackColor = System.Drawing.Color.White;
            this.lblkq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblkq.Location = new System.Drawing.Point(32, 37);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(539, 33);
            this.lblkq.TabIndex = 0;
            this.lblkq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsapgiam);
            this.Controls.Add(this.btnsaptang);
            this.Controls.Add(this.btntang);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btntong);
            this.Controls.Add(this.btndem);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Working With Array";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Button btndem;
        private System.Windows.Forms.Button btntong;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btntang;
        private System.Windows.Forms.Button btnsaptang;
        private System.Windows.Forms.Label lblmang;
        private System.Windows.Forms.Button btnsapgiam;
        private System.Windows.Forms.Label lblkq;
    }
}


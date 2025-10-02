namespace TH9
{
    partial class Form3
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
            this.txtmang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsochan = new System.Windows.Forms.TextBox();
            this.btndong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(196, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các phần tử của mảng";
            // 
            // txtmang
            // 
            this.txtmang.BackColor = System.Drawing.Color.DarkGray;
            this.txtmang.Location = new System.Drawing.Point(134, 70);
            this.txtmang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmang.Name = "txtmang";
            this.txtmang.Size = new System.Drawing.Size(308, 30);
            this.txtmang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Các số chẵn trong mảng";
            // 
            // txtsochan
            // 
            this.txtsochan.Location = new System.Drawing.Point(134, 168);
            this.txtsochan.Name = "txtsochan";
            this.txtsochan.Size = new System.Drawing.Size(308, 30);
            this.txtsochan.TabIndex = 3;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(222, 229);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(130, 42);
            this.btndong.TabIndex = 4;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 362);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.txtsochan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Tạo mảng";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsochan;
        private System.Windows.Forms.Button btndong;
    }
}
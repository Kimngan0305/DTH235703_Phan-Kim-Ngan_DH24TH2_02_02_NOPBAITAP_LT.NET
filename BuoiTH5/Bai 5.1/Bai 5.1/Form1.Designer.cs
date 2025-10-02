namespace Bai_5._1
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.lblkiemtra = new System.Windows.Forms.Label();
            this.txtKq1 = new System.Windows.Forms.TextBox();
            this.lbltim = new System.Windows.Forms.Label();
            this.txtKq2 = new System.Windows.Forms.TextBox();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểm Tra Và Tìm SNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(97, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(180, 119);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(445, 22);
            this.txtN.TabIndex = 2;
            // 
            // lblkiemtra
            // 
            this.lblkiemtra.AutoSize = true;
            this.lblkiemtra.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblkiemtra.Location = new System.Drawing.Point(48, 166);
            this.lblkiemtra.Name = "lblkiemtra";
            this.lblkiemtra.Size = new System.Drawing.Size(126, 22);
            this.lblkiemtra.TabIndex = 3;
            this.lblkiemtra.Text = "Kiểm tra SNT:";
            this.lblkiemtra.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKq1
            // 
            this.txtKq1.Location = new System.Drawing.Point(180, 166);
            this.txtKq1.Multiline = true;
            this.txtKq1.Name = "txtKq1";
            this.txtKq1.ReadOnly = true;
            this.txtKq1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKq1.Size = new System.Drawing.Size(445, 22);
            this.txtKq1.TabIndex = 4;
            // 
            // lbltim
            // 
            this.lbltim.AutoSize = true;
            this.lbltim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbltim.Location = new System.Drawing.Point(-2, 211);
            this.lbltim.Name = "lbltim";
            this.lbltim.Size = new System.Drawing.Size(176, 22);
            this.lbltim.TabIndex = 5;
            this.lbltim.Text = "Tìm SNT nhỏ hơn N:";
            this.lbltim.Click += new System.EventHandler(this.lbltim_Click);
            // 
            // txtKq2
            // 
            this.txtKq2.Location = new System.Drawing.Point(180, 212);
            this.txtKq2.Multiline = true;
            this.txtKq2.Name = "txtKq2";
            this.txtKq2.ReadOnly = true;
            this.txtKq2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKq2.Size = new System.Drawing.Size(445, 22);
            this.txtKq2.TabIndex = 6;
            // 
            // btnlamlai
            // 
            this.btnlamlai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlamlai.Location = new System.Drawing.Point(142, 295);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(164, 59);
            this.btnlamlai.TabIndex = 7;
            this.btnlamlai.Text = "Làm lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(403, 300);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(189, 54);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.txtKq2);
            this.Controls.Add(this.lbltim);
            this.Controls.Add(this.txtKq1);
            this.Controls.Add(this.lblkiemtra);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KT SNT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Label lblkiemtra;
        private System.Windows.Forms.TextBox txtKq1;
        private System.Windows.Forms.Label lbltim;
        private System.Windows.Forms.TextBox txtKq2;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btnthoat;
    }
}


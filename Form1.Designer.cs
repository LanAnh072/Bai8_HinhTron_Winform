namespace Bai8_HinhTron_Winform
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
            this.txtBK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnDT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH HÌNH TRÒN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bán kính";
            // 
            // txtBK
            // 
            this.txtBK.Location = new System.Drawing.Point(115, 88);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(114, 32);
            this.txtBK.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(115, 126);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(114, 32);
            this.txtKQ.TabIndex = 2;
            // 
            // btnCV
            // 
            this.btnCV.Location = new System.Drawing.Point(12, 180);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(116, 47);
            this.btnCV.TabIndex = 3;
            this.btnCV.Text = "Chu vi";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnDT
            // 
            this.btnDT.Location = new System.Drawing.Point(134, 180);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(116, 47);
            this.btnDT.TabIndex = 4;
            this.btnDT.Text = "Diện tích";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 455);
            this.Controls.Add(this.btnDT);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnDT;
    }
}


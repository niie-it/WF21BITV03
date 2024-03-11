namespace Lab04BT2_TruyenDuLieu
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
			this.TxtSoDong = new System.Windows.Forms.TextBox();
			this.TxtSoCot = new System.Windows.Forms.TextBox();
			this.BtnKhoiTao = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số dòng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(57, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 48);
			this.label2.TabIndex = 1;
			this.label2.Text = "Số cột";
			// 
			// TxtSoDong
			// 
			this.TxtSoDong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSoDong.Location = new System.Drawing.Point(215, 58);
			this.TxtSoDong.Name = "TxtSoDong";
			this.TxtSoDong.Size = new System.Drawing.Size(328, 56);
			this.TxtSoDong.TabIndex = 2;
			// 
			// TxtSoCot
			// 
			this.TxtSoCot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSoCot.Location = new System.Drawing.Point(215, 161);
			this.TxtSoCot.Name = "TxtSoCot";
			this.TxtSoCot.Size = new System.Drawing.Size(328, 56);
			this.TxtSoCot.TabIndex = 3;
			// 
			// BtnKhoiTao
			// 
			this.BtnKhoiTao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnKhoiTao.Location = new System.Drawing.Point(604, 68);
			this.BtnKhoiTao.Name = "BtnKhoiTao";
			this.BtnKhoiTao.Size = new System.Drawing.Size(178, 131);
			this.BtnKhoiTao.TabIndex = 4;
			this.BtnKhoiTao.Text = "Khởi tạo Form";
			this.BtnKhoiTao.UseVisualStyleBackColor = true;
			this.BtnKhoiTao.Click += new System.EventHandler(this.BtnKhoiTao_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 48);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số dòng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 48);
			this.label4.TabIndex = 1;
			this.label4.Text = "Số cột";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 252);
			this.Controls.Add(this.BtnKhoiTao);
			this.Controls.Add(this.TxtSoCot);
			this.Controls.Add(this.TxtSoDong);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "NHẬP LIỆU";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtSoDong;
		private System.Windows.Forms.TextBox TxtSoCot;
		private System.Windows.Forms.Button BtnKhoiTao;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}


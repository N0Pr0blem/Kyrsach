namespace Kyrsach_nextTry
{
	partial class RegWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegWindow));
			this.button1 = new System.Windows.Forms.Button();
			this.password_tb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.login_tb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(185, 257);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Вход";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// password_tb
			// 
			this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_tb.Location = new System.Drawing.Point(155, 204);
			this.password_tb.Name = "password_tb";
			this.password_tb.PasswordChar = '*';
			this.password_tb.Size = new System.Drawing.Size(212, 34);
			this.password_tb.TabIndex = 1;
			this.password_tb.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(56, 211);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Пароль:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(56, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 28);
			this.label2.TabIndex = 4;
			this.label2.Text = "Логин:";
			// 
			// login_tb
			// 
			this.login_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.login_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_tb.Location = new System.Drawing.Point(155, 163);
			this.login_tb.Name = "login_tb";
			this.login_tb.Size = new System.Drawing.Size(212, 34);
			this.login_tb.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Bebas Neue Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(125, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(203, 48);
			this.label3.TabIndex = 5;
			this.label3.Text = "Авторизация:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.login_tb);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.password_tb);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(488, 129);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(435, 400);
			this.panel1.TabIndex = 6;
			// 
			// RegWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1426, 748);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Вход в аккаунт";
			this.Load += new System.EventHandler(this.RegWindow_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox password_tb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox login_tb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
	}
}
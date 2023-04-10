namespace Kyrsach_nextTry
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.name_lb = new System.Windows.Forms.Label();
			this.surname_lb = new System.Windows.Forms.Label();
			this.login_lb = new System.Windows.Forms.Label();
			this.password_lb = new System.Windows.Forms.Label();
			this.role_lb = new System.Windows.Forms.Label();
			this.role_cb = new System.Windows.Forms.ComboBox();
			this.name_tb = new System.Windows.Forms.TextBox();
			this.surname_tb = new System.Windows.Forms.TextBox();
			this.login_tb = new System.Windows.Forms.TextBox();
			this.password_tb = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.add_btn = new System.Windows.Forms.Button();
			this.add_new_panel = new System.Windows.Forms.Panel();
			this.persons_lv = new System.Windows.Forms.ListView();
			this.delete_btn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.show_btn = new System.Windows.Forms.Button();
			this.add_new_panel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// name_lb
			// 
			this.name_lb.AutoSize = true;
			this.name_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_lb.Location = new System.Drawing.Point(37, 90);
			this.name_lb.Name = "name_lb";
			this.name_lb.Size = new System.Drawing.Size(67, 27);
			this.name_lb.TabIndex = 0;
			this.name_lb.Text = "Name:";
			// 
			// surname_lb
			// 
			this.surname_lb.AutoSize = true;
			this.surname_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surname_lb.Location = new System.Drawing.Point(37, 131);
			this.surname_lb.Name = "surname_lb";
			this.surname_lb.Size = new System.Drawing.Size(92, 27);
			this.surname_lb.TabIndex = 0;
			this.surname_lb.Text = "Surname:";
			// 
			// login_lb
			// 
			this.login_lb.AutoSize = true;
			this.login_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_lb.Location = new System.Drawing.Point(37, 169);
			this.login_lb.Name = "login_lb";
			this.login_lb.Size = new System.Drawing.Size(61, 27);
			this.login_lb.TabIndex = 0;
			this.login_lb.Text = "Login:";
			// 
			// password_lb
			// 
			this.password_lb.AutoSize = true;
			this.password_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_lb.Location = new System.Drawing.Point(37, 214);
			this.password_lb.Name = "password_lb";
			this.password_lb.Size = new System.Drawing.Size(98, 27);
			this.password_lb.TabIndex = 0;
			this.password_lb.Text = "Password:";
			// 
			// role_lb
			// 
			this.role_lb.AutoSize = true;
			this.role_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.role_lb.Location = new System.Drawing.Point(37, 254);
			this.role_lb.Name = "role_lb";
			this.role_lb.Size = new System.Drawing.Size(55, 27);
			this.role_lb.TabIndex = 0;
			this.role_lb.Text = "Role:";
			// 
			// role_cb
			// 
			this.role_cb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.role_cb.FormattingEnabled = true;
			this.role_cb.Location = new System.Drawing.Point(183, 251);
			this.role_cb.Name = "role_cb";
			this.role_cb.Size = new System.Drawing.Size(177, 35);
			this.role_cb.TabIndex = 1;
			// 
			// name_tb
			// 
			this.name_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_tb.Location = new System.Drawing.Point(183, 90);
			this.name_tb.Name = "name_tb";
			this.name_tb.Size = new System.Drawing.Size(177, 34);
			this.name_tb.TabIndex = 2;
			// 
			// surname_tb
			// 
			this.surname_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surname_tb.Location = new System.Drawing.Point(183, 128);
			this.surname_tb.Name = "surname_tb";
			this.surname_tb.Size = new System.Drawing.Size(177, 34);
			this.surname_tb.TabIndex = 2;
			// 
			// login_tb
			// 
			this.login_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_tb.Location = new System.Drawing.Point(183, 166);
			this.login_tb.Name = "login_tb";
			this.login_tb.Size = new System.Drawing.Size(177, 34);
			this.login_tb.TabIndex = 2;
			// 
			// password_tb
			// 
			this.password_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_tb.Location = new System.Drawing.Point(183, 207);
			this.password_tb.Name = "password_tb";
			this.password_tb.Size = new System.Drawing.Size(177, 34);
			this.password_tb.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bebas Neue Regular", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(59, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(252, 52);
			this.label6.TabIndex = 0;
			this.label6.Text = "Add new person:";
			// 
			// add_btn
			// 
			this.add_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.add_btn.Location = new System.Drawing.Point(158, 308);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(80, 32);
			this.add_btn.TabIndex = 3;
			this.add_btn.Text = "Add";
			this.add_btn.UseVisualStyleBackColor = true;
			this.add_btn.Click += new System.EventHandler(this.Add_btn_Click);
			// 
			// add_new_panel
			// 
			this.add_new_panel.Controls.Add(this.role_cb);
			this.add_new_panel.Controls.Add(this.add_btn);
			this.add_new_panel.Controls.Add(this.name_lb);
			this.add_new_panel.Controls.Add(this.password_tb);
			this.add_new_panel.Controls.Add(this.label6);
			this.add_new_panel.Controls.Add(this.login_tb);
			this.add_new_panel.Controls.Add(this.surname_lb);
			this.add_new_panel.Controls.Add(this.surname_tb);
			this.add_new_panel.Controls.Add(this.login_lb);
			this.add_new_panel.Controls.Add(this.name_tb);
			this.add_new_panel.Controls.Add(this.password_lb);
			this.add_new_panel.Controls.Add(this.role_lb);
			this.add_new_panel.Location = new System.Drawing.Point(10, 12);
			this.add_new_panel.Name = "add_new_panel";
			this.add_new_panel.Size = new System.Drawing.Size(391, 358);
			this.add_new_panel.TabIndex = 4;
			// 
			// persons_lv
			// 
			this.persons_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.persons_lv.HideSelection = false;
			this.persons_lv.Location = new System.Drawing.Point(20, 12);
			this.persons_lv.Name = "persons_lv";
			this.persons_lv.Size = new System.Drawing.Size(292, 286);
			this.persons_lv.TabIndex = 5;
			this.persons_lv.UseCompatibleStateImageBehavior = false;
			this.persons_lv.View = System.Windows.Forms.View.List;
			// 
			// delete_btn
			// 
			this.delete_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete_btn.Location = new System.Drawing.Point(124, 308);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(80, 32);
			this.delete_btn.TabIndex = 4;
			this.delete_btn.Text = "Delete";
			this.delete_btn.UseVisualStyleBackColor = true;
			this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.persons_lv);
			this.panel1.Controls.Add(this.delete_btn);
			this.panel1.Location = new System.Drawing.Point(438, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(329, 358);
			this.panel1.TabIndex = 6;
			// 
			// show_btn
			// 
			this.show_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.show_btn.Location = new System.Drawing.Point(333, 396);
			this.show_btn.Name = "show_btn";
			this.show_btn.Size = new System.Drawing.Size(176, 32);
			this.show_btn.TabIndex = 4;
			this.show_btn.Text = "Show Info:";
			this.show_btn.UseVisualStyleBackColor = true;
			this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 468);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.show_btn);
			this.Controls.Add(this.add_new_panel);
			this.Name = "Form1";
			this.Text = "Admin window";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.add_new_panel.ResumeLayout(false);
			this.add_new_panel.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label name_lb;
		private System.Windows.Forms.Label surname_lb;
		private System.Windows.Forms.Label login_lb;
		private System.Windows.Forms.Label password_lb;
		private System.Windows.Forms.Label role_lb;
		private System.Windows.Forms.ComboBox role_cb;
		private System.Windows.Forms.TextBox name_tb;
		private System.Windows.Forms.TextBox surname_tb;
		private System.Windows.Forms.TextBox login_tb;
		private System.Windows.Forms.TextBox password_tb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button add_btn;
		private System.Windows.Forms.Panel add_new_panel;
		private System.Windows.Forms.ListView persons_lv;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button show_btn;
	}
}


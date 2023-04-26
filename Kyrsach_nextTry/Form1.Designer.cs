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
			this.users_info_panel = new System.Windows.Forms.Panel();
			this.close_users_info_panel_btn = new System.Windows.Forms.Button();
			this.users_password_tb = new System.Windows.Forms.TextBox();
			this.users_access_tb = new System.Windows.Forms.TextBox();
			this.delete_btn = new System.Windows.Forms.Button();
			this.users_login_tb = new System.Windows.Forms.TextBox();
			this.users_surname_tb = new System.Windows.Forms.TextBox();
			this.users_name_tb = new System.Windows.Forms.TextBox();
			this.users_login_lb = new System.Windows.Forms.Label();
			this.users_password_lb = new System.Windows.Forms.Label();
			this.users_access_lb = new System.Windows.Forms.Label();
			this.users_surname_lb = new System.Windows.Forms.Label();
			this.users_name_lb = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.persons_lv = new System.Windows.Forms.ListView();
			this.info_panel = new System.Windows.Forms.Panel();
			this.search_tb = new System.Windows.Forms.TextBox();
			this.sort_by_lb = new System.Windows.Forms.Label();
			this.add_new_show_btn = new System.Windows.Forms.Button();
			this.searchs_cb = new System.Windows.Forms.ComboBox();
			this.search_by_lb = new System.Windows.Forms.Label();
			this.search_btn = new System.Windows.Forms.Button();
			this.sorts_cb = new System.Windows.Forms.ComboBox();
			this.products_pv = new System.Windows.Forms.ListView();
			this.product_info_panel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.info_info_lb = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.change_info_btn = new System.Windows.Forms.Button();
			this.name_info_lb = new System.Windows.Forms.Label();
			this.count_info_lb = new System.Windows.Forms.Label();
			this.price_info_lb = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.add_new_panel.SuspendLayout();
			this.users_info_panel.SuspendLayout();
			this.info_panel.SuspendLayout();
			this.product_info_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// name_lb
			// 
			this.name_lb.AutoSize = true;
			this.name_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_lb.Location = new System.Drawing.Point(33, 105);
			this.name_lb.Name = "name_lb";
			this.name_lb.Size = new System.Drawing.Size(54, 27);
			this.name_lb.TabIndex = 0;
			this.name_lb.Text = "Имя:";
			// 
			// surname_lb
			// 
			this.surname_lb.AutoSize = true;
			this.surname_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surname_lb.Location = new System.Drawing.Point(33, 146);
			this.surname_lb.Name = "surname_lb";
			this.surname_lb.Size = new System.Drawing.Size(97, 27);
			this.surname_lb.TabIndex = 0;
			this.surname_lb.Text = "Фамилия:";
			// 
			// login_lb
			// 
			this.login_lb.AutoSize = true;
			this.login_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_lb.Location = new System.Drawing.Point(33, 184);
			this.login_lb.Name = "login_lb";
			this.login_lb.Size = new System.Drawing.Size(67, 27);
			this.login_lb.TabIndex = 0;
			this.login_lb.Text = "Логин:";
			// 
			// password_lb
			// 
			this.password_lb.AutoSize = true;
			this.password_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_lb.Location = new System.Drawing.Point(33, 229);
			this.password_lb.Name = "password_lb";
			this.password_lb.Size = new System.Drawing.Size(82, 27);
			this.password_lb.TabIndex = 0;
			this.password_lb.Text = "Пароль:";
			// 
			// role_lb
			// 
			this.role_lb.AutoSize = true;
			this.role_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.role_lb.Location = new System.Drawing.Point(33, 269);
			this.role_lb.Name = "role_lb";
			this.role_lb.Size = new System.Drawing.Size(77, 27);
			this.role_lb.TabIndex = 0;
			this.role_lb.Text = "Доступ:";
			// 
			// role_cb
			// 
			this.role_cb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.role_cb.FormattingEnabled = true;
			this.role_cb.Location = new System.Drawing.Point(146, 266);
			this.role_cb.Name = "role_cb";
			this.role_cb.Size = new System.Drawing.Size(262, 35);
			this.role_cb.TabIndex = 1;
			// 
			// name_tb
			// 
			this.name_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_tb.Location = new System.Drawing.Point(146, 105);
			this.name_tb.Name = "name_tb";
			this.name_tb.Size = new System.Drawing.Size(262, 34);
			this.name_tb.TabIndex = 2;
			// 
			// surname_tb
			// 
			this.surname_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surname_tb.Location = new System.Drawing.Point(146, 143);
			this.surname_tb.Name = "surname_tb";
			this.surname_tb.Size = new System.Drawing.Size(262, 34);
			this.surname_tb.TabIndex = 2;
			// 
			// login_tb
			// 
			this.login_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_tb.Location = new System.Drawing.Point(146, 181);
			this.login_tb.Name = "login_tb";
			this.login_tb.Size = new System.Drawing.Size(262, 34);
			this.login_tb.TabIndex = 2;
			// 
			// password_tb
			// 
			this.password_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password_tb.Location = new System.Drawing.Point(146, 222);
			this.password_tb.Name = "password_tb";
			this.password_tb.Size = new System.Drawing.Size(262, 34);
			this.password_tb.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bebas Neue Regular", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(65, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(382, 52);
			this.label6.TabIndex = 0;
			this.label6.Text = "Добавить пользователя:";
			// 
			// add_btn
			// 
			this.add_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_btn.Location = new System.Drawing.Point(216, 318);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(127, 36);
			this.add_btn.TabIndex = 3;
			this.add_btn.Text = "Добавить";
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
			this.add_new_panel.Location = new System.Drawing.Point(466, 52);
			this.add_new_panel.Name = "add_new_panel";
			this.add_new_panel.Size = new System.Drawing.Size(481, 684);
			this.add_new_panel.TabIndex = 4;
			// 
			// users_info_panel
			// 
			this.users_info_panel.Controls.Add(this.checkBox1);
			this.users_info_panel.Controls.Add(this.close_users_info_panel_btn);
			this.users_info_panel.Controls.Add(this.users_password_tb);
			this.users_info_panel.Controls.Add(this.users_access_tb);
			this.users_info_panel.Controls.Add(this.delete_btn);
			this.users_info_panel.Controls.Add(this.users_login_tb);
			this.users_info_panel.Controls.Add(this.users_surname_tb);
			this.users_info_panel.Controls.Add(this.users_name_tb);
			this.users_info_panel.Controls.Add(this.users_login_lb);
			this.users_info_panel.Controls.Add(this.users_password_lb);
			this.users_info_panel.Controls.Add(this.users_access_lb);
			this.users_info_panel.Controls.Add(this.users_surname_lb);
			this.users_info_panel.Controls.Add(this.users_name_lb);
			this.users_info_panel.Controls.Add(this.label2);
			this.users_info_panel.Location = new System.Drawing.Point(463, 51);
			this.users_info_panel.Name = "users_info_panel";
			this.users_info_panel.Size = new System.Drawing.Size(483, 689);
			this.users_info_panel.TabIndex = 5;
			// 
			// close_users_info_panel_btn
			// 
			this.close_users_info_panel_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.close_users_info_panel_btn.Location = new System.Drawing.Point(219, 357);
			this.close_users_info_panel_btn.Name = "close_users_info_panel_btn";
			this.close_users_info_panel_btn.Size = new System.Drawing.Size(212, 36);
			this.close_users_info_panel_btn.TabIndex = 5;
			this.close_users_info_panel_btn.Text = "Закрыть";
			this.close_users_info_panel_btn.UseVisualStyleBackColor = true;
			this.close_users_info_panel_btn.Click += new System.EventHandler(this.close_users_info_panel_btn_Cick);
			// 
			// users_password_tb
			// 
			this.users_password_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_password_tb.Location = new System.Drawing.Point(160, 279);
			this.users_password_tb.Name = "users_password_tb";
			this.users_password_tb.ReadOnly = true;
			this.users_password_tb.Size = new System.Drawing.Size(271, 34);
			this.users_password_tb.TabIndex = 2;
			this.users_password_tb.UseSystemPasswordChar = true;
			// 
			// users_access_tb
			// 
			this.users_access_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_access_tb.Location = new System.Drawing.Point(160, 240);
			this.users_access_tb.Name = "users_access_tb";
			this.users_access_tb.ReadOnly = true;
			this.users_access_tb.Size = new System.Drawing.Size(271, 34);
			this.users_access_tb.TabIndex = 2;
			// 
			// delete_btn
			// 
			this.delete_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.delete_btn.Location = new System.Drawing.Point(63, 357);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(138, 36);
			this.delete_btn.TabIndex = 4;
			this.delete_btn.Text = "Удалить";
			this.delete_btn.UseVisualStyleBackColor = true;
			this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
			// 
			// users_login_tb
			// 
			this.users_login_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_login_tb.Location = new System.Drawing.Point(160, 201);
			this.users_login_tb.Name = "users_login_tb";
			this.users_login_tb.ReadOnly = true;
			this.users_login_tb.Size = new System.Drawing.Size(271, 34);
			this.users_login_tb.TabIndex = 2;
			// 
			// users_surname_tb
			// 
			this.users_surname_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_surname_tb.Location = new System.Drawing.Point(160, 161);
			this.users_surname_tb.Name = "users_surname_tb";
			this.users_surname_tb.ReadOnly = true;
			this.users_surname_tb.Size = new System.Drawing.Size(271, 34);
			this.users_surname_tb.TabIndex = 2;
			// 
			// users_name_tb
			// 
			this.users_name_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_name_tb.Location = new System.Drawing.Point(160, 123);
			this.users_name_tb.Name = "users_name_tb";
			this.users_name_tb.ReadOnly = true;
			this.users_name_tb.Size = new System.Drawing.Size(271, 34);
			this.users_name_tb.TabIndex = 2;
			// 
			// users_login_lb
			// 
			this.users_login_lb.AutoSize = true;
			this.users_login_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_login_lb.Location = new System.Drawing.Point(57, 207);
			this.users_login_lb.Name = "users_login_lb";
			this.users_login_lb.Size = new System.Drawing.Size(61, 28);
			this.users_login_lb.TabIndex = 1;
			this.users_login_lb.Text = "Логин:";
			// 
			// users_password_lb
			// 
			this.users_password_lb.AutoSize = true;
			this.users_password_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_password_lb.Location = new System.Drawing.Point(58, 286);
			this.users_password_lb.Name = "users_password_lb";
			this.users_password_lb.Size = new System.Drawing.Size(72, 28);
			this.users_password_lb.TabIndex = 1;
			this.users_password_lb.Text = "Пароль:";
			// 
			// users_access_lb
			// 
			this.users_access_lb.AutoSize = true;
			this.users_access_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_access_lb.Location = new System.Drawing.Point(57, 245);
			this.users_access_lb.Name = "users_access_lb";
			this.users_access_lb.Size = new System.Drawing.Size(73, 28);
			this.users_access_lb.TabIndex = 1;
			this.users_access_lb.Text = "Доступ:";
			// 
			// users_surname_lb
			// 
			this.users_surname_lb.AutoSize = true;
			this.users_surname_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_surname_lb.Location = new System.Drawing.Point(57, 164);
			this.users_surname_lb.Name = "users_surname_lb";
			this.users_surname_lb.Size = new System.Drawing.Size(88, 28);
			this.users_surname_lb.TabIndex = 1;
			this.users_surname_lb.Text = "Фамилия:";
			// 
			// users_name_lb
			// 
			this.users_name_lb.AutoSize = true;
			this.users_name_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.users_name_lb.Location = new System.Drawing.Point(57, 119);
			this.users_name_lb.Name = "users_name_lb";
			this.users_name_lb.Size = new System.Drawing.Size(46, 28);
			this.users_name_lb.TabIndex = 1;
			this.users_name_lb.Text = "Имя:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Bebas Neue Regular", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(152, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 44);
			this.label2.TabIndex = 0;
			this.label2.Text = "Информация";
			// 
			// persons_lv
			// 
			this.persons_lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.persons_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.persons_lv.HideSelection = false;
			this.persons_lv.Location = new System.Drawing.Point(12, 51);
			this.persons_lv.Name = "persons_lv";
			this.persons_lv.Size = new System.Drawing.Size(448, 685);
			this.persons_lv.TabIndex = 5;
			this.persons_lv.UseCompatibleStateImageBehavior = false;
			this.persons_lv.View = System.Windows.Forms.View.List;
			this.persons_lv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.persons_lv_MouseClick);
			// 
			// info_panel
			// 
			this.info_panel.Controls.Add(this.search_tb);
			this.info_panel.Controls.Add(this.sort_by_lb);
			this.info_panel.Controls.Add(this.add_new_show_btn);
			this.info_panel.Controls.Add(this.searchs_cb);
			this.info_panel.Controls.Add(this.search_by_lb);
			this.info_panel.Controls.Add(this.search_btn);
			this.info_panel.Controls.Add(this.sorts_cb);
			this.info_panel.Location = new System.Drawing.Point(12, 9);
			this.info_panel.Name = "info_panel";
			this.info_panel.Size = new System.Drawing.Size(1398, 41);
			this.info_panel.TabIndex = 27;
			// 
			// search_tb
			// 
			this.search_tb.BackColor = System.Drawing.SystemColors.Control;
			this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.search_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_tb.Location = new System.Drawing.Point(894, 3);
			this.search_tb.Name = "search_tb";
			this.search_tb.Size = new System.Drawing.Size(191, 34);
			this.search_tb.TabIndex = 24;
			// 
			// sort_by_lb
			// 
			this.sort_by_lb.AutoSize = true;
			this.sort_by_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sort_by_lb.Location = new System.Drawing.Point(344, 7);
			this.sort_by_lb.Name = "sort_by_lb";
			this.sort_by_lb.Size = new System.Drawing.Size(138, 28);
			this.sort_by_lb.TabIndex = 3;
			this.sort_by_lb.Text = "Сортировать по:";
			// 
			// add_new_show_btn
			// 
			this.add_new_show_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_new_show_btn.Location = new System.Drawing.Point(3, 3);
			this.add_new_show_btn.Name = "add_new_show_btn";
			this.add_new_show_btn.Size = new System.Drawing.Size(304, 36);
			this.add_new_show_btn.TabIndex = 5;
			this.add_new_show_btn.Text = "Добавить";
			this.add_new_show_btn.UseVisualStyleBackColor = true;
			this.add_new_show_btn.Click += new System.EventHandler(this.add_new_show_btn_Click);
			// 
			// searchs_cb
			// 
			this.searchs_cb.BackColor = System.Drawing.SystemColors.Control;
			this.searchs_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.searchs_cb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.searchs_cb.FormattingEnabled = true;
			this.searchs_cb.Items.AddRange(new object[] {
            "Имени",
            "Цене",
            "Количеству"});
			this.searchs_cb.Location = new System.Drawing.Point(766, 3);
			this.searchs_cb.Name = "searchs_cb";
			this.searchs_cb.Size = new System.Drawing.Size(121, 36);
			this.searchs_cb.TabIndex = 23;
			// 
			// search_by_lb
			// 
			this.search_by_lb.AutoSize = true;
			this.search_by_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.search_by_lb.Location = new System.Drawing.Point(667, 7);
			this.search_by_lb.Name = "search_by_lb";
			this.search_by_lb.Size = new System.Drawing.Size(93, 28);
			this.search_by_lb.TabIndex = 3;
			this.search_by_lb.Text = "искать по:";
			// 
			// search_btn
			// 
			this.search_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.search_btn.Location = new System.Drawing.Point(1091, 3);
			this.search_btn.Name = "search_btn";
			this.search_btn.Size = new System.Drawing.Size(37, 36);
			this.search_btn.TabIndex = 22;
			this.search_btn.Text = "0";
			this.search_btn.UseVisualStyleBackColor = true;
			this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
			// 
			// sorts_cb
			// 
			this.sorts_cb.BackColor = System.Drawing.SystemColors.Control;
			this.sorts_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sorts_cb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sorts_cb.FormattingEnabled = true;
			this.sorts_cb.Items.AddRange(new object[] {
            "Названию ↑",
            "Названию ↓",
            "Цене ↑",
            "Цене ↓",
            "Количеству ↑",
            "Количеству ↓"});
			this.sorts_cb.Location = new System.Drawing.Point(488, 3);
			this.sorts_cb.Name = "sorts_cb";
			this.sorts_cb.Size = new System.Drawing.Size(173, 36);
			this.sorts_cb.TabIndex = 21;
			this.sorts_cb.SelectedIndexChanged += new System.EventHandler(this.sorts_cb_SelectedIndexChanged);
			// 
			// products_pv
			// 
			this.products_pv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.products_pv.HideSelection = false;
			this.products_pv.Location = new System.Drawing.Point(962, 51);
			this.products_pv.Name = "products_pv";
			this.products_pv.Size = new System.Drawing.Size(448, 685);
			this.products_pv.TabIndex = 28;
			this.products_pv.UseCompatibleStateImageBehavior = false;
			this.products_pv.View = System.Windows.Forms.View.List;
			this.products_pv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.products_pv_MouseClick);
			// 
			// product_info_panel
			// 
			this.product_info_panel.Controls.Add(this.pictureBox1);
			this.product_info_panel.Controls.Add(this.info_info_lb);
			this.product_info_panel.Controls.Add(this.label7);
			this.product_info_panel.Controls.Add(this.label1);
			this.product_info_panel.Controls.Add(this.label5);
			this.product_info_panel.Controls.Add(this.label9);
			this.product_info_panel.Controls.Add(this.label4);
			this.product_info_panel.Controls.Add(this.change_info_btn);
			this.product_info_panel.Controls.Add(this.name_info_lb);
			this.product_info_panel.Controls.Add(this.count_info_lb);
			this.product_info_panel.Controls.Add(this.price_info_lb);
			this.product_info_panel.Location = new System.Drawing.Point(469, 51);
			this.product_info_panel.Name = "product_info_panel";
			this.product_info_panel.Size = new System.Drawing.Size(480, 685);
			this.product_info_panel.TabIndex = 29;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(111, 150);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(267, 240);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// info_info_lb
			// 
			this.info_info_lb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.info_info_lb.Location = new System.Drawing.Point(112, 404);
			this.info_info_lb.Name = "info_info_lb";
			this.info_info_lb.ReadOnly = true;
			this.info_info_lb.Size = new System.Drawing.Size(267, 141);
			this.info_info_lb.TabIndex = 18;
			this.info_info_lb.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(57, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 28);
			this.label7.TabIndex = 12;
			this.label7.Text = "Цена:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(66, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 28);
			this.label1.TabIndex = 11;
			this.label1.Text = "Имя:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(40, 404);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 28);
			this.label5.TabIndex = 13;
			this.label5.Text = "Инфо:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(55, 150);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 28);
			this.label9.TabIndex = 14;
			this.label9.Text = "Фото:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(6, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 28);
			this.label4.TabIndex = 14;
			this.label4.Text = "Количество:";
			// 
			// change_info_btn
			// 
			this.change_info_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.change_info_btn.Location = new System.Drawing.Point(202, 567);
			this.change_info_btn.Name = "change_info_btn";
			this.change_info_btn.Size = new System.Drawing.Size(124, 33);
			this.change_info_btn.TabIndex = 0;
			this.change_info_btn.Text = "Удалить";
			this.change_info_btn.UseVisualStyleBackColor = true;
			this.change_info_btn.Click += new System.EventHandler(this.change_info_btn_Click);
			// 
			// name_info_lb
			// 
			this.name_info_lb.AutoSize = true;
			this.name_info_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.name_info_lb.Location = new System.Drawing.Point(121, 21);
			this.name_info_lb.Name = "name_info_lb";
			this.name_info_lb.Size = new System.Drawing.Size(22, 27);
			this.name_info_lb.TabIndex = 15;
			this.name_info_lb.Text = "_";
			// 
			// count_info_lb
			// 
			this.count_info_lb.AutoSize = true;
			this.count_info_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.count_info_lb.Location = new System.Drawing.Point(121, 107);
			this.count_info_lb.Name = "count_info_lb";
			this.count_info_lb.Size = new System.Drawing.Size(22, 27);
			this.count_info_lb.TabIndex = 15;
			this.count_info_lb.Text = "_";
			// 
			// price_info_lb
			// 
			this.price_info_lb.AutoSize = true;
			this.price_info_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price_info_lb.Location = new System.Drawing.Point(119, 61);
			this.price_info_lb.Name = "price_info_lb";
			this.price_info_lb.Size = new System.Drawing.Size(22, 27);
			this.price_info_lb.TabIndex = 15;
			this.price_info_lb.Text = "_";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(437, 288);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(18, 17);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.show_password_rb_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1426, 748);
			this.Controls.Add(this.persons_lv);
			this.Controls.Add(this.products_pv);
			this.Controls.Add(this.info_panel);
			this.Controls.Add(this.add_new_panel);
			this.Controls.Add(this.product_info_panel);
			this.Controls.Add(this.users_info_panel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Admin window";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.add_new_panel.ResumeLayout(false);
			this.add_new_panel.PerformLayout();
			this.users_info_panel.ResumeLayout(false);
			this.users_info_panel.PerformLayout();
			this.info_panel.ResumeLayout(false);
			this.info_panel.PerformLayout();
			this.product_info_panel.ResumeLayout(false);
			this.product_info_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Panel info_panel;
		private System.Windows.Forms.TextBox search_tb;
		private System.Windows.Forms.Label sort_by_lb;
		private System.Windows.Forms.ComboBox searchs_cb;
		private System.Windows.Forms.Label search_by_lb;
		private System.Windows.Forms.Button search_btn;
		private System.Windows.Forms.ComboBox sorts_cb;
		private System.Windows.Forms.Button add_new_show_btn;
		private System.Windows.Forms.ListView products_pv;
		private System.Windows.Forms.Panel product_info_panel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox info_info_lb;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button change_info_btn;
		private System.Windows.Forms.Label name_info_lb;
		private System.Windows.Forms.Label count_info_lb;
		private System.Windows.Forms.Label price_info_lb;
		private System.Windows.Forms.Panel users_info_panel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label users_access_lb;
		private System.Windows.Forms.Label users_surname_lb;
		private System.Windows.Forms.Label users_name_lb;
		private System.Windows.Forms.TextBox users_password_tb;
		private System.Windows.Forms.TextBox users_access_tb;
		private System.Windows.Forms.TextBox users_login_tb;
		private System.Windows.Forms.TextBox users_surname_tb;
		private System.Windows.Forms.TextBox users_name_tb;
		private System.Windows.Forms.Label users_login_lb;
		private System.Windows.Forms.Label users_password_lb;
		private System.Windows.Forms.Button close_users_info_panel_btn;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}


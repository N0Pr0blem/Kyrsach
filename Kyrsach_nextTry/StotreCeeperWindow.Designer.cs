namespace Kyrsach_nextTry
{
	partial class StotreCeeperWindow
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
			this.add_btn = new System.Windows.Forms.Button();
			this.add_product_lb = new System.Windows.Forms.Label();
			this.products_pv = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.name_tb = new System.Windows.Forms.TextBox();
			this.price_tb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.info_rtb = new System.Windows.Forms.RichTextBox();
			this.add_new_panel = new System.Windows.Forms.Panel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.count_tb = new System.Windows.Forms.TextBox();
			this.count_lb = new System.Windows.Forms.Label();
			this.choose_btn = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.add_products_lv = new System.Windows.Forms.ListView();
			this.load_products_btn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.name_info_lb = new System.Windows.Forms.Label();
			this.price_info_lb = new System.Windows.Forms.Label();
			this.count_info_lb = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.change_info_btn = new System.Windows.Forms.Button();
			this.product_info_panel = new System.Windows.Forms.Panel();
			this.new_info_rtb = new System.Windows.Forms.RichTextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.new_count_btn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.new_info_btn = new System.Windows.Forms.Button();
			this.info_info_lb = new System.Windows.Forms.RichTextBox();
			this.new_count_tb = new System.Windows.Forms.TextBox();
			this.new_price_btn = new System.Windows.Forms.Button();
			this.new_price_tb = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.add_new_btn = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.sorts_cb = new System.Windows.Forms.ComboBox();
			this.sort_by_lb = new System.Windows.Forms.Label();
			this.search_btn = new System.Windows.Forms.Button();
			this.search_by_lb = new System.Windows.Forms.Label();
			this.searchs_cb = new System.Windows.Forms.ComboBox();
			this.search_tb = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.add_new_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.product_info_panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// add_btn
			// 
			this.add_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_btn.Location = new System.Drawing.Point(271, 617);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(106, 33);
			this.add_btn.TabIndex = 0;
			this.add_btn.Text = "Добавить";
			this.add_btn.UseVisualStyleBackColor = true;
			this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
			// 
			// add_product_lb
			// 
			this.add_product_lb.AutoSize = true;
			this.add_product_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_product_lb.Location = new System.Drawing.Point(83, 6);
			this.add_product_lb.Name = "add_product_lb";
			this.add_product_lb.Size = new System.Drawing.Size(303, 40);
			this.add_product_lb.TabIndex = 1;
			this.add_product_lb.Text = "Добавить новый продукт:";
			// 
			// products_pv
			// 
			this.products_pv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.products_pv.HideSelection = false;
			this.products_pv.Location = new System.Drawing.Point(12, 51);
			this.products_pv.Name = "products_pv";
			this.products_pv.Size = new System.Drawing.Size(422, 664);
			this.products_pv.TabIndex = 2;
			this.products_pv.UseCompatibleStateImageBehavior = false;
			this.products_pv.View = System.Windows.Forms.View.List;
			this.products_pv.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.products_pv_ItemCheck);
			this.products_pv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.products_pv_MouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(85, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "Имя:";
			// 
			// name_tb
			// 
			this.name_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.name_tb.Location = new System.Drawing.Point(174, 71);
			this.name_tb.Name = "name_tb";
			this.name_tb.Size = new System.Drawing.Size(285, 34);
			this.name_tb.TabIndex = 4;
			// 
			// price_tb
			// 
			this.price_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price_tb.Location = new System.Drawing.Point(174, 119);
			this.price_tb.Name = "price_tb";
			this.price_tb.Size = new System.Drawing.Size(285, 34);
			this.price_tb.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(85, 126);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 27);
			this.label2.TabIndex = 5;
			this.label2.Text = "Цена:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(3, 463);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 27);
			this.label3.TabIndex = 7;
			this.label3.Text = "Информация:";
			// 
			// info_rtb
			// 
			this.info_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.info_rtb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.info_rtb.Location = new System.Drawing.Point(175, 454);
			this.info_rtb.Name = "info_rtb";
			this.info_rtb.Size = new System.Drawing.Size(285, 146);
			this.info_rtb.TabIndex = 8;
			this.info_rtb.Text = "";
			// 
			// add_new_panel
			// 
			this.add_new_panel.Controls.Add(this.pictureBox);
			this.add_new_panel.Controls.Add(this.count_tb);
			this.add_new_panel.Controls.Add(this.count_lb);
			this.add_new_panel.Controls.Add(this.name_tb);
			this.add_new_panel.Controls.Add(this.info_rtb);
			this.add_new_panel.Controls.Add(this.choose_btn);
			this.add_new_panel.Controls.Add(this.add_btn);
			this.add_new_panel.Controls.Add(this.label8);
			this.add_new_panel.Controls.Add(this.label3);
			this.add_new_panel.Controls.Add(this.add_product_lb);
			this.add_new_panel.Controls.Add(this.price_tb);
			this.add_new_panel.Controls.Add(this.label1);
			this.add_new_panel.Controls.Add(this.label2);
			this.add_new_panel.Location = new System.Drawing.Point(922, 12);
			this.add_new_panel.Name = "add_new_panel";
			this.add_new_panel.Size = new System.Drawing.Size(480, 704);
			this.add_new_panel.TabIndex = 9;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(180, 208);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(279, 240);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 11;
			this.pictureBox.TabStop = false;
			// 
			// count_tb
			// 
			this.count_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.count_tb.Location = new System.Drawing.Point(174, 168);
			this.count_tb.Name = "count_tb";
			this.count_tb.Size = new System.Drawing.Size(285, 34);
			this.count_tb.TabIndex = 10;
			// 
			// count_lb
			// 
			this.count_lb.AutoSize = true;
			this.count_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.count_lb.Location = new System.Drawing.Point(33, 174);
			this.count_lb.Name = "count_lb";
			this.count_lb.Size = new System.Drawing.Size(118, 27);
			this.count_lb.TabIndex = 9;
			this.count_lb.Text = "Количество:";
			// 
			// choose_btn
			// 
			this.choose_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.choose_btn.Location = new System.Drawing.Point(68, 243);
			this.choose_btn.Name = "choose_btn";
			this.choose_btn.Size = new System.Drawing.Size(97, 33);
			this.choose_btn.TabIndex = 0;
			this.choose_btn.Text = "Выбрать";
			this.choose_btn.UseVisualStyleBackColor = true;
			this.choose_btn.Click += new System.EventHandler(this.choose_btn_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(86, 208);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 27);
			this.label8.TabIndex = 7;
			this.label8.Text = "Фото:";
			// 
			// add_products_lv
			// 
			this.add_products_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_products_lv.HideSelection = false;
			this.add_products_lv.Location = new System.Drawing.Point(512, 51);
			this.add_products_lv.Name = "add_products_lv";
			this.add_products_lv.Size = new System.Drawing.Size(404, 665);
			this.add_products_lv.TabIndex = 10;
			this.add_products_lv.UseCompatibleStateImageBehavior = false;
			this.add_products_lv.View = System.Windows.Forms.View.List;
			// 
			// load_products_btn
			// 
			this.load_products_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.load_products_btn.Location = new System.Drawing.Point(440, 51);
			this.load_products_btn.Name = "load_products_btn";
			this.load_products_btn.Size = new System.Drawing.Size(66, 664);
			this.load_products_btn.TabIndex = 9;
			this.load_products_btn.Text = "<-";
			this.load_products_btn.UseVisualStyleBackColor = true;
			this.load_products_btn.Click += new System.EventHandler(this.load_products_btn_Click);
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
			this.label4.Click += new System.EventHandler(this.label4_Click);
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(66, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 28);
			this.label6.TabIndex = 11;
			this.label6.Text = "Имя:";
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(393, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(51, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "new";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(395, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(51, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "new";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(393, 441);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(51, 23);
			this.button3.TabIndex = 16;
			this.button3.Text = "new";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// change_info_btn
			// 
			this.change_info_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.change_info_btn.Location = new System.Drawing.Point(215, 567);
			this.change_info_btn.Name = "change_info_btn";
			this.change_info_btn.Size = new System.Drawing.Size(103, 33);
			this.change_info_btn.TabIndex = 0;
			this.change_info_btn.Text = "Изменить";
			this.change_info_btn.UseVisualStyleBackColor = true;
			this.change_info_btn.Click += new System.EventHandler(this.change_info_btn_Click);
			// 
			// product_info_panel
			// 
			this.product_info_panel.Controls.Add(this.new_info_rtb);
			this.product_info_panel.Controls.Add(this.button4);
			this.product_info_panel.Controls.Add(this.new_count_btn);
			this.product_info_panel.Controls.Add(this.pictureBox1);
			this.product_info_panel.Controls.Add(this.new_info_btn);
			this.product_info_panel.Controls.Add(this.info_info_lb);
			this.product_info_panel.Controls.Add(this.button3);
			this.product_info_panel.Controls.Add(this.label7);
			this.product_info_panel.Controls.Add(this.button2);
			this.product_info_panel.Controls.Add(this.new_count_tb);
			this.product_info_panel.Controls.Add(this.new_price_btn);
			this.product_info_panel.Controls.Add(this.label6);
			this.product_info_panel.Controls.Add(this.new_price_tb);
			this.product_info_panel.Controls.Add(this.button1);
			this.product_info_panel.Controls.Add(this.label5);
			this.product_info_panel.Controls.Add(this.label9);
			this.product_info_panel.Controls.Add(this.label4);
			this.product_info_panel.Controls.Add(this.change_info_btn);
			this.product_info_panel.Controls.Add(this.name_info_lb);
			this.product_info_panel.Controls.Add(this.count_info_lb);
			this.product_info_panel.Controls.Add(this.price_info_lb);
			this.product_info_panel.Location = new System.Drawing.Point(922, 12);
			this.product_info_panel.Name = "product_info_panel";
			this.product_info_panel.Size = new System.Drawing.Size(480, 704);
			this.product_info_panel.TabIndex = 17;
			// 
			// new_info_rtb
			// 
			this.new_info_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.new_info_rtb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_info_rtb.Location = new System.Drawing.Point(111, 404);
			this.new_info_rtb.Name = "new_info_rtb";
			this.new_info_rtb.Size = new System.Drawing.Size(268, 141);
			this.new_info_rtb.TabIndex = 13;
			this.new_info_rtb.Text = "";
			this.new_info_rtb.TextChanged += new System.EventHandler(this.new_info_rtb_TextChanged);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(54, 181);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(51, 23);
			this.button4.TabIndex = 20;
			this.button4.Text = "new";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// new_count_btn
			// 
			this.new_count_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_count_btn.Location = new System.Drawing.Point(392, 106);
			this.new_count_btn.Name = "new_count_btn";
			this.new_count_btn.Size = new System.Drawing.Size(81, 33);
			this.new_count_btn.TabIndex = 19;
			this.new_count_btn.Text = "уст.";
			this.new_count_btn.UseVisualStyleBackColor = true;
			this.new_count_btn.Click += new System.EventHandler(this.new_count_btn_Click);
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
			// new_info_btn
			// 
			this.new_info_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_info_btn.Location = new System.Drawing.Point(393, 433);
			this.new_info_btn.Name = "new_info_btn";
			this.new_info_btn.Size = new System.Drawing.Size(67, 33);
			this.new_info_btn.TabIndex = 18;
			this.new_info_btn.Text = "Уст.";
			this.new_info_btn.UseVisualStyleBackColor = true;
			this.new_info_btn.Click += new System.EventHandler(this.new_info_btn_Click);
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
			// new_count_tb
			// 
			this.new_count_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_count_tb.Location = new System.Drawing.Point(111, 106);
			this.new_count_tb.Name = "new_count_tb";
			this.new_count_tb.Size = new System.Drawing.Size(268, 34);
			this.new_count_tb.TabIndex = 14;
			// 
			// new_price_btn
			// 
			this.new_price_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_price_btn.Location = new System.Drawing.Point(393, 63);
			this.new_price_btn.Name = "new_price_btn";
			this.new_price_btn.Size = new System.Drawing.Size(80, 33);
			this.new_price_btn.TabIndex = 11;
			this.new_price_btn.Text = "Уст.";
			this.new_price_btn.UseVisualStyleBackColor = true;
			this.new_price_btn.Click += new System.EventHandler(this.new_price_btn_Click);
			// 
			// new_price_tb
			// 
			this.new_price_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_price_tb.Location = new System.Drawing.Point(109, 58);
			this.new_price_tb.Name = "new_price_tb";
			this.new_price_tb.Size = new System.Drawing.Size(268, 34);
			this.new_price_tb.TabIndex = 12;
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
			this.label9.Click += new System.EventHandler(this.label4_Click);
			// 
			// add_new_btn
			// 
			this.add_new_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_new_btn.Location = new System.Drawing.Point(791, 1);
			this.add_new_btn.Name = "add_new_btn";
			this.add_new_btn.Size = new System.Drawing.Size(114, 38);
			this.add_new_btn.TabIndex = 20;
			this.add_new_btn.Text = "Добавить";
			this.add_new_btn.UseVisualStyleBackColor = true;
			this.add_new_btn.Click += new System.EventHandler(this.Add_new_btn);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// sorts_cb
			// 
			this.sorts_cb.BackColor = System.Drawing.SystemColors.Control;
			this.sorts_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sorts_cb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sorts_cb.FormattingEnabled = true;
			this.sorts_cb.Items.AddRange(new object[] {
            "Назвнию ↑",
            "Назвнию ↓",
            "Цене ↑",
            "Цене ↓",
            "Количеству ↑",
            "Количеству ↓"});
			this.sorts_cb.Location = new System.Drawing.Point(145, 2);
			this.sorts_cb.Name = "sorts_cb";
			this.sorts_cb.Size = new System.Drawing.Size(173, 36);
			this.sorts_cb.TabIndex = 21;
			this.sorts_cb.SelectedIndexChanged += new System.EventHandler(this.sorts_cb_SelectedIndexChanged);
			// 
			// sort_by_lb
			// 
			this.sort_by_lb.AutoSize = true;
			this.sort_by_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sort_by_lb.Location = new System.Drawing.Point(1, 6);
			this.sort_by_lb.Name = "sort_by_lb";
			this.sort_by_lb.Size = new System.Drawing.Size(138, 28);
			this.sort_by_lb.TabIndex = 3;
			this.sort_by_lb.Text = "Сортировать по:";
			// 
			// search_btn
			// 
			this.search_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.search_btn.Location = new System.Drawing.Point(748, 2);
			this.search_btn.Name = "search_btn";
			this.search_btn.Size = new System.Drawing.Size(37, 36);
			this.search_btn.TabIndex = 22;
			this.search_btn.Text = "0";
			this.search_btn.UseVisualStyleBackColor = true;
			this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
			// 
			// search_by_lb
			// 
			this.search_by_lb.AutoSize = true;
			this.search_by_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.search_by_lb.Location = new System.Drawing.Point(324, 6);
			this.search_by_lb.Name = "search_by_lb";
			this.search_by_lb.Size = new System.Drawing.Size(93, 28);
			this.search_by_lb.TabIndex = 3;
			this.search_by_lb.Text = "искать по:";
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
			this.searchs_cb.Location = new System.Drawing.Point(423, 2);
			this.searchs_cb.Name = "searchs_cb";
			this.searchs_cb.Size = new System.Drawing.Size(121, 36);
			this.searchs_cb.TabIndex = 23;
			// 
			// search_tb
			// 
			this.search_tb.BackColor = System.Drawing.SystemColors.Control;
			this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.search_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_tb.Location = new System.Drawing.Point(551, 2);
			this.search_tb.Name = "search_tb";
			this.search_tb.Size = new System.Drawing.Size(191, 34);
			this.search_tb.TabIndex = 24;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.add_new_btn);
			this.panel1.Controls.Add(this.search_tb);
			this.panel1.Controls.Add(this.sort_by_lb);
			this.panel1.Controls.Add(this.searchs_cb);
			this.panel1.Controls.Add(this.search_by_lb);
			this.panel1.Controls.Add(this.search_btn);
			this.panel1.Controls.Add(this.sorts_cb);
			this.panel1.Location = new System.Drawing.Point(12, 9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(904, 41);
			this.panel1.TabIndex = 25;
			// 
			// StotreCeeperWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1426, 748);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.load_products_btn);
			this.Controls.Add(this.add_products_lv);
			this.Controls.Add(this.products_pv);
			this.Controls.Add(this.product_info_panel);
			this.Controls.Add(this.add_new_panel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StotreCeeperWindow";
			this.Text = "StotreCeeperWindow";
			this.Load += new System.EventHandler(this.StotreCeeperWindow_Load);
			this.add_new_panel.ResumeLayout(false);
			this.add_new_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.product_info_panel.ResumeLayout(false);
			this.product_info_panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button add_btn;
		private System.Windows.Forms.Label add_product_lb;
		private System.Windows.Forms.ListView products_pv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox name_tb;
		private System.Windows.Forms.TextBox price_tb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox info_rtb;
		private System.Windows.Forms.Panel add_new_panel;
		private System.Windows.Forms.ListView add_products_lv;
		private System.Windows.Forms.Button load_products_btn;
		private System.Windows.Forms.TextBox count_tb;
		private System.Windows.Forms.Label count_lb;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label name_info_lb;
		private System.Windows.Forms.Label price_info_lb;
		private System.Windows.Forms.Label count_info_lb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button change_info_btn;
		private System.Windows.Forms.Panel product_info_panel;
		private System.Windows.Forms.RichTextBox info_info_lb;
		private System.Windows.Forms.TextBox new_count_tb;
		private System.Windows.Forms.RichTextBox new_info_rtb;
		private System.Windows.Forms.TextBox new_price_tb;
		private System.Windows.Forms.Button new_price_btn;
		private System.Windows.Forms.Button new_info_btn;
		private System.Windows.Forms.Button new_count_btn;
		private System.Windows.Forms.Button add_new_btn;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Button choose_btn;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox sorts_cb;
		private System.Windows.Forms.Label sort_by_lb;
		private System.Windows.Forms.Button search_btn;
		private System.Windows.Forms.Label search_by_lb;
		private System.Windows.Forms.ComboBox searchs_cb;
		private System.Windows.Forms.TextBox search_tb;
		private System.Windows.Forms.Panel panel1;
	}
}
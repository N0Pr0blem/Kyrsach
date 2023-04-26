namespace Kyrsach_nextTry
{
	partial class SellerWindow
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
			this.products_lv = new System.Windows.Forms.ListView();
			this.buy_products_lv = new System.Windows.Forms.ListView();
			this.load_products_btn = new System.Windows.Forms.Button();
			this.buy_btn = new System.Windows.Forms.Button();
			this.final_price_main_lb = new System.Windows.Forms.Label();
			this.final_price_lb = new System.Windows.Forms.Label();
			this.clean_btn = new System.Windows.Forms.Button();
			this.new_price_lb = new System.Windows.Forms.Label();
			this.new_price_tb = new System.Windows.Forms.TextBox();
			this.new_price_btn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.count_lb = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.search_tb = new System.Windows.Forms.TextBox();
			this.sort_by_lb = new System.Windows.Forms.Label();
			this.searchs_cb = new System.Windows.Forms.ComboBox();
			this.search_by_lb = new System.Windows.Forms.Label();
			this.search_btn = new System.Windows.Forms.Button();
			this.sorts_cb = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// products_lv
			// 
			this.products_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.products_lv.HideSelection = false;
			this.products_lv.Location = new System.Drawing.Point(5, 47);
			this.products_lv.Name = "products_lv";
			this.products_lv.Size = new System.Drawing.Size(417, 690);
			this.products_lv.TabIndex = 0;
			this.products_lv.UseCompatibleStateImageBehavior = false;
			this.products_lv.View = System.Windows.Forms.View.List;
			this.products_lv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.products_lv_MouseDoubleClick);
			// 
			// buy_products_lv
			// 
			this.buy_products_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buy_products_lv.HideSelection = false;
			this.buy_products_lv.Location = new System.Drawing.Point(500, 47);
			this.buy_products_lv.Name = "buy_products_lv";
			this.buy_products_lv.Size = new System.Drawing.Size(409, 689);
			this.buy_products_lv.TabIndex = 1;
			this.buy_products_lv.UseCompatibleStateImageBehavior = false;
			this.buy_products_lv.View = System.Windows.Forms.View.List;
			this.buy_products_lv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buy_products_lv_MouseClick);
			// 
			// load_products_btn
			// 
			this.load_products_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.load_products_btn.Location = new System.Drawing.Point(428, 47);
			this.load_products_btn.Name = "load_products_btn";
			this.load_products_btn.Size = new System.Drawing.Size(66, 689);
			this.load_products_btn.TabIndex = 2;
			this.load_products_btn.Text = "->";
			this.load_products_btn.UseVisualStyleBackColor = true;
			this.load_products_btn.Click += new System.EventHandler(this.Load_products_btn_Click);
			// 
			// buy_btn
			// 
			this.buy_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buy_btn.Location = new System.Drawing.Point(154, 371);
			this.buy_btn.Name = "buy_btn";
			this.buy_btn.Size = new System.Drawing.Size(230, 51);
			this.buy_btn.TabIndex = 3;
			this.buy_btn.Text = "Купить";
			this.buy_btn.UseVisualStyleBackColor = true;
			this.buy_btn.Click += new System.EventHandler(this.Buy_Click);
			// 
			// final_price_main_lb
			// 
			this.final_price_main_lb.AutoSize = true;
			this.final_price_main_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.final_price_main_lb.Location = new System.Drawing.Point(147, 327);
			this.final_price_main_lb.Name = "final_price_main_lb";
			this.final_price_main_lb.Size = new System.Drawing.Size(76, 40);
			this.final_price_main_lb.TabIndex = 4;
			this.final_price_main_lb.Text = "Цена:";
			// 
			// final_price_lb
			// 
			this.final_price_lb.AutoSize = true;
			this.final_price_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.final_price_lb.Location = new System.Drawing.Point(242, 327);
			this.final_price_lb.Name = "final_price_lb";
			this.final_price_lb.Size = new System.Drawing.Size(30, 40);
			this.final_price_lb.TabIndex = 4;
			this.final_price_lb.Text = "0";
			// 
			// clean_btn
			// 
			this.clean_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clean_btn.Location = new System.Drawing.Point(154, 428);
			this.clean_btn.Name = "clean_btn";
			this.clean_btn.Size = new System.Drawing.Size(230, 51);
			this.clean_btn.TabIndex = 3;
			this.clean_btn.Text = "Очистить";
			this.clean_btn.UseVisualStyleBackColor = true;
			this.clean_btn.Click += new System.EventHandler(this.Clean_Click);
			// 
			// new_price_lb
			// 
			this.new_price_lb.AutoSize = true;
			this.new_price_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.new_price_lb.Location = new System.Drawing.Point(310, 177);
			this.new_price_lb.Name = "new_price_lb";
			this.new_price_lb.Size = new System.Drawing.Size(28, 40);
			this.new_price_lb.TabIndex = 5;
			this.new_price_lb.Text = "1";
			// 
			// new_price_tb
			// 
			this.new_price_tb.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_price_tb.Location = new System.Drawing.Point(154, 221);
			this.new_price_tb.Name = "new_price_tb";
			this.new_price_tb.Size = new System.Drawing.Size(230, 45);
			this.new_price_tb.TabIndex = 6;
			// 
			// new_price_btn
			// 
			this.new_price_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.new_price_btn.Location = new System.Drawing.Point(154, 272);
			this.new_price_btn.Name = "new_price_btn";
			this.new_price_btn.Size = new System.Drawing.Size(230, 52);
			this.new_price_btn.TabIndex = 3;
			this.new_price_btn.Text = "Установить";
			this.new_price_btn.UseVisualStyleBackColor = true;
			this.new_price_btn.Click += new System.EventHandler(this.New_price_btn_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buy_btn);
			this.panel1.Controls.Add(this.new_price_tb);
			this.panel1.Controls.Add(this.clean_btn);
			this.panel1.Controls.Add(this.count_lb);
			this.panel1.Controls.Add(this.new_price_lb);
			this.panel1.Controls.Add(this.final_price_main_lb);
			this.panel1.Controls.Add(this.new_price_btn);
			this.panel1.Controls.Add(this.final_price_lb);
			this.panel1.Location = new System.Drawing.Point(915, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(499, 733);
			this.panel1.TabIndex = 7;
			// 
			// count_lb
			// 
			this.count_lb.AutoSize = true;
			this.count_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.count_lb.Location = new System.Drawing.Point(147, 177);
			this.count_lb.Name = "count_lb";
			this.count_lb.Size = new System.Drawing.Size(152, 40);
			this.count_lb.TabIndex = 5;
			this.count_lb.Text = "Количество:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.search_tb);
			this.panel2.Controls.Add(this.sort_by_lb);
			this.panel2.Controls.Add(this.searchs_cb);
			this.panel2.Controls.Add(this.search_by_lb);
			this.panel2.Controls.Add(this.search_btn);
			this.panel2.Controls.Add(this.sorts_cb);
			this.panel2.Location = new System.Drawing.Point(5, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(904, 41);
			this.panel2.TabIndex = 26;
			// 
			// search_tb
			// 
			this.search_tb.BackColor = System.Drawing.SystemColors.Control;
			this.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.search_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_tb.Location = new System.Drawing.Point(639, 4);
			this.search_tb.Name = "search_tb";
			this.search_tb.Size = new System.Drawing.Size(191, 34);
			this.search_tb.TabIndex = 24;
			// 
			// sort_by_lb
			// 
			this.sort_by_lb.AutoSize = true;
			this.sort_by_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sort_by_lb.Location = new System.Drawing.Point(89, 8);
			this.sort_by_lb.Name = "sort_by_lb";
			this.sort_by_lb.Size = new System.Drawing.Size(138, 28);
			this.sort_by_lb.TabIndex = 3;
			this.sort_by_lb.Text = "Сортировать по:";
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
			this.searchs_cb.Location = new System.Drawing.Point(511, 4);
			this.searchs_cb.Name = "searchs_cb";
			this.searchs_cb.Size = new System.Drawing.Size(121, 36);
			this.searchs_cb.TabIndex = 23;
			// 
			// search_by_lb
			// 
			this.search_by_lb.AutoSize = true;
			this.search_by_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.search_by_lb.Location = new System.Drawing.Point(412, 8);
			this.search_by_lb.Name = "search_by_lb";
			this.search_by_lb.Size = new System.Drawing.Size(93, 28);
			this.search_by_lb.TabIndex = 3;
			this.search_by_lb.Text = "искать по:";
			// 
			// search_btn
			// 
			this.search_btn.Font = new System.Drawing.Font("Bebas Neue Regular", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.search_btn.Location = new System.Drawing.Point(836, 4);
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
			this.sorts_cb.Location = new System.Drawing.Point(233, 4);
			this.sorts_cb.Name = "sorts_cb";
			this.sorts_cb.Size = new System.Drawing.Size(173, 36);
			this.sorts_cb.TabIndex = 21;
			this.sorts_cb.SelectedIndexChanged += new System.EventHandler(this.sorts_cb_SelectedIndexChanged);
			// 
			// SellerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1426, 748);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.load_products_btn);
			this.Controls.Add(this.buy_products_lv);
			this.Controls.Add(this.products_lv);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SellerWindow";
			this.Text = "SellerWindow";
			this.Load += new System.EventHandler(this.SellerWindow_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView products_lv;
		private System.Windows.Forms.ListView buy_products_lv;
		private System.Windows.Forms.Button load_products_btn;
		private System.Windows.Forms.Button buy_btn;
		private System.Windows.Forms.Label final_price_main_lb;
		private System.Windows.Forms.Label final_price_lb;
		private System.Windows.Forms.Button clean_btn;
		private System.Windows.Forms.Label new_price_lb;
		private System.Windows.Forms.TextBox new_price_tb;
		private System.Windows.Forms.Button new_price_btn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox search_tb;
		private System.Windows.Forms.Label sort_by_lb;
		private System.Windows.Forms.ComboBox searchs_cb;
		private System.Windows.Forms.Label search_by_lb;
		private System.Windows.Forms.Button search_btn;
		private System.Windows.Forms.ComboBox sorts_cb;
		private System.Windows.Forms.Label count_lb;
	}
}
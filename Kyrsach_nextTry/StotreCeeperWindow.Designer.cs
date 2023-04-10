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
			this.panel1 = new System.Windows.Forms.Panel();
			this.count_tb = new System.Windows.Forms.TextBox();
			this.count_lb = new System.Windows.Forms.Label();
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
			this.info_info_lb = new System.Windows.Forms.RichTextBox();
			this.new_count_tb = new System.Windows.Forms.TextBox();
			this.new_info_rtb = new System.Windows.Forms.RichTextBox();
			this.new_price_tb = new System.Windows.Forms.TextBox();
			this.new_price_btn = new System.Windows.Forms.Button();
			this.new_info_btn = new System.Windows.Forms.Button();
			this.new_count_btn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.product_info_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// add_btn
			// 
			this.add_btn.Location = new System.Drawing.Point(202, 369);
			this.add_btn.Name = "add_btn";
			this.add_btn.Size = new System.Drawing.Size(75, 23);
			this.add_btn.TabIndex = 0;
			this.add_btn.Text = "Add";
			this.add_btn.UseVisualStyleBackColor = true;
			this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
			// 
			// add_product_lb
			// 
			this.add_product_lb.AutoSize = true;
			this.add_product_lb.Font = new System.Drawing.Font("Bebas Neue Regular", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_product_lb.Location = new System.Drawing.Point(69, 11);
			this.add_product_lb.Name = "add_product_lb";
			this.add_product_lb.Size = new System.Drawing.Size(204, 40);
			this.add_product_lb.TabIndex = 1;
			this.add_product_lb.Text = "Add new product:";
			// 
			// products_pv
			// 
			this.products_pv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.products_pv.HideSelection = false;
			this.products_pv.Location = new System.Drawing.Point(798, 25);
			this.products_pv.Name = "products_pv";
			this.products_pv.Size = new System.Drawing.Size(264, 423);
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
			this.label1.Location = new System.Drawing.Point(39, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 27);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// name_tb
			// 
			this.name_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.name_tb.Location = new System.Drawing.Point(144, 69);
			this.name_tb.Name = "name_tb";
			this.name_tb.Size = new System.Drawing.Size(180, 34);
			this.name_tb.TabIndex = 4;
			// 
			// price_tb
			// 
			this.price_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price_tb.Location = new System.Drawing.Point(144, 117);
			this.price_tb.Name = "price_tb";
			this.price_tb.Size = new System.Drawing.Size(180, 34);
			this.price_tb.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(39, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 27);
			this.label2.TabIndex = 5;
			this.label2.Text = "Price:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(39, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 27);
			this.label3.TabIndex = 7;
			this.label3.Text = "Info:";
			// 
			// info_rtb
			// 
			this.info_rtb.Location = new System.Drawing.Point(144, 224);
			this.info_rtb.Name = "info_rtb";
			this.info_rtb.Size = new System.Drawing.Size(180, 128);
			this.info_rtb.TabIndex = 8;
			this.info_rtb.Text = "";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.count_tb);
			this.panel1.Controls.Add(this.count_lb);
			this.panel1.Controls.Add(this.name_tb);
			this.panel1.Controls.Add(this.info_rtb);
			this.panel1.Controls.Add(this.add_btn);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.add_product_lb);
			this.panel1.Controls.Add(this.price_tb);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(22, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(357, 423);
			this.panel1.TabIndex = 9;
			// 
			// count_tb
			// 
			this.count_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.count_tb.Location = new System.Drawing.Point(144, 166);
			this.count_tb.Name = "count_tb";
			this.count_tb.Size = new System.Drawing.Size(180, 34);
			this.count_tb.TabIndex = 10;
			// 
			// count_lb
			// 
			this.count_lb.AutoSize = true;
			this.count_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.count_lb.Location = new System.Drawing.Point(40, 173);
			this.count_lb.Name = "count_lb";
			this.count_lb.Size = new System.Drawing.Size(66, 27);
			this.count_lb.TabIndex = 9;
			this.count_lb.Text = "Count:";
			// 
			// add_products_lv
			// 
			this.add_products_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add_products_lv.HideSelection = false;
			this.add_products_lv.Location = new System.Drawing.Point(447, 24);
			this.add_products_lv.Name = "add_products_lv";
			this.add_products_lv.Size = new System.Drawing.Size(264, 424);
			this.add_products_lv.TabIndex = 10;
			this.add_products_lv.UseCompatibleStateImageBehavior = false;
			this.add_products_lv.View = System.Windows.Forms.View.List;
			// 
			// load_products_btn
			// 
			this.load_products_btn.Location = new System.Drawing.Point(717, 236);
			this.load_products_btn.Name = "load_products_btn";
			this.load_products_btn.Size = new System.Drawing.Size(75, 23);
			this.load_products_btn.TabIndex = 9;
			this.load_products_btn.Text = "->";
			this.load_products_btn.UseVisualStyleBackColor = true;
			this.load_products_btn.Click += new System.EventHandler(this.load_products_btn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(19, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 27);
			this.label4.TabIndex = 14;
			this.label4.Text = "Count:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(22, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 27);
			this.label5.TabIndex = 13;
			this.label5.Text = "Info:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(20, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 27);
			this.label6.TabIndex = 11;
			this.label6.Text = "Name:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(20, 54);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 27);
			this.label7.TabIndex = 12;
			this.label7.Text = "Price:";
			// 
			// name_info_lb
			// 
			this.name_info_lb.AutoSize = true;
			this.name_info_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.name_info_lb.Location = new System.Drawing.Point(99, 6);
			this.name_info_lb.Name = "name_info_lb";
			this.name_info_lb.Size = new System.Drawing.Size(22, 27);
			this.name_info_lb.TabIndex = 15;
			this.name_info_lb.Text = "_";
			// 
			// price_info_lb
			// 
			this.price_info_lb.AutoSize = true;
			this.price_info_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price_info_lb.Location = new System.Drawing.Point(99, 54);
			this.price_info_lb.Name = "price_info_lb";
			this.price_info_lb.Size = new System.Drawing.Size(22, 27);
			this.price_info_lb.TabIndex = 15;
			this.price_info_lb.Text = "_";
			// 
			// count_info_lb
			// 
			this.count_info_lb.AutoSize = true;
			this.count_info_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.count_info_lb.Location = new System.Drawing.Point(98, 101);
			this.count_info_lb.Name = "count_info_lb";
			this.count_info_lb.Size = new System.Drawing.Size(22, 27);
			this.count_info_lb.TabIndex = 15;
			this.count_info_lb.Text = "_";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(260, 57);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(51, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "new";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(260, 101);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(51, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "new";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(260, 148);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(51, 23);
			this.button3.TabIndex = 16;
			this.button3.Text = "new";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// change_info_btn
			// 
			this.change_info_btn.Location = new System.Drawing.Point(138, 278);
			this.change_info_btn.Name = "change_info_btn";
			this.change_info_btn.Size = new System.Drawing.Size(75, 28);
			this.change_info_btn.TabIndex = 0;
			this.change_info_btn.Text = "Change";
			this.change_info_btn.UseVisualStyleBackColor = true;
			this.change_info_btn.Click += new System.EventHandler(this.change_info_btn_Click);
			// 
			// product_info_panel
			// 
			this.product_info_panel.Controls.Add(this.info_info_lb);
			this.product_info_panel.Controls.Add(this.button3);
			this.product_info_panel.Controls.Add(this.label7);
			this.product_info_panel.Controls.Add(this.button2);
			this.product_info_panel.Controls.Add(this.label6);
			this.product_info_panel.Controls.Add(this.button1);
			this.product_info_panel.Controls.Add(this.label5);
			this.product_info_panel.Controls.Add(this.label4);
			this.product_info_panel.Controls.Add(this.change_info_btn);
			this.product_info_panel.Controls.Add(this.name_info_lb);
			this.product_info_panel.Controls.Add(this.count_info_lb);
			this.product_info_panel.Controls.Add(this.price_info_lb);
			this.product_info_panel.Location = new System.Drawing.Point(447, 475);
			this.product_info_panel.Name = "product_info_panel";
			this.product_info_panel.Size = new System.Drawing.Size(330, 309);
			this.product_info_panel.TabIndex = 17;
			// 
			// info_info_lb
			// 
			this.info_info_lb.Location = new System.Drawing.Point(90, 146);
			this.info_info_lb.Name = "info_info_lb";
			this.info_info_lb.ReadOnly = true;
			this.info_info_lb.Size = new System.Drawing.Size(164, 110);
			this.info_info_lb.TabIndex = 18;
			this.info_info_lb.Text = "";
			// 
			// new_count_tb
			// 
			this.new_count_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_count_tb.Location = new System.Drawing.Point(807, 579);
			this.new_count_tb.Name = "new_count_tb";
			this.new_count_tb.Size = new System.Drawing.Size(180, 34);
			this.new_count_tb.TabIndex = 14;
			// 
			// new_info_rtb
			// 
			this.new_info_rtb.Location = new System.Drawing.Point(807, 623);
			this.new_info_rtb.Name = "new_info_rtb";
			this.new_info_rtb.Size = new System.Drawing.Size(180, 128);
			this.new_info_rtb.TabIndex = 13;
			this.new_info_rtb.Text = "";
			// 
			// new_price_tb
			// 
			this.new_price_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_price_tb.Location = new System.Drawing.Point(807, 530);
			this.new_price_tb.Name = "new_price_tb";
			this.new_price_tb.Size = new System.Drawing.Size(180, 34);
			this.new_price_tb.TabIndex = 12;
			// 
			// new_price_btn
			// 
			this.new_price_btn.Location = new System.Drawing.Point(1009, 538);
			this.new_price_btn.Name = "new_price_btn";
			this.new_price_btn.Size = new System.Drawing.Size(75, 23);
			this.new_price_btn.TabIndex = 11;
			this.new_price_btn.Text = "Set";
			this.new_price_btn.UseVisualStyleBackColor = true;
			this.new_price_btn.Click += new System.EventHandler(this.new_price_btn_Click);
			// 
			// new_info_btn
			// 
			this.new_info_btn.Location = new System.Drawing.Point(1009, 623);
			this.new_info_btn.Name = "new_info_btn";
			this.new_info_btn.Size = new System.Drawing.Size(75, 23);
			this.new_info_btn.TabIndex = 18;
			this.new_info_btn.Text = "Set";
			this.new_info_btn.UseVisualStyleBackColor = true;
			this.new_info_btn.Click += new System.EventHandler(this.new_info_btn_Click);
			// 
			// new_count_btn
			// 
			this.new_count_btn.Location = new System.Drawing.Point(1009, 581);
			this.new_count_btn.Name = "new_count_btn";
			this.new_count_btn.Size = new System.Drawing.Size(75, 23);
			this.new_count_btn.TabIndex = 19;
			this.new_count_btn.Text = "Set";
			this.new_count_btn.UseVisualStyleBackColor = true;
			this.new_count_btn.Click += new System.EventHandler(this.new_count_btn_Click);
			// 
			// StotreCeeperWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 796);
			this.Controls.Add(this.new_count_btn);
			this.Controls.Add(this.new_info_btn);
			this.Controls.Add(this.new_price_btn);
			this.Controls.Add(this.new_count_tb);
			this.Controls.Add(this.product_info_panel);
			this.Controls.Add(this.load_products_btn);
			this.Controls.Add(this.new_info_rtb);
			this.Controls.Add(this.new_price_tb);
			this.Controls.Add(this.add_products_lv);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.products_pv);
			this.Name = "StotreCeeperWindow";
			this.Text = "StotreCeeperWindow";
			this.Load += new System.EventHandler(this.StotreCeeperWindow_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.product_info_panel.ResumeLayout(false);
			this.product_info_panel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Panel panel1;
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
	}
}
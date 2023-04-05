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
			this.panel1.SuspendLayout();
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
			this.products_pv.Location = new System.Drawing.Point(859, 25);
			this.products_pv.Name = "products_pv";
			this.products_pv.Size = new System.Drawing.Size(264, 423);
			this.products_pv.TabIndex = 2;
			this.products_pv.UseCompatibleStateImageBehavior = false;
			this.products_pv.View = System.Windows.Forms.View.List;
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
			this.load_products_btn.Location = new System.Drawing.Point(750, 236);
			this.load_products_btn.Name = "load_products_btn";
			this.load_products_btn.Size = new System.Drawing.Size(75, 23);
			this.load_products_btn.TabIndex = 9;
			this.load_products_btn.Text = "->";
			this.load_products_btn.UseVisualStyleBackColor = true;
			this.load_products_btn.Click += new System.EventHandler(this.load_products_btn_Click);
			// 
			// StotreCeeperWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 471);
			this.Controls.Add(this.load_products_btn);
			this.Controls.Add(this.add_products_lv);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.products_pv);
			this.Name = "StotreCeeperWindow";
			this.Text = "StotreCeeperWindow";
			this.Load += new System.EventHandler(this.StotreCeeperWindow_Load);
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView add_products_lv;
		private System.Windows.Forms.Button load_products_btn;
		private System.Windows.Forms.TextBox count_tb;
		private System.Windows.Forms.Label count_lb;
	}
}
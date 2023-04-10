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
			this.SuspendLayout();
			// 
			// products_lv
			// 
			this.products_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.products_lv.HideSelection = false;
			this.products_lv.Location = new System.Drawing.Point(13, 13);
			this.products_lv.Name = "products_lv";
			this.products_lv.Size = new System.Drawing.Size(331, 552);
			this.products_lv.TabIndex = 0;
			this.products_lv.UseCompatibleStateImageBehavior = false;
			this.products_lv.View = System.Windows.Forms.View.List;
			// 
			// buy_products_lv
			// 
			this.buy_products_lv.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buy_products_lv.HideSelection = false;
			this.buy_products_lv.Location = new System.Drawing.Point(424, 12);
			this.buy_products_lv.Name = "buy_products_lv";
			this.buy_products_lv.Size = new System.Drawing.Size(331, 552);
			this.buy_products_lv.TabIndex = 1;
			this.buy_products_lv.UseCompatibleStateImageBehavior = false;
			this.buy_products_lv.View = System.Windows.Forms.View.List;
			this.buy_products_lv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buy_products_lv_MouseClick);
			// 
			// load_products_btn
			// 
			this.load_products_btn.Location = new System.Drawing.Point(347, 248);
			this.load_products_btn.Name = "load_products_btn";
			this.load_products_btn.Size = new System.Drawing.Size(75, 23);
			this.load_products_btn.TabIndex = 2;
			this.load_products_btn.Text = "->";
			this.load_products_btn.UseVisualStyleBackColor = true;
			this.load_products_btn.Click += new System.EventHandler(this.Load_products_btn_Click);
			// 
			// buy_btn
			// 
			this.buy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buy_btn.Location = new System.Drawing.Point(859, 330);
			this.buy_btn.Name = "buy_btn";
			this.buy_btn.Size = new System.Drawing.Size(129, 36);
			this.buy_btn.TabIndex = 3;
			this.buy_btn.Text = "Buy";
			this.buy_btn.UseVisualStyleBackColor = true;
			this.buy_btn.Click += new System.EventHandler(this.Buy_Click);
			// 
			// final_price_main_lb
			// 
			this.final_price_main_lb.AutoSize = true;
			this.final_price_main_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.final_price_main_lb.Location = new System.Drawing.Point(841, 251);
			this.final_price_main_lb.Name = "final_price_main_lb";
			this.final_price_main_lb.Size = new System.Drawing.Size(94, 38);
			this.final_price_main_lb.TabIndex = 4;
			this.final_price_main_lb.Text = "Cost:";
			// 
			// final_price_lb
			// 
			this.final_price_lb.AutoSize = true;
			this.final_price_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.final_price_lb.Location = new System.Drawing.Point(952, 251);
			this.final_price_lb.Name = "final_price_lb";
			this.final_price_lb.Size = new System.Drawing.Size(35, 38);
			this.final_price_lb.TabIndex = 4;
			this.final_price_lb.Text = "0";
			// 
			// clean_btn
			// 
			this.clean_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clean_btn.Location = new System.Drawing.Point(859, 389);
			this.clean_btn.Name = "clean_btn";
			this.clean_btn.Size = new System.Drawing.Size(129, 36);
			this.clean_btn.TabIndex = 3;
			this.clean_btn.Text = "Clear";
			this.clean_btn.UseVisualStyleBackColor = true;
			this.clean_btn.Click += new System.EventHandler(this.Clean_Click);
			// 
			// new_price_lb
			// 
			this.new_price_lb.AutoSize = true;
			this.new_price_lb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_price_lb.Location = new System.Drawing.Point(904, 57);
			this.new_price_lb.Name = "new_price_lb";
			this.new_price_lb.Size = new System.Drawing.Size(22, 27);
			this.new_price_lb.TabIndex = 5;
			this.new_price_lb.Text = "1";
			// 
			// new_price_tb
			// 
			this.new_price_tb.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_price_tb.Location = new System.Drawing.Point(798, 52);
			this.new_price_tb.Name = "new_price_tb";
			this.new_price_tb.Size = new System.Drawing.Size(100, 34);
			this.new_price_tb.TabIndex = 6;
			// 
			// new_price_btn
			// 
			this.new_price_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.new_price_btn.Location = new System.Drawing.Point(932, 52);
			this.new_price_btn.Name = "new_price_btn";
			this.new_price_btn.Size = new System.Drawing.Size(88, 37);
			this.new_price_btn.TabIndex = 3;
			this.new_price_btn.Text = "Set";
			this.new_price_btn.UseVisualStyleBackColor = true;
			this.new_price_btn.Click += new System.EventHandler(this.New_price_btn_Click);
			// 
			// SellerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 577);
			this.Controls.Add(this.new_price_tb);
			this.Controls.Add(this.new_price_lb);
			this.Controls.Add(this.final_price_lb);
			this.Controls.Add(this.final_price_main_lb);
			this.Controls.Add(this.clean_btn);
			this.Controls.Add(this.new_price_btn);
			this.Controls.Add(this.buy_btn);
			this.Controls.Add(this.load_products_btn);
			this.Controls.Add(this.buy_products_lv);
			this.Controls.Add(this.products_lv);
			this.Name = "SellerWindow";
			this.Text = "SellerWindow";
			this.Load += new System.EventHandler(this.SellerWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}
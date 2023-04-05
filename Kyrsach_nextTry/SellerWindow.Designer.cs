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
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
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
			// 
			// load_products_btn
			// 
			this.load_products_btn.Location = new System.Drawing.Point(347, 248);
			this.load_products_btn.Name = "load_products_btn";
			this.load_products_btn.Size = new System.Drawing.Size(75, 23);
			this.load_products_btn.TabIndex = 2;
			this.load_products_btn.Text = "->";
			this.load_products_btn.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(880, 217);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(129, 36);
			this.button2.TabIndex = 3;
			this.button2.Text = "Buy";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(862, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 39);
			this.label1.TabIndex = 4;
			this.label1.Text = "Cost:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(973, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 39);
			this.label2.TabIndex = 4;
			this.label2.Text = "0";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(880, 276);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(129, 36);
			this.button3.TabIndex = 3;
			this.button3.Text = "Clear";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// SellerWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 577);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
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
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
	}
}
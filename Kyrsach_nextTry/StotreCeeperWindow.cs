using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach_nextTry
{
	public partial class StotreCeeperWindow : Form
	{
		List<(Product, int)> products;
		List<(Product, int)> add_products = new List<(Product, int)>();
		(Product, int) product;
		int product_index;
		public StotreCeeperWindow()
		{
			InitializeComponent();
		}

		private void StotreCeeperWindow_Load(object sender, EventArgs e)
		{
			ReloadProducts();
			new_count_btn.Visible = false;
			new_count_tb.Visible = false;
			new_price_btn.Visible = false;
			new_price_tb.Visible = false;
			new_info_btn.Visible = false;
			new_info_rtb.Visible = false; 
			product_info_panel.Visible = false;
			add_new_panel.Visible = false;

		}
		private void ReloadProducts()
		{
			products = MyData.LoadProducts();
			products_pv.Items.Clear();
			for (int i = 0; i < products.Count; i++) products_pv.Items.Add(products[i].Item1.ToString() + " " + products[i].Item2+ " gr.");
		}

		private void add_btn_Click(object sender, EventArgs e)
		{
			add_products.Add((new Product(name_tb.Text, Convert.ToDouble(price_tb.Text), info_rtb.Text), Convert.ToInt32(count_tb.Text)));
			add_products_lv.Items.Clear();
			for (int i = 0; i < add_products.Count; i++)
				add_products_lv.Items.Add(add_products[i].Item1.ToString() + " " + add_products[i].Item2+" gr.");
			name_tb.Text = "";
			price_tb.Text = "";
			count_tb.Text = "";
			info_rtb.Text = "";
		}

		private void load_products_btn_Click(object sender, EventArgs e)
		{
			add_products_lv.Items.Clear();
			products_pv.Items.Clear();
			for (int i = 0; i < add_products.Count;i++) products.Add(add_products[i]);
			File.Delete(Product.Path);
			MyData.SaveList(products);
			ReloadProducts();
			add_products.Clear();
		}

		private void products_pv_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			MessageBox.Show("checked");
		}

		private void products_pv_MouseClick(object sender, MouseEventArgs e)
		{
			product_info_panel.Visible = true;
			add_new_panel.Visible = false;
			products = MyData.LoadProducts();
			product_index = products_pv.Items.IndexOf(products_pv.SelectedItems[0]);
			product = products[product_index];
			Reload_info();
		}

		private void Reload_info()
		{
			name_info_lb.Text = product.Item1.Name;
			price_info_lb.Text = Convert.ToString(product.Item1.Price);
			info_info_lb.Text = product.Item1.Info;
			count_info_lb.Text = Convert.ToString(product.Item2);
		}

		private void new_count_btn_Click(object sender, EventArgs e)
		{
			new_count_btn.Visible = false;
			new_count_tb.Visible = false;
			product.Item2 = Convert.ToInt32(new_count_tb.Text);
			Reload_info();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			new_count_btn.Visible = true;
			new_count_tb.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			new_price_btn.Visible = true;
			new_price_tb.Visible = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			new_info_btn.Visible = true;
			new_info_rtb.Visible = true;
		}

		private void new_price_btn_Click(object sender, EventArgs e)
		{
			new_price_btn.Visible = false;
			new_price_tb.Visible = false;
			product.Item1.Price = Convert.ToDouble(new_price_tb.Text);
			Reload_info();
		}

		private void new_info_btn_Click(object sender, EventArgs e)
		{
			new_info_btn.Visible = false;
			new_info_rtb.Visible = false;
			product.Item1.Info = new_info_rtb.Text;
			Reload_info();
		}

		private void change_info_btn_Click(object sender, EventArgs e)
		{
			products = MyData.LoadProducts(); ;
			product_info_panel.Visible = false;
			products[product_index] = product;
			File.Delete(Product.Path);
			MyData.SaveList(products);
			ReloadProducts();
		}

		private void Add_new_btn(object sender, EventArgs e)
		{
			add_new_panel.Visible = true;
		}
	}
}

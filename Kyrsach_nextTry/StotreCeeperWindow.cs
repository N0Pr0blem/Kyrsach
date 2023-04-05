using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
		public StotreCeeperWindow()
		{
			InitializeComponent();
		}

		private void StotreCeeperWindow_Load(object sender, EventArgs e)
		{
			ReloadProducts();
		}
		private void ReloadProducts()
		{
			products = MyData.LoadProducts();
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
			MyData.SaveList(products);
			ReloadProducts();
			add_products.Clear();
		}
	}
}

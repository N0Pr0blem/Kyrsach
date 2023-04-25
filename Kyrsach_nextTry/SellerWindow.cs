using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach_nextTry
{
	public partial class SellerWindow : Form
	{
		List<(Product, int)> products;
		List<Product> choose_products = new List<Product>();
		Product choose_product;
		List<int> count_choose_products = new List<int>();
		public SellerWindow()
		{
			InitializeComponent();
		}

		private void SellerWindow_Load(object sender, EventArgs e)
		{
			searchs_cb.SelectedIndex = 0;
			sorts_cb.SelectedIndex = 0;
			ReloadProducts();
			new_price_btn.Visible = false;
			new_price_lb.Visible = false;
			new_price_tb.Visible = false;
		}
		void ReloadProducts()
		{
			products_lv.Items.Clear();
			products = Sort_list(MyData.LoadProducts());
			for (int i = 0; i < products.Count; i++)
			{
				products_lv.Items.Add(products[i].Item1.ToString() + " " + products[i].Item2 + " шт.");
			}
		}
		void ReloadProducts(List<(Product,int)> search)
		{
			products_lv.Items.Clear();
			products =search;
			for (int i = 0; i < products.Count; i++)
			{
				products_lv.Items.Add(products[i].Item1.ToString() + " " + products[i].Item2 + " шт.");
			}
		}

		private void Load_products_btn_Click(object sender, EventArgs e)
		{
			products = MyData.LoadProducts();
			for (int i = 0; i < products_lv.SelectedItems.Count; i++)
			{
				if (!choose_products.Contains(products[products_lv.Items.IndexOf(products_lv.SelectedItems[i])].Item1) && products[products_lv.Items.IndexOf(products_lv.SelectedItems[i])].Item2 != 0)
				{
					Product product = products[products_lv.Items.IndexOf(products_lv.SelectedItems[i])].Item1;
					choose_products.Add(product);
					count_choose_products.Add(1);
				}
			}
			Reload_buy_products();

		}

		private void Reload_buy_products()
		{
			double sum_price = 0;
			buy_products_lv.Items.Clear();
			for (int i = 0; i < choose_products.Count; i++)
			{
				buy_products_lv.Items.Add(choose_products[i].ToString() + " " + count_choose_products[i] + " шт.");
				sum_price += count_choose_products[i] * choose_products[i].Price;
			}
			final_price_lb.Text = Convert.ToString(sum_price);
		}

		private void Clean_Click(object sender, EventArgs e)
		{
			Clean_All();
		}

		private void Clean_All()
		{
			choose_products.Clear();
			count_choose_products.Clear();
			buy_products_lv.Items.Clear();
			final_price_lb.Text = "0";
			new_price_btn.Visible = false;
			new_price_lb.Visible = false;
			new_price_tb.Visible = false;
		}

		private void Buy_products_lv_MouseClick(object sender, MouseEventArgs e)
		{
			new_price_btn.Visible = true;
			new_price_lb.Visible = true;
			new_price_tb.Visible = true;

			choose_product = choose_products[buy_products_lv.Items.IndexOf(buy_products_lv.SelectedItems[0])];
			new_price_lb.Text = Convert.ToString(products[IndexOfProductInProducts(choose_product)].Item2);

		}
		public int IndexOfProductInProducts(Product product)
		{
			for (int i = 0; i < products.Count; i++)
				if (products[i].Item1.Equals(product)) return i;
			return -1;
		}

		private void New_price_btn_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(new_price_lb.Text) >= Convert.ToInt32(new_price_tb.Text) && Convert.ToInt32(new_price_tb.Text) > 0)
			{
				count_choose_products[choose_products.IndexOf(choose_product)] = Convert.ToInt32(new_price_tb.Text);

				new_price_btn.Visible = false;
				new_price_lb.Visible = false;
				new_price_tb.Visible = false;
				new_price_tb.Text = "1";
				Reload_buy_products();
			}
			else MessageBox.Show("Try again...");
		}

		private void Buy_Click(object sender, EventArgs e)
		{
			products = Sort_list(MyData.LoadProducts());
			for (int i = 0; i < choose_products.Count; i++)
				products[IndexOfProductInProducts(choose_products[i])] = (choose_products[i], products[IndexOfProductInProducts(choose_products[i])].Item2 - count_choose_products[i]);
			File.Delete(Product.Path);
			MyData.SaveList(products);
			ReloadProducts();
			Clean_All();
		}

		private void sorts_cb_SelectedIndexChanged(object sender, EventArgs e)
		{
			ReloadProducts();
		}
		private List<(Product, int)> Sort_list(List<(Product, int)> products)
		{
			List<(Product, int)> result = new List<(Product, int)>();
			switch (sorts_cb.SelectedIndex)
			{
				case 0:
					var sort = products.OrderBy(p => p.Item1.Name);
					foreach ((Product, int) p in sort) result.Add(p);
					break;
				case 1:
					sort = products.OrderByDescending(p => p.Item1.Name);
					foreach ((Product, int) p in sort) result.Add(p);
					break;
				case 2:
					sort = products.OrderBy(p => p.Item1.Price);
					foreach ((Product, int) p in sort) result.Add(p);
					break;
				case 3:
					sort = products.OrderByDescending(p => p.Item1.Price);
					foreach ((Product, int) p in sort) result.Add(p);
					break;
				case 4:
					sort = products.OrderBy(p => p.Item2);
					foreach ((Product, int) p in sort) result.Add(p);
					break;
				case 5:
					sort = products.OrderByDescending(p => p.Item2);
					foreach ((Product, int) p in sort) result.Add(p);
					break;
			}
			return result;
		}

		private void search_btn_Click(object sender, EventArgs e)
		{
			products = MyData.LoadProducts();
			if (search_tb.Text != "")
			{
				List<(Product, int)> search = new List<(Product, int)>();
				foreach ((Product, int) p in products)
					switch (searchs_cb.SelectedIndex)
					{
						case 0:
							if (p.Item1.Name == search_tb.Text) search.Add(p);
							break;
						case 1:
							if (Convert.ToString(p.Item1.Price) == search_tb.Text) search.Add(p);
							break;
						case 2:
							if (Convert.ToString(p.Item2) == search_tb.Text) search.Add(p);
							break;
					}
				ReloadProducts(search);
			}
			else ReloadProducts();
		}

		private void products_lv_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			products = Sort_list(MyData.LoadProducts());
			for (int i = 0; i < products_lv.SelectedItems.Count; i++)
			{
				if (!choose_products.Contains(products[products_lv.Items.IndexOf(products_lv.SelectedItems[i])].Item1) && products[products_lv.Items.IndexOf(products_lv.SelectedItems[i])].Item2 != 0)
				{
					Product product = products[products_lv.Items.IndexOf(products_lv.SelectedItems[i])].Item1;
					choose_products.Add(product);
					count_choose_products.Add(1);
				}
			}
			Reload_buy_products();
		}
	}
}

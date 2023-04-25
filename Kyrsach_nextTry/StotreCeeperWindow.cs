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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrsach_nextTry
{
	public partial class StotreCeeperWindow : Form
	{
		List<(Product, int)> products;
		List<(Product, int)> add_products = new List<(Product, int)>();
		(Product, int) product;
		int product_index;
		string imagePath;
		public StotreCeeperWindow()
		{
			InitializeComponent();
		}

		private void StotreCeeperWindow_Load(object sender, EventArgs e)
		{
			sorts_cb.SelectedIndex = 0;
			searchs_cb.SelectedIndex = 0;
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
			products = Sort_list(MyData.LoadProducts());
			products_pv.Items.Clear();
			for (int i = 0; i < products.Count; i++) products_pv.Items.Add(products[i].Item1.ToString() + " " + products[i].Item2 + " шт.");
		}

		private void add_btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (name_tb.Text != "" && price_tb.Text != "" && count_tb.Text != "" && info_rtb.Text != "")
				{
					add_products.Add((new Product(name_tb.Text, Convert.ToDouble(price_tb.Text), info_rtb.Text, imagePath), Convert.ToInt32(count_tb.Text)));
					add_products_lv.Items.Clear();
					for (int i = 0; i < add_products.Count; i++)
						add_products_lv.Items.Add(add_products[i].Item1.ToString() + " " + add_products[i].Item2 + " шт.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				name_tb.Text = "";
				price_tb.Text = "";
				count_tb.Text = "";
				info_rtb.Text = "";
				pictureBox.Image = null;
			}
		}

		private void load_products_btn_Click(object sender, EventArgs e)
		{
			add_products_lv.Items.Clear();
			products_pv.Items.Clear();
			for (int i = 0; i < add_products.Count; i++) products.Add(add_products[i]);
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
			if (product.Item1.ImagePath != null) pictureBox1.Image = Image.FromFile(product.Item1.ImagePath);
		}

		private void new_count_btn_Click(object sender, EventArgs e)
		{
			try
			{
				new_count_btn.Visible = false;
				new_count_tb.Visible = false;
				if (new_count_tb.Text != "")
				{
					product.Item2 = Convert.ToInt32(new_count_tb.Text);
					Reload_info();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				new_count_tb.Text = "";
			}
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
			try
			{
				new_price_btn.Visible = false;
				new_price_tb.Visible = false;
				if (new_price_tb.Text != "")
				{
					product.Item1.Price = Convert.ToDouble(new_price_tb.Text);
					Reload_info();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				new_price_tb.Text = "";
			}
		}

		private void new_info_btn_Click(object sender, EventArgs e)
		{
			new_info_btn.Visible = false;
			new_info_rtb.Visible = false;
			if (new_info_rtb.Text != "")
			{
				product.Item1.Info = new_info_rtb.Text;
				Reload_info();
			}
			new_info_rtb.Text = "";
		}

		private void change_info_btn_Click(object sender, EventArgs e)
		{
			products = Sort_list(MyData.LoadProducts());
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

		private void new_info_rtb_TextChanged(object sender, EventArgs e)
		{

		}

		private void choose_btn_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			imagePath = openFileDialog1.FileName;
			Image fileImage = Image.FromFile(imagePath);
			pictureBox.Image = fileImage;
			MessageBox.Show("Файл открыт");
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			imagePath = openFileDialog1.FileName;
			Image fileImage = Image.FromFile(imagePath);
			pictureBox1.Image = fileImage;
			MessageBox.Show("Файл открыт");
			product.Item1.ImagePath = imagePath;
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
		private void sorts_cb_SelectedIndexChanged(object sender, EventArgs e)
		{
			ReloadProducts();
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
		private void ReloadProducts(List<(Product, int)> search)
		{
			products = Sort_list(search);
			products_pv.Items.Clear();
			for (int i = 0; i < products.Count; i++) products_pv.Items.Add(products[i].Item1.ToString() + " " + products[i].Item2 + " шт.");

		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach_nextTry
{
	public partial class Form1 : Form
	{
		List<User> users;
		User user;
		List<(Product, int)> products;
		int product_index;
		(Product, int) product;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EnterAllAccessFromDataToRoleCb();
			show_all_persons();
			role_cb.SelectedIndex = 0;
			searchs_cb.SelectedIndex = 0;
			sorts_cb.SelectedIndex = 0;
			add_new_panel.Visible = false;
			product_info_panel.Visible = false;
			users_info_panel.Visible = false;
			ReloadProducts();
		}

		private void ReloadProducts()
		{
			products = Sort_list(MyData.LoadProducts());
			products_pv.Items.Clear();
			for (int i = 0; i < products.Count; i++) products_pv.Items.Add(products[i].Item1.ToString() + " " + products[i].Item2 + " шт.");
		}
		private void EnterAllAccessFromDataToRoleCb()
		{
			role_cb.Items.Add(MyData.Access.ADMIN);
			role_cb.Items.Add(MyData.Access.SELLER);
			role_cb.Items.Add(MyData.Access.STOREKEEPER);
		}

		private void Add_btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (name_tb.Text!="" && surname_tb.Text != "" && login_tb.Text != "" && password_tb.Text != "")
				{
					users = MyData.LoadUsers();
					users.Add(new User(name_tb.Text, surname_tb.Text, login_tb.Text, password_tb.Text, (MyData.Access)(role_cb.SelectedItem)));
					MyData.SaveList(users);
					show_all_persons();
				}
			}
			catch (NullReferenceException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				name_tb.Text = "";
				surname_tb.Text = "";
				password_tb.Text = "";
				login_tb.Text = "";
				role_cb.Text = role_cb.Items[0].ToString();
				add_new_panel.Visible = false;
			}
		}

		private void delete_btn_Click(object sender, EventArgs e)
		{
			List<User> users = MyData.LoadUsers();
			List<User> delete_users = new List<User>();

			File.Delete(User.Path);
			for (int i = 0; i < persons_lv.SelectedItems.Count; i++)
				delete_users.Add(users[persons_lv.Items.IndexOf(persons_lv.SelectedItems[i])]);
			for (int i = 0; i < persons_lv.SelectedItems.Count; i++)
				users.Remove(delete_users[i]);
			delete_users.Clear();

			MyData.SaveList(users);
			show_all_persons();
			users_info_panel.Visible = false;
		}
		void show_all_persons()
		{
			persons_lv.Items.Clear();
			List<User> users = MyData.LoadUsers();
			if (users != null)
				for (int i = 0; i < users.Count; i++)
					persons_lv.Items.Add(users[i].Login + " (" + users[i].Access + ");");
		}

		private void show_btn_Click(object sender, EventArgs e)
		{
			List<User> users = MyData.LoadUsers();
			for (int i = 0; i < persons_lv.SelectedItems.Count; i++)
				MessageBox.Show(Convert.ToString($"Name: {users[persons_lv.Items.IndexOf(persons_lv.SelectedItems[i])].Name}" +
					$";\nSurname: {users[persons_lv.Items.IndexOf(persons_lv.SelectedItems[i])].Surname}" +
					$";\nLogin: {users[persons_lv.Items.IndexOf(persons_lv.SelectedItems[i])].Login}" +
					$";\nPassword: {Convert.ToString(users[persons_lv.Items.IndexOf(persons_lv.SelectedItems[i])].Password)};\n"));
		}

		private void add_new_show_btn_Click(object sender, EventArgs e)
		{
			add_new_panel.Visible = true;
			users_info_panel.Visible = false;
			product_info_panel.Visible = false;
		}

		private void persons_lv_MouseClick(object sender, MouseEventArgs e)
		{
			int user_index;
			users = MyData.LoadUsers();
			users_info_panel.Visible = true;
			add_new_panel.Visible = false;
			product_info_panel.Visible = false;
			user_index = persons_lv.Items.IndexOf(persons_lv.SelectedItems[0]);
			user = users[user_index];
			Reload_users_info();
		}

		private void Reload_users_info()
		{
			users_name_tb.Text = user.Name;
			users_surname_tb.Text = user.Surname;
			users_login_tb.Text = user.Login;
			users_access_tb.Text = user.Access.ToString();
			users_password_tb.Text = user.Password;
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

		private void close_users_info_panel_btn_Cick(object sender, EventArgs e)
		{
			users_info_panel.Visible = false;
		}

		private void show_password_rb_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked) users_password_tb.UseSystemPasswordChar = false;
			else users_password_tb.UseSystemPasswordChar = true;
		}

		private void sorts_cb_SelectedIndexChanged(object sender, EventArgs e)
		{
			ReloadProducts();
		}

		private void products_pv_MouseClick(object sender, MouseEventArgs e)
		{
			product_info_panel.Visible = true;
			users_info_panel.Visible = false;
			add_new_panel.Visible = false;
			products = MyData.LoadProducts();
			product_index = products_pv.Items.IndexOf(products_pv.SelectedItems[0]);
			product = products[product_index];
			Reload_info();
		}
		private void Reload_info()
		{
			name_info_lb.Text = product.Item1.Name;
			info_info_lb.Text = product.Item1.Info;
			price_info_lb.Text = Convert.ToString(product.Item1.Price);
			count_info_lb.Text = Convert.ToString(product.Item2);
			if(product.Item1.ImagePath!=null) pictureBox1.Image = Image.FromFile(product.Item1.ImagePath);
		}

		private void change_info_btn_Click(object sender, EventArgs e)
		{
			products = MyData.LoadProducts();
			products.RemoveAt(products_pv.Items.IndexOf(products_pv.SelectedItems[0]));
			File.Delete(Product.Path);
			MyData.SaveList(products);
			ReloadProducts();
			product_info_panel.Visible=false;
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

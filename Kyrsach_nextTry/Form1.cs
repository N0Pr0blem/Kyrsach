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
	public partial class Form1 : Form
	{
		List<User> users;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EnterAllAccessFromDataToRoleCb();
			show_all_persons();
			StotreCeeperWindow stotreCeeperWindow = new StotreCeeperWindow();
			stotreCeeperWindow.Show();
			SellerWindow sellerWindow = new SellerWindow();
			sellerWindow.Show();
		}
		private void EnterAllAccessFromDataToRoleCb()
		{
			role_cb.Items.Add(MyData.Access.ADMIN);
			role_cb.Items.Add(MyData.Access.SELLER);
			role_cb.Items.Add(MyData.Access.STOREKEEPER);
		}

		private void Add_btn_Click(object sender, EventArgs e)
		{
			users = MyData.LoadUsers();
			users.Add(new User(name_tb.Text, surname_tb.Text, login_tb.Text, password_tb.Text, (MyData.Access)(role_cb.SelectedItem)));
			MyData.SaveList(users);
			show_all_persons();

			name_tb.Text = "";
			surname_tb.Text = "";
			password_tb.Text = "";
			login_tb.Text = "";
			role_cb.SelectedItem = null;
		}

		private void delete_btn_Click(object sender, EventArgs e)
		{
			List<User> users = MyData.LoadUsers();
			File.Delete(User.Path);
			for (int i =0;i< person_listV.SelectedItems.Count; i++)
			{
				users.RemoveAt(person_listV.Items.IndexOf(person_listV.SelectedItems[i]));
			}

			MyData.SaveList(users);
			show_all_persons();
		}
		void show_all_persons()
		{
			person_listV.Items.Clear();
			List<User> users = MyData.LoadUsers();
			if(users!=null)
				for (int i = 0; i < users.Count; i++)
					person_listV.Items.Add(users[i].Login + " (" + users[i].Access + ");");
		}
	}
}

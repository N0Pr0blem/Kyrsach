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
		List<string> choose_items;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			EnterAllAccessFromDataToRoleCb();
			show_all_persons();
			role_cb.Text = role_cb.Items[0].ToString();
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
				users = MyData.LoadUsers();
				users.Add(new User(name_tb.Text, surname_tb.Text, login_tb.Text, password_tb.Text, (MyData.Access)(role_cb.SelectedItem)));
				MyData.SaveList(users);
				show_all_persons();
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

		private void persons_lv_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

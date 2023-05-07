using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsach_nextTry
{
	public partial class RegWindow : Form
	{
		public RegWindow()
		{
			InitializeComponent();
		}

		private void RegWindow_Load(object sender, EventArgs e)
		{
			SetDefoultColors();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			List<User> users = MyData.LoadUsers();
			bool flag = false;

			for(int i = 0; i < users.Count; i++)
			{
				if (users[i].GetMainInfo() == (login_tb.Text + " " + password_tb.Text))
				{
					switch (users[i].Access)
					{
						case MyData.Access.STOREKEEPER:
							StotreCeeperWindow scw = new StotreCeeperWindow();
							scw.ShowDialog();
							break;
						case MyData.Access.ADMIN:
							Form1 form1 = new Form1();
							form1.ShowDialog();
							break;
						case MyData.Access.SELLER:
							SellerWindow sellerWindow = new SellerWindow();
							sellerWindow.ShowDialog();
							break;
					}
					flag = true;
					login_tb.Text = "";
					password_tb.Text = "";
				}
			}
			if (!flag) {
				MessageBox.Show("Неверный логин или пароль..!");
				password_tb.Text = "";
			}
		}
		private void SetDefoultColors()
		{
			BackColor = MyData.MainBackColor;

			button1.BackColor = MyData.ButtonBackColor;

			panel1.BackColor = MyData.PanelBackColor;
			
			foreach (Control c in Controls) c.ForeColor = MyData.MainForeColor;
		}
	}
}

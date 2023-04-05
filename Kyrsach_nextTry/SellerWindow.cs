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
	public partial class SellerWindow : Form
	{
		List<(Product,int)> products;
		public SellerWindow()
		{
			InitializeComponent();
		}

		private void SellerWindow_Load(object sender, EventArgs e)
		{
			LoadProducts();
		}
		void LoadProducts()
		{
			products = MyData.LoadProducts();
			for (int i = 0; i < products.Count; i++)
			{
				products_lv.Items.Add(products[i].Item1.ToString()+" "+ products[i].Item2+" gr.");
			}
		}
	}
}

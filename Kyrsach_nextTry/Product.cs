using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach_nextTry
{
	[Serializable]
	public class Product
	{
		public const string Path = @"../../data_files/Products.XML";
		public string Name { get; set; }
		public double Price { get; set; }
		public string Info { get; set; }

		public Product(string name, double price, string info)
		{
			Name = name;
			Price = price;
			Info = info;
		}
		public Product() { }

		public override bool Equals(object obj)
		{
			return (((Product)obj).Name== Name && ((Product)obj).Price == Price && ((Product)obj).Info == Info);
		}

		public override string ToString()
		{
			return Convert.ToString($"{Name} {Price} BYN");
		}
	}
}

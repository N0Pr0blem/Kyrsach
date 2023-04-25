using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach_nextTry
{
	[Serializable]
	public class Product : IEquatable<Product> , IComparable<Product>
	{
		public const string Path = @"../../data_files/Products.XML";
		public string Name { get; set; }
		public double Price { get; set; }
		public string Info { get; set; }
		public string ImagePath { get; set; }

		public Product(string name, double price, string info)
		{
			Name = name;
			Price = price;
			Info = info;
		}
		public Product(string name, double price, string info, string imagePath)
		{
			Name = name;
			Price = price;
			Info = info;
			ImagePath = imagePath;
		}
		public Product() { }

		public int CompareTo(Product comparePart)
		{
			if (comparePart == null)
				return 1;

			else
				return this.Price.CompareTo(comparePart.Price);
		}
		public int SortByNameAscending(string name1, string name2)
		{

			return name1.CompareTo(name2);
		}

		public override bool Equals(object obj)
		{
			return (((Product)obj).Name== Name && ((Product)obj).Price == Price && ((Product)obj).Info == Info);
		}

		public override string ToString()
		{
			return Convert.ToString($"{Name} {Price} BYN");
		}

		public bool Equals(Product other)
		{
			return (other.Name == Name && other.Price == Price && other.Info == Info);
		}
	}
}

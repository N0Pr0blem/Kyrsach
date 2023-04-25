using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kyrsach_nextTry
{
	public class MyData
	{
		public enum Access { ADMIN, SELLER, STOREKEEPER }
		public static string[] Sorts = {"Назвнию ↑","Назвнию ↓","Цене ↑","Цене ↓","Количеству ↑","Количеству ↓"};

		public static void SaveList(List<User> list)
		{
			XmlSerializer xmlSerializer;
			xmlSerializer = new XmlSerializer(typeof(List<User>));
			using (FileStream fs = new FileStream(User.Path, FileMode.OpenOrCreate))
			{
				xmlSerializer.Serialize(fs, list);
			}
		}
		public static List<User> LoadUsers()
		{
			XmlSerializer xmlSerializer;
			xmlSerializer = new XmlSerializer(typeof(List<User>));
			using (FileStream filestream = new FileStream(User.Path, FileMode.OpenOrCreate))
			{
				List<User> list = xmlSerializer.Deserialize(filestream) as List<User>;
				return list;
			}
		}
		public static void SaveList(List<(Product, int)> list)
		{
			XmlSerializer xmlSerializer;
			xmlSerializer = new XmlSerializer(typeof(List<(Product, int)>));
			using (FileStream fs = new FileStream(Product.Path, FileMode.OpenOrCreate))
			{
				xmlSerializer.Serialize(fs, list);
			}
		}
		public static List<(Product, int)> LoadProducts()
		{
			XmlSerializer xmlSerializer;
			xmlSerializer = new XmlSerializer(typeof(List<(Product, int)>));
			using (FileStream filestream = new FileStream(Product.Path, FileMode.OpenOrCreate))
			{
				List<(Product, int)> list = xmlSerializer.Deserialize(filestream) as List<(Product, int)>;
				return list;
			}
		}
	}
}

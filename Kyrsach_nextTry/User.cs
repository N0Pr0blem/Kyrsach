using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrsach_nextTry
{
	[Serializable]
	public class User
	{
		public const string Path = "../../data_files/Users.XML";
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public MyData.Access Access { get; set; }

		public User(string name, string surname, string login, string password, MyData.Access access)
		{
			Name = name;
			Surname = surname;
			Login = login;
			Password = password;
			Access = access;
		}
		public User() { }

		public override string ToString()
		{
			return Convert.ToString(($"{0}, {1}, {2}, {3}.", Name, Surname, Login, Password));
		}
		public override bool Equals(object obj)
		{
			return (Name == ((User)obj).Name && Surname == ((User)obj).Surname && Login == ((User)obj).Login && Password == ((User)obj).Password);
		}
	}
}

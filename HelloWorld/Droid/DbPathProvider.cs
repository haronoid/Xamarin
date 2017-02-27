using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(HelloWorld.Droid.DbPathProvider))]
namespace HelloWorld.Droid
{
	public class DbPathProvider : IDbPathProvider
	{
		public DbPathProvider()
		{
		}

		public string GetPath()
		{
			return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "database.db3");
		}
	}
}

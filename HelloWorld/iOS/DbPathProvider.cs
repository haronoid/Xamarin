using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(HelloWorld.iOS.DbPathProvider))]
namespace HelloWorld.iOS
{
	public class DbPathProvider : IDbPathProvider
	{
		public DbPathProvider()
		{
		}

		public string GetPath()
		{
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..",
			                        "Library",
			                        "Databases");
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			return Path.Combine(path, "database.db3");
		}
	}
}

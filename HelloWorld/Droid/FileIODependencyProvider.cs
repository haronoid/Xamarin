using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(HelloWorld.Droid.FileIODependencyProvider))]
namespace HelloWorld.Droid
{
	public class FileIODependencyProvider : IFileIO
	{
		public FileIODependencyProvider()
		{
		}

		public string read(string filename)
		{
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);

			if (!File.Exists(path))
			{
				return "";
			}
			return File.ReadAllText(path);
		}

		public void Save(string filename, string text)
		{
			var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
			File.WriteAllText(path, text);
		}
	}
}

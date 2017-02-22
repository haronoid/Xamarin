
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class PropertiesStorePage : ContentPage
	{
		async void Store_Clicked(object sender, System.EventArgs e)
		{
			Application.Current.Properties["input"] = this.entry.Text;
			await Application.Current.SavePropertiesAsync();
		}

		void Restore_Clicked(object sender, System.EventArgs e)
		{
			if (Application.Current.Properties.ContainsKey("input"))
			{
				this.entry.Text = (string)Application.Current.Properties["input"];
			}
		}

		void Save_Clicked(object sender, System.EventArgs e)
		{
			DependencyService.Get<IFileIO>().Save("sample.txt", fileentry.Text);
		}

		void Read_Clicked(object sender, System.EventArgs e)
		{
			fileentry.Text = DependencyService.Get<IFileIO>().read("sample.txt");
		}

		public PropertiesStorePage()
		{
			InitializeComponent();
		}
	}

	public interface IFileIO
	{
		void Save(string filename, string text);
		string read(string filename);
	}
}

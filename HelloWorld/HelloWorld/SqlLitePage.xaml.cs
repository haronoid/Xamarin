using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class SqlLitePage : ContentPage
	{
		public SqlLitePage()
		{
			InitializeComponent();
		}

		void Add_Clicked(object sender, System.EventArgs e)
		{
		
		}
	}


	public interface IDbPathProvider
	{
		string GetPath();
	}
}

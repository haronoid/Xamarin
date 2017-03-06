using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SQLite;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class SqlLitePage : ContentPage
	{
		private SQLiteAsyncConnection conn { get; }

		public SqlLitePage()
		{
			InitializeComponent();
			this.conn = new SQLiteAsyncConnection(DependencyService.Get<IDbPathProvider>().GetPath());
			this.conn.CreateTableAsync<Person>().Wait();
		}


		async void Add_Clicked(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.entryName.Text))
			{
				return;
			}

			await this.conn.InsertAsync(new Person { Name=this.entryName.Text });
			this.entryName.Text = "";
			await this.LoadAsync();
		}

		async void Reflesh_Clicked(object sender, System.EventArgs e)
		{
			await this.LoadAsync();
		}


		private async Task LoadAsync()
		{
			this.listView.ItemsSource = await this.conn.Table<Person>().OrderBy(X => X.Id).ToListAsync();
		}
	}


	public interface IDbPathProvider
	{
		string GetPath();
	}
}

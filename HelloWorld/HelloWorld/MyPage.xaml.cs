using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MyPage : Base.PageBase
	{
		// ProgressBar
		async void ProgressBar_Clicked(object sender, System.EventArgs e)
		{
			this.progressBar.Progress = 0.0;
			await this.progressBar.ProgressTo(1.0, 5000, Easing.Linear);
		}


		// Pickerアイテム
		private List<string> Items { get; } = Enumerable.Range(1, 5).Select(x => $"item{x}").ToList();
		void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.DisplayAlert("Info", $"{this.Items[this.picker.SelectedIndex]} selected", "OK");
		}

		void Nextpage_clicked(object sender, System.EventArgs e)
		{
			//var n = new NextPage();
		}

		public MyPage()
		{
			InitializeComponent();

			// DataTemplateSelector
			var r = new Random();
			this.listView.ItemsSource = Enumerable
				.Range(1, 100)
				.Select(X => new Person { Name = $"tanaka {X}", Age = 30 + r.Next(50) })
				.ToArray();

			// Pickerアイテム
			foreach (var item in Items)
			{
				this.picker.Items.Add(item);
			}


			// SearchBar
			this.searchBar.SearchCommand = new Command(_ =>
		   {
			   this.searchLabel.Text = $"{this.searchBar.Text} で検索いました.";
		   });
		}
	}
}

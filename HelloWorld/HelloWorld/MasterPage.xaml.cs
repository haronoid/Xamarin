using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MasterPage : MasterDetailPage
	{
		public MasterPage()
		{
			InitializeComponent();

			// NavigationPageのヘッダー部に表示するタイトルとメニュー制御
			this.Title = "MasteDetailPage Title";
			this.ToolbarItems.Add(new ToolbarItem()
			{
				Text = "Menu1"
			});
			this.ToolbarItems[0].Clicked += (sender, e) => { this.DisplayAlert("Title", "Menu1 Click", "Cancel"); };

			var menu = new MenuPage();
			menu.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

			this.Master = menu;
			this.Detail = new HelloWorldPage();

		}

		void NavigateTo(MenuItem menu)
		{
			//Detailページを切り替えます
			Page nextPage = (Page)Activator.CreateInstance(menu.TargetType);
			// PushAsyncはNavigationPageでのみ動作するため、一般Pageで呼ばれるとエラーいなる
			this.Detail.Navigation.PushAsync(nextPage);
			this.IsPresented = false;
		}

	}
}

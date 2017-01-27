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

			var menu = new MenuPage();
			menu.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

			this.Master = menu;
			this.Detail = new NextPage();

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

using System.Collections.Generic;
using Xamarin.Forms;

using System;

namespace HelloWorld
{
	public class MenuPage : ContentPage
	{
		public MenuListView Menu { get; set; }

		public MenuPage()
		{
			this.Title = "Menu";
			BackgroundColor = Color.FromHex("dce8ef");

			Menu = new MenuListView();

			var menuLabel = new ContentView
			{
				Padding = new Thickness(10, 36, 0, 5),
				Content = new Label
				{
					Text = "Menu",
					FontSize = 18
				}
			};
						Content = new StackLayout
			{
				Children = {
					menuLabel, Menu
				}
			};
		}
	}

	public class MenuListView : ListView
	{
		public MenuListView()
		{
			List<MenuItem> data = new List<MenuItem>();

			data.Add(new MenuItem() { Title = "Menu1",TargetType=typeof(MyPage) });
			data.Add(new MenuItem() { Title = "Menu2" , TargetType = typeof(MyPage2)});
			data.Add(new MenuItem() { Title = "Menu3", TargetType = typeof(NextPage) });
			data.Add(new MenuItem() { Title = "TappedPage", TargetType = typeof(TabbedPage) });

			ItemsSource = data;

			// AndroidではItemTemplateで使用しているImageCellのTextが水色になってしまいます。
			// ImageCellではなくViewCellでItemTemplateを作成すると回避できるようです。
			//var cell = new DataTemplate(typeof(ImageCell));
			//cell.SetBinding(TextCell.TextProperty, "Title");
			//cell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");

			//ItemTemplate = cell;
		}
	}

	public class MenuItem
	{
		//メニューに表示される題名をセットします。
		public string Title { get; set; }
		//アイコンファイルを指定します。
		//Androidは \アプリ名.Droid\Resources\drawableフォルダの画像ファイルを指定します。
		//iOSは \アプリ名.iOS\Resourcesフォルダの画像ファイルを指定します。
		public string IconSource { get; set; }
		// この Type で移動先のページクラスを指定しています。
		public Type TargetType { get; set; }

		public override string ToString()
		{
			return Title;
		}
	}

}


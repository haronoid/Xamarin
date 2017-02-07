using Xamarin.Forms;

namespace HelloWorld.Base
{
	public class PageBase : ContentPage
	{
		public PageBase()
		{
			// 各プラットフォーム毎の初期処理
			this.Padding = Device.OnPlatform(
				Android: new Thickness(),
				iOS: new Thickness(0, 20, 0, 0),
				WinPhone: new Thickness());

			// 今後バージョンアップからOnPlatformのやり方は廃止されるらしい。使えなくなったら
			// 以下のURLから使用方法援交を試みる
			// http://ticktack.hatenablog.jp/entry/2017/02/06/234012
		}
	}
}

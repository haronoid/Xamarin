using System;
using Xamarin.Forms;

namespace HelloWorld.Base
{
	public class MasterDetailPageBase : MasterDetailPage
	{
		public MasterDetailPageBase()
		{
			// 各プラットフォーム毎の初期処理
			this.Padding = Device.OnPlatform(
				Android: new Thickness(),
				iOS: new Thickness(0, 20, 0, 0),
				WinPhone: new Thickness());
		}
	}
}

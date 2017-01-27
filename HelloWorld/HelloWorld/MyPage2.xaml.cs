using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MyPage2 : Base.PageBase
	{
		async void NextPage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new NextPage());
		}

		/// <summary>
		/// WebViewの内容を変える
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			this.webView.Source = new HtmlWebViewSource
			{
				Html = @"
					<html>
						<body>
							<h1>Hello World</h1>
						</body>
					</html>"
			};
		}

		public MyPage2()
		{
			InitializeComponent();
		}

	}
}

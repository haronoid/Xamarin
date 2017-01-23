using System;
using Xamarin.Forms;
using HelloWorld.Base;
using System.Threading.Tasks;

namespace HelloWorld
{
	public partial class HelloWorldPage : Base.PageBase
	{
		/// <summary>
		/// ListViewのRefreshイベント処理
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
	 	async void Handle_Refreshing(object sender, System.EventArgs e)
		{
			await Task.Delay(3000);
			for (int i = 0; i < 5; i++)
			{
				
			}
			this.listvView1.IsRefreshing = false;
		}

		/// <summary>
		/// ボタンクリックイベント処理
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			this.label1.Text = DateTime.Now.ToString();
		}

		public HelloWorldPage()
		{
			InitializeComponent();
		}
	}
}

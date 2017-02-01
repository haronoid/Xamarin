using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class TopPage : ContentPage
	{

		async void btnHelloWorldPage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new HelloWorldPage());
		}

		async void btnMyPage1_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new MyPage());
		}

		async void btnMyPage2_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new MyPage2());
		}

		async void btnTapped_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new TappedPage());
		}

		async void btnMasterDetail_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new NavigationPage(new MasterPage()));
		}

		async void btnCarousePage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new CarouselPage1());
		}

		async void btnStylePage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new StylePage());
		}

		async void btnGesturePage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new GesturePage());
		}

		async void btnAnimationPage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new AnimationPage());
		}

		async void btnBeheaviorPage_Clicked(object sender, System.EventArgs e)
		{
			BeheaviorPage page = new BeheaviorPage();
			await this.Navigation.PushModalAsync(page);
			page = null;
		}


		public TopPage()
		{
			InitializeComponent();
		}
	}
}

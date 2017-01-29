using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class NextPage : ContentPage
	{
		async void OpenTappedPage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new TappedPage());
		}

		async void Close_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PopModalAsync();
		}

		async void OpenCarouselPage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new CarouselPage1());
		}

		public NextPage()
		{
			InitializeComponent();
		}
	}
}

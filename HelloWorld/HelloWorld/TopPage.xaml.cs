﻿using System;
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

		async void btnTriggerPage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new TriggerPage());
		}

		async void btnMessageCenter_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new MessageCenterPage());
		}

		async void btnDependencyService_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new DependencyServicePage());
		}

		async void btnEffectPage_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new EffectPage());
		}

		async void btnCustomRenderer_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new CustomRendererPage());
		}

		async void btnPropertiesStore_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new PropertiesStorePage());
		}

		async void btnSqlLiteStore_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new SqlLitePage());
		}

		public TopPage()
		{
			InitializeComponent();
		}
	}
}

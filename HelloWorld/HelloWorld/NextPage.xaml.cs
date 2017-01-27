using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class NextPage : ContentPage
	{
		async void Close_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PopModalAsync();
		}

		public NextPage()
		{
			InitializeComponent();
		}
	}
}

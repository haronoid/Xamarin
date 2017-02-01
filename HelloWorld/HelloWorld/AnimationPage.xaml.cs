
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class AnimationPage : ContentPage
	{
		async void btnAction_Clicked(object sender, System.EventArgs e)
		{
			await this.lblAni1.TranslateTo(150, 300, 5000, Easing.SpringIn);
			await Task.WhenAll<bool>(
				this.lblAni2.RotateTo(1000, 100000)
			);
		}

		public AnimationPage()
		{
			InitializeComponent();
		}
	}
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class StylePage : ContentPage
	{
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			this.Resources["dynamicLabelStyle"] = this.Resources["blueLabelStyle"];

		}

		public StylePage()
		{
			InitializeComponent();
		
			this.Resources["dynamicLabelStyle"] = this.Resources["redLabelStyle"];
		}
	}
}

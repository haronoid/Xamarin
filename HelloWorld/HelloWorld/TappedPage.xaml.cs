using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class TappedPage : TabbedPage
	{
		public TappedPage()
		{
			InitializeComponent();

		}

		private async void Handled_Clicked(object sender, EventArgs e)
		{
			await this.Navigation.PopModalAsync();
		}
	}
}

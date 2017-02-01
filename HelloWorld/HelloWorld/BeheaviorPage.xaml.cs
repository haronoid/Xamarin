using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class BeheaviorPage : Base.PageBase
	{
	 	async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PopModalAsync();
		}

		public BeheaviorPage()
		{
			InitializeComponent();
		}
	}
}

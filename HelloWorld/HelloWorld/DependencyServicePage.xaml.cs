using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class DependencyServicePage : ContentPage
	{
		public DependencyServicePage()
		{
			InitializeComponent();

			this.lblOsName.Text = DependencyService.Get<IMyDependecyProvider>().GetName();


		}
	}
}

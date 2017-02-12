using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class EffectPage : ContentPage
	{
		public EffectPage()
		{
			InitializeComponent();

			this.labelTimer.Text = DateTime.Now.ToString();
		}
	}
}

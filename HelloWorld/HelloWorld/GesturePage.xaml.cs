using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class GesturePage : ContentPage
	{

		private int TapCount { get; set; }

		public GesturePage()
		{
			InitializeComponent();
		}

		private void Handle_Tapped(object sender, EventArgs e)
		{
			((Label)sender).Text = $"Tap Count is {++this.TapCount}";
		}

		private void Handle_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
		{
			this.labelStatus.Text = $"{e.Status}: {e.Scale}: ({e.ScaleOrigin.X}, {e.ScaleOrigin.Y})";
		}

		private void Handle_PanUpdated(object sender, PanUpdatedEventArgs e)
		{
			this.labelStatus2.Text = $"{e.StatusType}: ({e.TotalX}, {e.TotalY})";
		}

	}
}

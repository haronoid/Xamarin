using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(HelloWorld.CustomButton), typeof(HelloWorld.iOS.CustomButtonRenderer))]
namespace HelloWorld.iOS
{
	public class CustomButtonRenderer : ViewRenderer<CustomButton, UIButton>
	{
		public CustomButtonRenderer()
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<CustomButton> e)
		{
			base.OnElementChanged(e);

			if (this.Control == null)
			{
				var button = new UIButton(UIButtonType.RoundedRect); button.TouchDown += this.OnTouchDown; this.SetNativeControl(button);
			}
			if (e.NewElement != null)
			{
				this.UpdateText();
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == CustomButton.TextProperty.PropertyName)
			{
				this.UpdateText();
			}
		}


		private void UpdateText()
		{
			this.Control.SetTitle(this.Element.Text + "is iOS", UIControlState.Normal);
		}

		private void OnTouchDown(object sender, EventArgs e)
		{
			this.Element.OnClicked();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Control.TouchDown -= this.OnTouchDown;
			}
			base.Dispose(disposing);
		}

	}
}

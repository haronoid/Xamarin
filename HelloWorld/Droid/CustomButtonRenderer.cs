using System;
using System.ComponentModel;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(HelloWorld.CustomButton), typeof(HelloWorld.Droid.CustomButtonRenderer))]
namespace HelloWorld.Droid
{
	
	public class CustomButtonRenderer : ViewRenderer<CustomButton, Button>
	{
		public CustomButtonRenderer()
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<CustomButton> e)
		{
			base.OnElementChanged(e);

			if (this.Control == null)
			{
				var button = new Button(this.Context); button.Click += this.OnClick; this.SetNativeControl(button);
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
			this.Control.Text = this.Element.Text + "is Droid";
		}

		private void OnClick(object sender, EventArgs e)
		{
			this.Element.OnClicked();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Control.Click -= this.OnClick;
			}
			base.Dispose(disposing);
		}

	}
}

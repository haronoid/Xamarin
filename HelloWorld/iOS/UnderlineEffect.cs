using System;
using System.Linq;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ResolutionGroupName("HelloWorld")]
[assembly:ExportEffect(typeof(HelloWorld.iOS.UnderlineEffect), "UnderlineEffect")]
namespace HelloWorld.iOS
{
	public class UnderlineEffect : PlatformEffect
	{
		public UnderlineEffect()
		{
		}

		protected override void OnAttached()
		{
			var label = this.Control as UILabel;
			if (label == null) { return; }

			var effect = this.Element.Effects.First(x => x is HelloWorld.UnderlineEffect) as HelloWorld.UnderlineEffect;

			if (effect.IsEnabled)
			{
				label.AttributedText = new Foundation.NSAttributedString(
					label.Text ?? "", underlineStyle: Foundation.NSUnderlineStyle.Single);
			}
		}

		protected override void OnDetached()
		{
		}

		protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
		{
			if (args.PropertyName == nameof(UILabel.Text))
			{
				var label = this.Control as UILabel;
				if (label == null) { return; }

				label.AttributedText = new Foundation.NSAttributedString(
					label.Text ?? "", underlineStyle: Foundation.NSUnderlineStyle.Single);
			}
		}

	}
}

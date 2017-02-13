using System;
using System.Linq;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ResolutionGroupName("HelloWorld")]
[assembly: ExportEffect(typeof(HelloWorld.Droid.UnderlineEffect), "UnderlineEffect")]
namespace HelloWorld.Droid
{
	public class UnderlineEffect : PlatformEffect
	{
		public UnderlineEffect()
		{
		}

		protected override void OnAttached()
		{
			var label = this.Control as TextView;
			if (label == null) { return; }

			var effect = this.Element.Effects.First(x => x is HelloWorld.UnderlineEffect) as HelloWorld.UnderlineEffect;
			if (effect.IsEnabled)
			{
				label.PaintFlags = label.PaintFlags | Android.Graphics.PaintFlags.UnderlineText;
			}
		}

		protected override void OnDetached()
		{
		}
	}
}

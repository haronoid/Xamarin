using System;
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

			label.PaintFlags = label.PaintFlags | Android.Graphics.PaintFlags.UnderlineText;
		}

		protected override void OnDetached()
		{
		}
	}
}

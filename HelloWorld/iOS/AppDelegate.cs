using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Mobile;

using Foundation;
using UIKit;

namespace HelloWorld.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			MobileCenter.Configure("c6ad845a-abf0-424c-9a3d-6832bba2d838");

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

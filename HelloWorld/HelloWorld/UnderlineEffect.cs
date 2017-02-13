using System;
using Xamarin.Forms;

namespace HelloWorld
{
	public class UnderlineEffect : RoutingEffect
	{

		public bool IsEnabled { get; set; }

		public UnderlineEffect() : base("HelloWorld.UnderlineEffect")
		{
		}
	}
}

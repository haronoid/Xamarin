using System;
using System.Diagnostics;

using Xamarin.Forms;


namespace HelloWorld
{
	public class MyBehavior : Behavior<Base.PageBase>
	{
		public MyBehavior()
		{
		}


		// ビヘイビアあコントロールい適用荒れたときに呼び出されるメソッド
		protected override void OnAttachedTo(Base.PageBase bindable)
		{
			base.OnAttachedTo(bindable);
			Debug.WriteLine("MyBehavior OnAttachedTo");
		}


		protected override void OnDetachingFrom(Base.PageBase bindable)
		{
			base.OnDetachingFrom(bindable);
			Debug.WriteLine("MyBehavior OnDetachingFrom");
		}
	}
}

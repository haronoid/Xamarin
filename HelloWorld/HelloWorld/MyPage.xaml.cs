using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MyPage : Base.PageBase
	{
		public MyPage()
		{
			InitializeComponent();

			var r = new Random();
			this.listView.ItemsSource = Enumerable
				.Range(1, 100)
				.Select(X => new Person { Name = $"tanaka {X}", Age = 30 + r.Next(50) })
				.ToArray();
		}
	}
}

using System;
using Xamarin.Forms;

namespace HelloWorld
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person()
		{
		}
	}

	public class PersonDataTempleateSelector : Xamarin.Forms.DataTemplateSelector
	{
			public Xamarin.Forms.DataTemplate SilverTemplate { get; set; }
			public Xamarin.Forms.DataTemplate NormalTemplate { get; set; }

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			return ((Person)item).Age >= 65 ? this.SilverTemplate : this.NormalTemplate;
		}
	}
}

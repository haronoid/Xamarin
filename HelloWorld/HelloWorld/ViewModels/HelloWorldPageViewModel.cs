using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloWorld
{
	public class HelloWorldPageViewModel : Base.ViewModelBase
	{
		void HandleFunc()
		{

		}

		public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

		public HelloWorldPageViewModel()
		{
			var r = new Random();
			Device.StartTimer(
				TimeSpan.FromSeconds(5),
				() =>
				{
					this.People.Add(new Person { Name = $"tanaka {r.Next()}" });
					return true;
				});
		}
	}
}

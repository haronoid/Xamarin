using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloWorld
{
	public class HelloWorldPageViewModel : Base.ViewModelBase
	{

		public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

		public ObservableCollection<Family> Family { get; set;}

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

			// xにCommandParameterを代入、日付のフォーマットにして使える。
			this.NowCommand = new Command(x => this.Message = DateTime.Now.ToString((string)x),
			                              _ => this.canExecute);
			this.message = "Command Event Test";

			this.Family = new ObservableCollection<Family>
			{
				new Family("tanaka family", "t")
				{
					new Person(){Name = "tanaka taro"},
					new Person(){Name = "tanaka jiro"},
					new Person(){Name = "tamala saburo"}
				},
				new Family("kimura family","k")
				{
					new Person() { Name = "kimura taro"},
					new Person() { Name = "kimura jiro"}
				}
			};
		}

		private string message;

		public string Message
		{
			get { return this.message; }
			set { this.SetProperty(ref this.message, value); }
		}

		public Command NowCommand { get; }

		private bool canExecute;

		public bool CanExecute
		{
			get { return this.canExecute; }
			set { this.SetProperty(ref this.canExecute, value); this.NowCommand.ChangeCanExecute(); }
		}
	}
}

using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HelloWorld
{
	public class HelloWorldPageViewModel : Base.ViewModelBase
	{

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

			this.NowCommand = new Command(_ => this.Message = DateTime.Now.ToString(),
			                              _ => this.canExecute);
			this.message = "Command Event Test";
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

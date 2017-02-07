using System;
using System.Diagnostics;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MessageCenterPage : ContentPage
	{
	 	async void Close_Clicked(object sender, System.EventArgs e)
		{
			MessagingCenter.Unsubscribe<MessageChildPage, DateTime>(this,"completed");
			MessagingCenter.Unsubscribe<MessageChildPage, String>(this, "completed2");

			await this.Navigation.PopModalAsync();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushModalAsync(new MessageChildPage());
		}

		public MessageCenterPage()
		{
			InitializeComponent();

			MessagingCenter.Subscribe<MessageChildPage, DateTime>(
				this,
				"completed", (arg1, arg2) =>
				{
					this.lblStatus.Text = $"Cpmpeted at {arg2}";
					Debug.WriteLine("completed message received");
				});

			MessagingCenter.Subscribe<MessageChildPage, String>(
				this,
				"completed2", (arg1, arg2) =>
				{
					this.lblStatus.Text = $"Cpmpeted at {arg2}";
					Debug.WriteLine("completed2 message received");
				});
		}
	}


	public class MessageChildPage : Base.PageBase
	{
		public MessageChildPage()
		{

			Button b = new Button { Text = "Complete" };
			b.Clicked += Handle_Clicked;

			Button b2 = new Button { Text = "Complete2" };
			b2.Clicked += Handle2_Clicked;

			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" },
					b,
					b2
				}
			};

		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			MessagingCenter.Send<MessageChildPage, DateTime>(
				this,
				"completed",
				DateTime.Now);

			await this.Navigation.PopModalAsync();
		}

		async void Handle2_Clicked(object sender, System.EventArgs e)
		{
			MessagingCenter.Send<MessageChildPage, String>(
				this,
				"completed2",
				"comp2");

			await this.Navigation.PopModalAsync();
		}
	}


}

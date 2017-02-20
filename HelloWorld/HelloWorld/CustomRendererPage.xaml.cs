
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class CustomRendererPage : ContentPage
	{
		public CustomRendererPage()
		{
			InitializeComponent();
		}


		private void Handle_Clicked(object sender, EventArgs e)
		{
			this.label.Text = DateTime.Now.ToString();
		}
	}


	public class CustomButton : View
	{

		public static readonly BindableProperty TextProperty = BindableProperty.Create(
			"Text",
			typeof(String),
			typeof(CustomButton)
		);

		public String Text
		{
			get { return (String)this.GetValue(TextProperty); } 
			set { this.SetValue(TextProperty, value); }
		}

		public event EventHandler Clicked;

		internal void OnClicked()
		{
			this.Clicked?.Invoke(this, EventArgs.Empty);
		}
	}
}

using System;
using Xamarin.Forms;
using HelloWorld.Base;

namespace HelloWorld
{
	public partial class HelloWorldPage : Base.PageBase
	{
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			this.label1.Text = DateTime.Now.ToString();
		}

		public HelloWorldPage()
		{
			InitializeComponent();
		}
	}
}

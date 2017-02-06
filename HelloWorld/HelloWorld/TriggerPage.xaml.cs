using System;
using System.Diagnostics;
using System.Globalization;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class TriggerPage : ContentPage
	{
		public TriggerPage()
		{
			InitializeComponent();
		}
	}

	public class MyTriggerAction : TriggerAction<Button>
	{
		protected override void Invoke(Button sender)
		{
			Debug.WriteLine("Trigger Invoke");
		}
	}

	public class IsGreaterZeroConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return ((int)value) > 0;
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}

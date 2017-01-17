using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloWorld.Base
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public ViewModelBase()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (object.Equals(field, value)) { return false; }
			field = value; this.OnPropertyChanged(propertyName); return true;
		}
	}
}

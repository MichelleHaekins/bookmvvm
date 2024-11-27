using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BOOKS.Framework
{
	public class Bindables : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;
		protected void Notify(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		}
		protected void Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
		{
			field = value;
			Notify(propertyName);
		}
	}
}

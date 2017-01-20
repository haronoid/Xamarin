
using System;
using System.Collections.ObjectModel;

namespace HelloWorld
{
	public class Family : ObservableCollection<Person>
	{
		public string GroupName { get; set; }
		public string GroupShortName { get; set; }

		public Family(string groupName, string groupShortName)
		{
			this.GroupName = groupName;
			this.GroupShortName = groupShortName;
		}
	}
}

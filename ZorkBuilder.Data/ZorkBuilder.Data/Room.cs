using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZorkBuilder.Data
{
	public class Room : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string Name { get; set; }

		public string LookName { get; set; }

		public string Description { get; set; }

		public List<String> Neighbors { get; set; }
	}
}

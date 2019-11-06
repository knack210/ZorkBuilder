using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZorkBuilder.Data 
{
	public class World : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

        public string StartingLocation;

        public List<Room> Rooms { get; set; }

		

		public World()
		{
            StartingLocation = "DefaultLocation";
			Rooms = new List<Room>();
		}			
	}
}

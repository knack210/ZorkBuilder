using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Text;

namespace ZorkBuilder.Data
{
	public class Room : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string Name { get; set; }

		public string LookName { get; set; }

		public string Description { get; set; }
        
		public Dictionary<NeighborLocations, string> Neighbors { get; set; }

		public string North { get; set; }
		public string West { get; set; }
		public string South { get; set; }		
		public string East { get; set; }



		public Room()
        {
            Name = "Default Room";
            Description = "This is a room.";
            Neighbors = new Dictionary<NeighborLocations, string>();
        }

        public override string ToString() => Name;
	}
}

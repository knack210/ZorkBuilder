using System;
using ZorkBuilder.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using System.IO;

namespace ZorkBuilder.ViewModels
{
	public class WorldViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public string Filename { get; set; }
		public string WelcomeMessage { get; set; }
		public string StartingLocation { get; set; }
		
		public BindingList<Room> Rooms { get; set; }         

		public World World
		{
			set
			{
				if (mWorld != value)
				{
					mWorld = value;

					foreach (Room room in mWorld.Rooms)
					{
						if (room.Neighbors.ContainsKey(NeighborLocations.North)) room.North = room.Neighbors[NeighborLocations.North];

						if (room.Neighbors.ContainsKey(NeighborLocations.South)) room.South = room.Neighbors[NeighborLocations.South];

						if (room.Neighbors.ContainsKey(NeighborLocations.East)) room.East = room.Neighbors[NeighborLocations.East];

						if (room.Neighbors.ContainsKey(NeighborLocations.West)) room.West = room.Neighbors[NeighborLocations.West];
					}

					if (mWorld.WelcomeMessage != null) { WelcomeMessage = mWorld.WelcomeMessage; }
					if (mWorld.StartingLocation != null) { StartingLocation = mWorld.StartingLocation; }
					Rooms = new BindingList<Room>(mWorld.Rooms);
					
					
				}

				else
				{					
					Rooms = new BindingList<Room>(Array.Empty<Room>());					
				}
			}
		}

		public WorldViewModel(World world = null)
		{
			World = world;
		}
		
		public void SaveWorld()
		{
			if (string.IsNullOrEmpty(Filename))
			{
				throw new InvalidProgramException("Filename expected.");
			}

			mWorld.StartingLocation = StartingLocation;
			mWorld.WelcomeMessage = WelcomeMessage;

			foreach (Room room in mWorld.Rooms)
			{
				room.Neighbors[NeighborLocations.North] = room.North;
				room.Neighbors[NeighborLocations.South] = room.South;
				room.Neighbors[NeighborLocations.East] = room.East;
				room.Neighbors[NeighborLocations.West] = room.West;
			}

			JsonSerializer serializer = new JsonSerializer
			{
				Formatting = Formatting.Indented
			};
			using (StreamWriter streamWriter = new StreamWriter(Filename))
			using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
			{
				serializer.Serialize(jsonWriter, mWorld);
			}
		}

		private string IsRoomNull(string nullCheck)
		{
			if (nullCheck == null)
				return null;

			return nullCheck;
		}

		private World mWorld;
	}
}

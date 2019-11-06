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

		public BindingList<Room> Rooms { get; set; }         

		public World World
		{
			set
			{
				if (mWorld != value)
				{
					mWorld = value;					
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

		private World mWorld;
	}
}

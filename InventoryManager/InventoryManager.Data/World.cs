using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace InventoryManager.Data
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Player> Players { get; set; }

        public List<Item> Items { get; set; }

        public World()
        {
            Players = new List<Player>();
            Items = new List<Item>();
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            foreach (Player player in Players)
            {
                player.BuildInventoryFromName(Items);
            }
        }
    }
}

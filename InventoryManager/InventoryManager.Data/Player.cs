using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManager.Data
{
    public class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }

        public string Health { get; set; }

        public int Score { get; set; }

        [JsonProperty(PropertyName = "Inventory")]
        private List<string> InventoryNames { get; set; }
        
        [JsonIgnore]
        public List<Item> Inventory { get; set; }

        public Player()
        {
            Inventory = new List<Item>();
        }

        public override string ToString() => Name;
    }
}

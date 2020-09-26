using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UVASurplus.Models
{
    public class Item
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public int? AssetTag { get; set; }
        public string? ItemType { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public string? Condition { get; set; }
        public string? Comments { get; set; }
        public string? Serial { get; set; }
        public string? EquipmentType { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UVASurplus.Models.ViewModels
{
    public class RequestIndexData
    {

        public IEnumerable<Request> Requests { get; set; }
        public IEnumerable<Item> Items { get; set; }

    }
}

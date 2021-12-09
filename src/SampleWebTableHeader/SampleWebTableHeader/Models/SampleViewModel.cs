using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebTableHeader.Models
{
    public class SampleViewModel
    {
        public List<ListItem> Items
        {
            get;
        } = new List<ListItem>();

        public class ListItem
        {
            public DateTime Date
            {
                get;
                set;
            }
        }
    }
}

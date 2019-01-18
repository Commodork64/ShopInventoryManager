using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopInventoryManager
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }

        // tostring is a base method that every object has, by default this will return
        // the object namespace / name unless a base class has overridden it
        // stuff like the grid will use tostring to display information
        // so if we override it to return what we want, we get a nice looking tostring
        public override string ToString()
        {
            return LocationName;
        }
    }
}

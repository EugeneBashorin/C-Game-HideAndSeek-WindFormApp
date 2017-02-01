using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBilding
{
    class Room : Location
    {
        private string decoration{get;set;}
        public Room(string name, string decoration):base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + "Здесь вы видите" + decoration + ".";
            }
        }
    }
}

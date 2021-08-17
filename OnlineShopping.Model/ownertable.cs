using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model
{
   public class ownertable
    {
        public int ownerid { get; set; }
        public string ownername { get; set; }
        public string ownerphone { get; set; }
        public string ownerunit { get; set; }
        public string owneraddress { get; set; }
        public DateTime ownervalid { get; set; }
        public string ownerremark { get; set; }
        public string ownerimg { get; set; }
        public DateTime ownerdate { get; set; }
        public int ownersale { get; set; }
        public int owneruid { get; set; }

        public int MyProperty { get; set; }
    }
}

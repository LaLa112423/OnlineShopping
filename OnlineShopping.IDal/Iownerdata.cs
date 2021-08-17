using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Model;
namespace OnlineShopping.IDal
{
  public interface Iownerdata
    {
        List<ownertable> ownershow(int id);
        int owneradd(ownertable u);
        int ownerdel(int id);
        List<ownertable> owneralt(int id);
        int ownerupt(ownertable u);
    }
}

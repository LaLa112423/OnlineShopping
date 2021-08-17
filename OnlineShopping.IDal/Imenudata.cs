using OnlineShopping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.IDal
{
    public interface Imenudata
    {
        List<menutable> menushow(int id);
        List<menutable> menuindex(int id, int iid);
    }
}

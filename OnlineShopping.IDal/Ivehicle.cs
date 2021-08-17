using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Model;
namespace OnlineShopping.IDal
{
    public interface Ivehicle
    {
        List<vehicletable> vehicleshow(int id);
        int vehicleadd(vehicletable u);
        List<vehicletable> vehiclealt(int id);
        int vehicleupt(vehicletable u);
        int vehicledel(int id);
    }
}

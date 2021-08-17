using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.IDal
{
   public interface Itest
    {
        //简单工厂
        string drink(string str);
        //抽象工厂
        //蔬菜
        void vegetable();
        //水果
        void fruits();
        //建造者模式
        //饺子皮
        public string pi();
        //饺子馅
        public string xian();
    }
}

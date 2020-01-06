using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Interfaces
{
    interface ISellerController
    {
        bool Add(string id, string name, int price, int startValue);
        bool Clear(string id, string name, int price, int startValue);
    }
}

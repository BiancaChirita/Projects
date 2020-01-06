using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Controllers
{
    class SellerController : ISellerController
    {
        public bool Add(string ID, string name, int price, int startValue)
        {
            bool validate = Validate(ID, name, price, startValue);
            if (validate == true)
            {
                string messageTrue = "Object added successfully";
                System.Windows.Forms.MessageBox.Show(messageTrue);
                return true;
            }
            else
            {
                string messageFalse = "Addition Failed";
                System.Windows.Forms.MessageBox.Show(messageFalse);
                return false;
            }
        }

        private bool Validate(string ID, string name, int price, int startValue)
        {
            if(ID == "" || name == "" || price == null || startValue == null)
            {
                return false;
            }
            if(price.GetType() != typeof(int) || startValue.GetType() != typeof(int))
            {
                return false;
            }
            return true;
        }

        public bool Clear(string ID, string name, int price, int startValue)
        {
            if (ID != "" || name != "" || price != null || startValue != null)
            {
                return true;
            }
            return false;
        }
    }
}

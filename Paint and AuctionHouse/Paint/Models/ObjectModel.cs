using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Models
{
    class ObjectModel
    {
        #region PRIVATE FIELDS

        private int _id;
        private string _name;
        private int _price;
        private int _startValue;

        #endregion

        public ObjectModel()
        {

        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int StartValue
        {
            get { return _startValue; }
            set { _startValue = value; }
        }
    }
}

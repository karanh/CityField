using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class Store : Commercial
    {
        //Creates a Store
        public Store()
        {
            _cost = 300000000;
            //Assigns image for a Store class's button
            image = Properties.Resources.store;
            _economy = 2;
            _tax = 5000000;
        }
    }
}

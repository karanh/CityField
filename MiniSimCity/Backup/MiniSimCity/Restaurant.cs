using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class Restaurant : Commercial
    {
        //Creates a Restaurant()
        public Restaurant()
        {
            _cost = 1000000;
            //Assigns image for a Restaurant class's button
            image = Properties.Resources.restaurant;
            _economy = 0.1;
            _tax = 10000;
        }
    }
}

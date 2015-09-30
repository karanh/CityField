using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class Factory : Industrial
    {
        //Creates a Factory()
        public Factory()
        {
            _cost = 10000000;
            //Assigns image for a Factory class's button
            image = Properties.Resources.industrial;
            _economy = 0.1;
            _tax = 100000;
        }
    }
}

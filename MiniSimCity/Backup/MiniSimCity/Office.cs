using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class Office : Industrial
    {
        //Creates a Office
        public Office()
        {
            _cost = 20000000;
            //Assigns image for a Office class's button
            image = Properties.Resources.office;
            _economy = 1;
            _tax = 200000;
        }
    }
}

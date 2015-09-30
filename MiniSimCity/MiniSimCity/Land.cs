using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MiniSimCity
{
    abstract class Land
    {
        public Image image;
        //Creates a Land
        public Land ()
        {

        }
        //Stores the Land's initial cost to build the building
        protected int _cost;
        //Gets the cost of the land building. Land's subclasss can change the cost value
        public int Cost
        {
            get
            {
                return _cost;
            }
            protected set
            {
                _cost = value;
            }
        }
        //Stores the Land's economy
        protected double _economy;
        //Gets the economy of the land building. Land's subclasss can change the economy value
        public double Economy
        {
            get
            {
                return _economy;
            }
            set
            {
                _economy = value;
            }

        }
        //Stores the Land's tax
        protected int _tax;
        //Gets the tax of the land building. Land's subclasss can change the tax value
        public int Tax
        {
            get
            {
                return _tax;
            }
            set
            {
                _tax = value;
            }
        }


    }
}

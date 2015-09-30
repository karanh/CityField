using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class Emergency_Services : Essential_Service
    {
        //Creates and Emergency Service
        public Emergency_Services()
        {
            _cost = 40000000;
            //Assigns image for an Emergency Services' class's button
            image = Properties.Resources.essential_services;
            _tax = -1000000;
            _economy = GetEconomy();
            
        }
        //Gets the economy of an emergency service building
        public override double GetEconomy()
        {
            //Calculates the economy of an emergency service building
            Economy = virtualPopulation * 0.1;
            return Economy;           

        }
        //Updates the economy of an emergency service building
        public override void UpdateEconomy(double actualPopulation, double maxPopulation)
        {
            base.UpdateEconomy(actualPopulation, maxPopulation);
            GetEconomy();
        }

    }
}

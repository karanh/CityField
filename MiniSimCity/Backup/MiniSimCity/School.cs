using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class School : Essential_Service
    {
        //Creates a School
        public School()
        {
            _cost = 50000000;
            //Assigns image for a School class's button
            image = Properties.Resources.school;
            _tax = -2000000;
            _economy = GetEconomy();
        }
        //Gets the economy of a school building
        public override double GetEconomy()
        {
            //Calculates the economy of a school building
            Economy = virtualPopulation * 0.2;
            return Economy;

        }
        //Updates the economy of a school building
        public override void UpdateEconomy(double actualPopulation, double maxPopulation)
        {
            base.UpdateEconomy(actualPopulation, maxPopulation);
            GetEconomy();
        }
    }
}

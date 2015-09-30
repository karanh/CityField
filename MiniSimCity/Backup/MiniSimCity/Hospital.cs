using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class Hospital : Essential_Service
    {
        //Creates a Hospital
        public Hospital()
        {
            _cost = 500000000;
            //Assigns image for a Hospital class's button
            image = Properties.Resources.hospital5;
            _tax = -30000000;
            _economy = GetEconomy();
        }
        //Gets the economy of a hospital building
        public override double GetEconomy()
        {
            //Calculates the economy of the hospital
            Economy = virtualPopulation * 0.5;
            return Economy;

        }
        //Updates the economy of the hosptital
        public override void UpdateEconomy(double actualPopulation, double maxPopulation)
        {
            base.UpdateEconomy(actualPopulation, maxPopulation);
            GetEconomy();
        }
    }
}

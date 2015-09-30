using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    abstract class Essential_Service : Land
    {
        //Creates an Essential Service
        public Essential_Service()
        {
        }
        //Stores the population of the city
        protected double virtualPopulation;
        //Gets the economy of an essential service building
        public abstract double GetEconomy();
        //Updates the ecoomy of an essential service building
        public virtual void UpdateEconomy(double actualPopulation, double maxPopulation)
        {
            //There city does not have a popuation
            if (maxPopulation == 0)
            {
                //Set the population to equal to avoid 0/0 ind case
                virtualPopulation = 1;
            }
            else
            {
                //Calculates the population function for Essential Service buildings
                virtualPopulation = (actualPopulation / maxPopulation);
            }
        }

    }
}

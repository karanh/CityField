using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    abstract class Residential : Land
    {
        //Creates a Residential
        public Residential()
        {
        }
        //Stores the population of Residential buildings
        protected int _population;
        //Gets the population of the residential buildings. Only Residential and its subclasses can change population
        public int Population
        {
            get
            {
                return _population;
            }
            set
            {
                _population = value;
            }
        }
        //Each subclass will have it's own version of GetPopulation that gets the population
        public abstract int GetPopulation();
        //Stores the time since the residential building was created
        protected int time = 0;
        //Stores the number of commercial and residential buildings in the city relative to the residential building
        protected int numCommercialAndIndustrial = 0;
        //Assigns a new population for the city
        public virtual void UpdateCityPopulation()
        {
            //Counts the time thats passed since creation of the residential building
            time++;
        }
        //Assigns a new economy for the residential buildings
        public virtual void UpdateEconomy(int commercialCount, int industrialCount)
        {
            //Adds the total Commercial and Industrial buildings within proximity to the residential building
            numCommercialAndIndustrial = commercialCount + industrialCount;
        }
        //Returns the economy of the Residential builings
        public abstract double GetEconomy();

    }
    
}

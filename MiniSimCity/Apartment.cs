using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class Apartment : Residential
    {
        //Sets the max populuation for a house
        private int MAX_POPULATION = 2000;
        //Gets the maximum populaiton of a apparment. Only Appartment can change this value
        public int MaxPopulation
        {
            get
            {
                return MAX_POPULATION;
            }

        }
        //Sets the max economy for an appartment
        private const int MAX_ECONOMY = 1;
        //Creates an Appartment()
        public Apartment()
        {
            _cost = 20000000;
            _population = GetPopulation();
            _economy = GetEconomy();
            //Assigns image for an Appartment class's button
            image = Properties.Resources.apartment;
            _tax = 200000;
        }
        //Updates the population for an Appartment
        public override void UpdateCityPopulation()
        {
            base.UpdateCityPopulation();
            GetPopulation();
        }
        //Gets the population of the Appartment building
        public override int GetPopulation()
        {
            //Populatin cannot exceed the maximum population of the appartment
            if (Population > MAX_POPULATION)
            {
                _population = MAX_POPULATION;
            }
            else
            {
                //Calculates the Appartment building's population
                Population = (int)(time / 12.0 * MAX_POPULATION);
            }
            return Population;
        }
        //Updates the economy of the Appartment building 
        public override void UpdateEconomy(int commercialCount, int industrialCount)
        {

            base.UpdateEconomy(commercialCount, industrialCount);
            GetEconomy();
        } 
        //Gets the Economy of the Appartment building
        public override double GetEconomy()
        {

            if (Economy > MAX_ECONOMY)
            {
                _economy = MAX_ECONOMY;
            }
            else
            {
                //Calculates the Appartment building's economy
                Economy = (int)(Population / 2000.0) * (numCommercialAndIndustrial / 5.0);
            }
            return Economy;
        }

    }
}

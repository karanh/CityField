using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class House : Residential
    {
        //Sets the max populuation for a house
        private int MAX_POPULATION = 4000;
        //Gets the maximum populaiton of a house. Only House can change this value
        public int MaxPopulation
        {
            get
            {
                return MAX_POPULATION;
            }
        }
        //Sets the max economy for a house
        private const int MAX_ECONOMY = 3;
        //Creates a House()
        public House()
        {
            _cost = 300000000;
            _population = GetPopulation();
            _economy = GetEconomy();
            _tax = 2000000;
            //Assigns image for a House class's button
            image = Properties.Resources.house5;           
        
        }
        //Updates the population for a House
        public override void UpdateCityPopulation()
        {
            base.UpdateCityPopulation();
            GetPopulation();
         
        }
        //Gets the population of the House building
        public override int GetPopulation()
        {
            //Populatin cannot exceed the maximum population of the house
            if (Population > MAX_POPULATION)
            {
                _population = MAX_POPULATION;
            }
            else
            {
                //Calculates the House's population
                Population = (int)(time / 12.0 * 4000);
            }
            return Population;
        }
        //Updates the economy of the House building 
        public override void UpdateEconomy(int commercialCount, int industrialCount)
        {
            base.UpdateEconomy(commercialCount, industrialCount);
            GetEconomy();
        }
        //Gets the economy of the House building
        public override double GetEconomy()
        {
            //Economy cannot exceed the maximum economy of the house
            if (Economy > MAX_ECONOMY)
            {
                _economy = MAX_ECONOMY;
            }
            else
            {
                //Calculates the House's economy
                Economy = (Population / 4000.0) * (numCommercialAndIndustrial / 2.0);
            }
            return Economy;
        }
            

    }
}

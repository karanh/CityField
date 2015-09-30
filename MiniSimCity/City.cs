using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniSimCity
{
    class City
    {
        //Assigns city's statup money
        private const double STARTUP_MONEY = 1000000000;
        //Assigns city's max economy
        private const int MAX_ECONOMY = 100;
        //Counts the number of commercial buildings in the city
        private int _commercialCount = 0;
        //Counts the number of industrial buildings in the city
        private int _industrialCount = 0;
        //Adds up the maximum population in the city depending on how many residential buildings are created
        private double _maxPopulation = 0;
        //Creates a city
        public City()
        {      
        }
        //Updates the city
        public void UpdateCity()
        {
            //Updates all residential buildings created
            UpdateResidentialLand();
            //Updates all land buildings created other than residential buildings
            UpdateCityLand();          
        }
        //Updates all residential buildings created
        public void UpdateResidentialLand()
        {
            //Resets the population back to 0 so that population is only taken from residential's population
            Population = 0;
            //Starts a new count of commercial buildings
            _commercialCount = 0;
            //Starts a new count of industrial buildings
            _industrialCount = 0;
            //Loops through the 2D land array to see if a coordinate set is a Residential land type
            for (int XCoord = 0; XCoord < 10; XCoord++)
            {
                for (int YCoord = 0; YCoord < 10; YCoord++)
                {
                    //Coordinate set is a residential 
                    if (_land[XCoord, YCoord] != null && _land[XCoord, YCoord] is Residential)
                    {
                        
                        //Counts the numer of commercial and industrial buildings within a certain proximity to the residential building
                        CheckResidential(XCoord, YCoord);
                        //Casts the specific grid point from a Land to a Residential instance
                        Residential residential = (Residential)_land[XCoord, YCoord];
                        //Updates the population in the residential class and subclasses
                        residential.UpdateCityPopulation();
                        //Adds the Residential's population to city's total popuation
                        Population += residential.GetPopulation();
                        //Updates the economy in the Residential class and subclasses
                        residential.UpdateEconomy(_commercialCount, _industrialCount);
                        //Adds the Residential's economy to the city's total Economy
                        Economy += residential.GetEconomy();
                        //Adds the Residential's tax to the city's total money
                        Money += residential.Tax;
                    }
                }
            }

        }
        //Updates all buildings created other than residential buildings
        public void UpdateCityLand()
        {
            //Loops through the 2D land array to see if a coordinate set is a Essential Service type
            for (int XCoord = 0; XCoord < 10; XCoord++)
            {
                for (int YCoord = 0; YCoord < 10; YCoord++)
                {
                    //Coordinate set is a Essential Service
                    if (_land[XCoord, YCoord] != null && _land[XCoord, YCoord] is Essential_Service)
                    {
                        //Casts the specific grid point form a Land to a Essential Service instance
                        Essential_Service essentialServices = (Essential_Service)_land[XCoord, YCoord];
                        //Updates the economy in the essential service class and subclasses
                        essentialServices.UpdateEconomy(_population, _maxPopulation);
                        //Adds the Essential Service's economy to the city's total economy
                        Economy += essentialServices.GetEconomy();
                        //Adds the Essential Services tax to the city's total money
                        Money += essentialServices.Tax;
                    }
                    //Coordinate set is a Industrial
                    else if (_land[XCoord, YCoord] != null && _land[XCoord, YCoord] is Industrial)
                    {
                        //Casts the specific grid point from a Land to a Industrial instace
                        Industrial industrial = (Industrial)_land[XCoord, YCoord];
                        //Adds the Industrial tax to the city's total money
                        Money += industrial.Tax;
                    }
                    //Coordinate set is a Commercial
                    else if (_land[XCoord, YCoord] != null && _land[XCoord, YCoord] is Commercial)
                    {
                        //Cats the specific grid point from a Land to a Commercial instance
                        Commercial commercial = (Commercial)_land[XCoord, YCoord];
                        //Adds the Commercial tax to the city's total money
                        Money += commercial.Tax;
                    } 
                }
            }
        }
        //Calcuates the user's total score
        public void GetScore()
        {
            _score = Population * (Economy / 100.0); 
        }
        //Creates a House in the 2D land array
        public void BuildHouse(int X, int Y)
        {
            House newHouse = new House();
            _land[X,Y] = newHouse;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X,Y].Cost;
            //Adds to the city's maximum possible population with given residential buildings created
            _maxPopulation += newHouse.MaxPopulation;

   
        }
        //Creates a Appartment in the 2D land array
        public void BuildApartment(int X, int Y)
        {
            Apartment newAppartment = new Apartment();
            _land[X, Y] = newAppartment;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;
            //Adds to the city's maximum possible population with given residential buildings created
            _maxPopulation += newAppartment.MaxPopulation;
 
        }
        //Creates an Emergency Service i the 2D land array
        public void BuildEmergencyService(int X, int Y)
        {
            Emergency_Services emergencyService = new Emergency_Services();
            _land[X, Y] = emergencyService;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;

        }
        //Creates a School in the 2D land array
        public void BuildSchool(int X, int Y)
        {
            School newSchool = new School();
            _land[X, Y] = newSchool;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;

        }
        //Creates a Hospital in the 2D land array
        public void BuildHospital(int X, int Y)
        {
            Hospital newHospital = new Hospital();
            _land[X, Y] = newHospital;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;
        }
        //Creates a Factory in the 2D land array
        public void BuildFactory(int X, int Y)
        {
            Factory newFactory = new Factory();
            _land[X, Y] = newFactory;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;
            //Decreases the city's total economy by the economy of the land type
            Economy += _land[X, Y].Economy;
        }
        //Creates a Office in the 2D land array
        public void BuildOffice(int X, int Y)
        {
            Office newOffice = new Office();
            _land[X, Y] = newOffice;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;
            //Decreases the city's total economy by the economy of the land type
            Economy += _land[X, Y].Economy;
        }
        //Creates a Store in the 2D land array
        public void BuildStore(int X, int Y)
        {
            Store newStore = new Store();
            _land[X, Y] = newStore;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;
            //Decreases the city's total economy by the economy of the land type
            Economy += _land[X, Y].Economy;
        }
        //Creats a Restaurant in the 2D land array
        public void BuildRestaurant(int X, int Y)
        {
            Restaurant newRestaurant = new Restaurant();
            _land[X, Y] = newRestaurant;
            //Decreases the city's total money by the cost of the land type
            Money -= _land[X, Y].Cost;
            //Decreases the city's total economy by the economy of the land type
            Economy += _land[X, Y].Economy;
        }
        //Creates a 2D Land array
        private Land[,] _land = new Land[10,10];
        //Gets the 2D land array
        public Land[,] Land
        {
            get
            {
                return _land;
            }
        }
        //Assigns the startup money for the city
        private double _money = STARTUP_MONEY;
        //Gets the city's total money. Only City can change the value
        public double Money
        {
            get
            {
                return _money;
            }
            set
            {

                _money = value;

            }
        }
        //Assigs the city's population
        private double _population = 0;
        //Gets the city's total population. Only City can change the value
        public double Population
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
        //Assigns the city's economy
        private double _economy = 0;
        //Gets the city's total economy value. Only City can change the value
        public double Economy
        {
            get
            {
                return _economy;
            }
            set
            {
                //Economy cannot exceed the city's maximum economy
                if (value > MAX_ECONOMY)
                {
                    _economy = MAX_ECONOMY;
                }
                else if (value < 0)
                {
                    _economy = 0;
                }
                else
                {
                    _economy = value;
                }
            }
        }
        //Checks if a Residential building can be made
        //Takes in coordinates of the residential building and compares it to the hospital, schools, and emergency services within proxmity
        //Returns true if the Residential is within proximity and false otherwise
        public bool CheckResidential(int XCoord, int YCoord)
        {
            //Stores the distance between buildings
            int distance = 0;
            //Checks if within Essential Service buildings
            bool withinSchool = false;
            bool withinEmergencyService = false;
            bool withinHospital = false;
            //Loops through 2D land array to find Essetial Service buildings
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    //land element is a Hospital
                    if (_land[X, Y] is Hospital)
                    {
                        //Calculates distance between buildings
                        distance = (int)Math.Sqrt(Math.Pow(X - XCoord, 2) + Math.Pow(Y - YCoord, 2));
                        //The residential building and hospital are within 10 grid points of each other
                        if (distance <= Math.Sqrt(200))
                        {
                            withinHospital = true;
                        }
                    }
                    //land element is a School
                    else if (_land[X, Y] is School)
                    {
                        //Calculates distance between buildings
                        distance = (int)Math.Sqrt(Math.Pow(X - XCoord, 2) + Math.Pow(Y - YCoord, 2));
                        //The residential building and school are within 4 grid points of each other
                        if (distance <= Math.Sqrt(32))
                        {
                            withinSchool = true;
                        }
                    }
                    //land element is a Emergency Serice
                    else if (_land[X, Y] is Emergency_Services)
                    {
                        //Calculates distance between buildings
                        distance = (int)Math.Sqrt(Math.Pow(X - XCoord, 2) + Math.Pow(Y - YCoord, 2));
                        //The residential building and emergeny service are within 4 grid points of each other
                        if (distance <= Math.Sqrt(32))
                        {
                            withinEmergencyService = true;
                        }
                    }
                    //land element is a Commercial
                    else if (_land[X, Y] is Commercial)
                    {
                        //Calculates distance between buildings
                        distance = (int)Math.Sqrt(Math.Pow(X - XCoord, 2) + Math.Pow(Y - YCoord, 2));
                        //The residential building and emergeny service are within 4 grid points of each other
                        if (distance <= Math.Sqrt(32))
                        {
                            //Adds one to the number of commercial buildings relative to the residential building
                            _commercialCount++;
                        }
                    }
                    //land element is a Industrial
                    else if (_land[X, Y] is Industrial)
                    {
                        //Calculates distance between buildings
                        distance = (int)Math.Sqrt(Math.Pow(X - XCoord, 2) + Math.Pow(Y - YCoord, 2));
                        //The residential building and emergeny service are within 10 grid points of each other
                        if (distance <= Math.Sqrt(200))
                        {
                            //Adds one to the number of industrial buildings relative to the residential building
                            _industrialCount++;
                        }
                    }
                } 
            }
            //Residential building is within the correct number of grid spaces of a school, hospital, and emergency service
            if (withinEmergencyService == true && withinHospital == true && withinSchool == true)
            {
                return true;
            }
            //Residential is too far from Essential Services
            else
            {
                return false;
            }
        }
        //Checks if a Industrial and Commercial building can be made
        //Takes in coordinates of the Industrial and Commercial building and compares it to the hospital and emergency services within proxmity
        //Returns true if the Industrial or Commercial building is within proximity and false otherwise
        public bool CheckIndustrialAndCommercial(int XCoordIndustrialCommercial, int YCoordIndustrialCommercial)
        {
            //Stores the distance between buildings
            int distance = 0;
            //Checks if within Essential Service buildings
            bool withinEmergencyService = false;
            bool withinHospital = false;
            //Loops through 2D land array to find Essetial Service buildings
            for (int X = 0; X < 10; X++)
            {
                for (int Y = 0; Y < 10; Y++)
                {
                    //land elemet is a Hospital
                    if (_land[X, Y] is Hospital)
                    {
                        //Calculates distance between buildings
                        distance = (int)Math.Sqrt(Math.Pow(X - XCoordIndustrialCommercial, 2) + Math.Pow(Y - YCoordIndustrialCommercial, 2));
                        //The Industrial or Commercial building and emergeny service are within 10 grid points of each other
                        if (distance <= Math.Sqrt(200))
                        {
                            withinHospital = true;
                        }
                    }
                    if (_land[X, Y] is Emergency_Services)
                    {
                        //Calculates distance between buildings
                        distance = (int)Math.Sqrt(Math.Pow(X - XCoordIndustrialCommercial, 2) + Math.Pow(Y - YCoordIndustrialCommercial, 2));
                        //The Industrial or Commercial building and emergeny service are within 8 grid points of each other
                        if (distance <= Math.Sqrt(128))
                        {
                            withinEmergencyService = true;
                        }
                    }
                }
            }
            //Commercial or Industrial buildings are within correct number of grid points from Essential Services
            if (withinEmergencyService == true && withinHospital == true)
            {
                return true;
            }
            //Commercial or Industrial is too far from Essential Services
            else
            {
                return false;
            }
        }
        //Saves the user's total score
        private double _score = 0;
       //Gets the user's total score. Only City can change the score
        public double Score
        {
            get
            {
                return _score;

            }
        }
    }
}

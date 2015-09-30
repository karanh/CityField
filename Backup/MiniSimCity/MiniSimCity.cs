using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
/*Karan Huynh
 *May 16th, 2013
 *Minuature version of Sim City*/
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MiniSimCity
{
    public partial class MiniSimCity : Form
    {

        //Button object creates a 2D button array of 10 by 10
        Button[,] cityButtonGrid = new Button[10, 10];
        //Creates a city to update the entire city
        City city = new City();
        public MiniSimCity()
        {
            InitializeComponent();
            SetComBox();

            
        }
        //Sets the values for types of possible land creations in a ComboBox
        private void SetComBox()
        {
            comBoxBuildings.Items.Add("House");
            comBoxBuildings.Items.Add("Apartment");
            comBoxBuildings.Items.Add("Emergency Services");
            comBoxBuildings.Items.Add("School");
            comBoxBuildings.Items.Add("Hospital");
            comBoxBuildings.Items.Add("Factory");
            comBoxBuildings.Items.Add("Office");
            comBoxBuildings.Items.Add("Store");
            comBoxBuildings.Items.Add("Restaurant");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButtonGrid();
            
        }
        //Creates 2D button array
        private void CreateButtonGrid()
        {
            //Loops through to assign an X and Y coordinate for each element in the 2D array
            for (int X = 0; X < cityButtonGrid.GetLength(0); X++)
            {
                for (int Y = 0; Y < cityButtonGrid.GetLength(1); Y++)
                {
                    //Creates a new button
                    cityButtonGrid[X, Y] = new Button();
                    //Sets the width of button to 80 and length to 75
                    cityButtonGrid[X, Y].SetBounds(80 * X, 80 * Y, 75, 75);
                    Controls.Add(cityButtonGrid[X, Y]);
                    //Changes background image of button
                    cityButtonGrid[X, Y].BackgroundImage = Properties.Resources.grass1;
                    //When the button is clicked
                    cityButtonGrid[X, Y].MouseClick += new MouseEventHandler(this.cityGrid_MouseClick);
                }
            }
        }
        //When button is clicked
        private void cityGrid_MouseClick(object sender, MouseEventArgs e)
        {
            //Set the X coordinate
            int XCord = -1;
            //Set the Y coordinate
            int YCord = -1; ;
            //Casts sender from object to Button datatype
            Button selectedButton = (Button)sender;
            //Loops through 2D button array to get coordinates of the clicked button
            for (int X = 0; X < cityButtonGrid.GetLength(0); X++)
            {
                for (int Y = 0; Y < cityButtonGrid.GetLength(1); Y++)
                {
                    //Coordinates found
                    if (selectedButton == cityButtonGrid[X, Y])
                    {
                        //Saves the X coordinate
                        XCord = X;
                        //Saves the Y coordinate
                        YCord = Y;
                        //Set values to so that for loops can break
                        X = cityButtonGrid.GetLength(0);
                        Y = cityButtonGrid.GetLength(1);
                        //Clears lblPrompUser label
                        lblPromptUser.Text = "";
                    }
                }
            }
            //House was selected to be created
            if (comBoxBuildings.SelectedIndex == 0)
            {
                //Makes sure the house is within a radius to a school, hospital, and an emergency service so that 
                //a house can be created
                if (city.CheckResidential(XCord, YCord) == true)
                {
                    //Builds a house inside the city class
                    city.BuildHouse(XCord, YCord);
                    //Changes button image
                    ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
                }
                //House cannot be made
                else
                {
                    //Prompts user to build appropriately
                    lblPromptUser.Text = "Residential needs to be within 10 grid spaces of hospital and within 4 grid spaces of an emergency service as well as a school";
                }
                
            }
            //Appartment was selected to be created
            else if (comBoxBuildings.SelectedIndex == 1)
            {
                //Makes sure the apparment is within a radius to a school, hopspital, and an emergency service so that 
                //an appartmet can be created
                if (city.CheckResidential(XCord, YCord) == true)
                {
                    //Builds an appartment in the city class
                    city.BuildApartment(XCord, YCord);
                    //Changes button image
                    ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
                }
                //Appartment cannot be made
                else
                {
                    //Prompts user to build appropriately
                    lblPromptUser.Text = "Residential needs to be within 10 grid spaces of hospital and within 4 grid spaces of an emergency service as well as a school";
                } 
            }
            //EmergencyService was selected to be created
            else if (comBoxBuildings.SelectedIndex == 2)
            {
                //Builds an emergecy service in the city class
                city.BuildEmergencyService(XCord, YCord);
                //Changes button image
                ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);               
                
            }
            //School was selected to be created
            else if (comBoxBuildings.SelectedIndex == 3)
            {
                //Builds a school in the city class
                city.BuildSchool(XCord, YCord);
                //Changes button image
                ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
             

            }
            //Building was selected to be created
            else if (comBoxBuildings.SelectedIndex == 4)
            {
                //Builds a hospital in the city class
                city.BuildHospital(XCord, YCord);
                //Changes button image
                ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
            

            }
            //Factory was selected to be created
            else if (comBoxBuildings.SelectedIndex == 5)
            {
                //Makes sure the house is within a radius to a hospital and an emergency service so that 
                //a factory can be created
                if (city.CheckIndustrialAndCommercial(XCord, YCord) == true)
                {
                    //Builds a factory in the city class
                    city.BuildFactory(XCord, YCord);
                    //Changes button image
                    ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
                }
                //Factory cannot be made
                else
                {
                    //Prompts user to build appropriately
                    lblPromptUser.Text = ("Factory needs to be within 20 grid spaces of hospital as well as within 8 grid spaces of an emergency service");
                }
            }
            //Office was selected to be created
            else if (comBoxBuildings.SelectedIndex == 6)
            {
                //Makes sure the house is within a radius to a hospital and an emergency service so that 
                //a office can be created
                if (city.CheckIndustrialAndCommercial(XCord, YCord) == true)
                {
                    //Builds a office in the city class
                    city.BuildOffice(XCord, YCord);
                    //Changes button image
                    ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
                }
                //Office cannot be made
                else
                {
                    //Prompts user to build appropriately
                    lblPromptUser.Text = ("Factory needs to be within 20 grid spaces of hospital as well as within 8 grid spaces of an emergency service");
                }
               
            }
            //Store was selected to be created
            else if (comBoxBuildings.SelectedIndex == 7)
            {
                //Makes sure the house is within a radius to a hospital and an emergency service so that 
                //a store can be created
                if (city.CheckIndustrialAndCommercial(XCord, YCord) == true)
                {
                    //Builds a store in the city class
                    city.BuildStore(XCord, YCord);
                    ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
                }
                //Store cannot be created
                else
                {
                    //Prompts user to build appropriately
                    lblPromptUser.Text = ("Factory needs to be within 20 grid spaces of hospital as well as within 8 grid spaces of an emergency service");
                }

            }
            //Restaurant was selected to be created
            else if (comBoxBuildings.SelectedIndex == 8)
            {
                //Makes sure the house is within a radius to a hospital and an emergency service so that 
                //a restaurant can be created
                if (city.CheckIndustrialAndCommercial(XCord, YCord) == true)
                {
                    //Builds a restaurant in the city class
                    city.BuildRestaurant(XCord, YCord);
                    //Changes button image
                    ChangeLandImage(selectedButton, city.Land[XCord, YCord].image);
                }
                //Restaurant cannot be created
                else
                {
                    //Prompts user to build appropriately
                    lblPromptUser.Text = ("Factory needs to be within 20 grid spaces of hospital and with * grid spaces of emergency service");
                }
                
            }
        }
        //Sets a new image for a button once clicked   
        //Takes in the selected button and the image associated with type of land created on the button
        private void ChangeLandImage(Button selectedButton, Image image)
        {
            //Assigns the button a new image
            selectedButton.BackgroundImage = image;
            //Adjusts the button image to fit the button
            selectedButton.BackgroundImageLayout = ImageLayout.Stretch;
            //Disables the button so that no other land can be built on top of existing land
            selectedButton.Enabled = false;
        }
        //Creates a date for the game
        DateTime currentDate = new DateTime(2013, 1, 1);
        //Adjusts the format of the date
        string dateFormat = "MMMM, dd, yyyy";
        //Used to count each 3 month period
        private int _turnover = 0;
        //Timer that updates the city class
        //Every 1 minute in realtime is 3 months on the game
        private void tmrCurrentDate_Tick(object sender, EventArgs e)
        {
            //Adds one day to the date
            currentDate = currentDate.AddDays(1);
            //Displays date to the user
            lblDate.Text = currentDate.ToString(dateFormat);
            //Add one to the 90 period day count
            _turnover++;
            //New round in the game
            if (_turnover == 90)
            {
                //Updates the city in the city class
                city.UpdateCity();
                //Updates the score in the city class
                city.GetScore();
                //Resets 90 day period count
                _turnover = 0;

            }
            //Formats the string to fit currency
            string money = string.Format("Currency: {0:$###,###,###,###0}", city.Money);
            //Displays the money of the city to the user
            lblMoney.Text = money;
            //Displays the economy of the city to te user
            lblEconomy.Text = city.Economy.ToString();
            //Displays the population of the city to the user
            lblPopulation.Text = city.Population.ToString();
            //Displays the user's score to the user
            lblScore.Text = city.Score.ToString();
        }

    }

}

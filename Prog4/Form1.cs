// Program 4
// CIS 199-01/-75
// Due: 4/24/2016
// By: Spencer G. Duncan

//This application takes all the package infromation and then 
//ensures that all the values are valid. Next it calculates the price
//to ship the package and can update the zipcodes and give you the details.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog4
{
    public partial class Form1 : Form
    {
        const int uoflZip = 40292; //UofL's zipcode
        
        private List<GroundPackage> packageList = new List<GroundPackage>(); //creates a list that will store information regarding different packages
        
        public Form1()
        {
            InitializeComponent();
        }

        // Precondition:  all values entered must be either an int or a double
        // Postcondition: Valitdates all numbers that are entered are numbers and then dispalys 
        //                the final price to the screen.

        private void addPackageBtn_Click(object sender, EventArgs e)
        {
            int originZip; //stores the zipcode that the package is sent from
            int destinationZip; //stores the zipcode that the package is sent to
            double length; //stores the length of the package
            double width; //stores the width of the package
            double height; //stores the height of the package
            double weight; //stores the weight of the package
            double price; //stores the final cost of the package

            //Validates all user data entered is actually a number
            if (int.TryParse(originZipTxt.Text, out originZip))
            {
                if (int.TryParse(destZipTxt.Text, out destinationZip))
                {
                    if (double.TryParse(lengthTxt.Text, out length))
                    {
                        if (double.TryParse(widthTxt.Text, out width))
                        {
                            if (double.TryParse(heightTxt.Text, out height))
                            {
                                if (double.TryParse(weightTxt.Text, out weight))
                                {
                                    
                                    //initializes the groundpackage class
                                    GroundPackage package = new GroundPackage(originZip, destinationZip, length, width, height, weight);
                                    
                                    //adds the newly created package to the package list
                                    packageList.Add(package);
                                    //price is stored and calculated
                                    price = package.CalcCost;
                                    //displays the price to the screen
                                    priceListBox.Items.Add(price.ToString("C"));

                                    //clears all the textboxes
                                    originZipTxt.Clear();
                                    destZipTxt.Clear();
                                    lengthTxt.Clear();
                                    widthTxt.Clear();
                                    heightTxt.Clear();
                                    weightTxt.Clear();
 
                                    //error messages are now displayed
                                }
                                else
                                    MessageBox.Show("Invalid Data has been entered into the weight textbox.");
                            }
                            else
                                MessageBox.Show("Invalid Data has been entered into the Height textbox.");
                        }
                        else
                            MessageBox.Show("Invalid Data has been entered into the Width textbox.");
                    }
                    else
                        MessageBox.Show("Invalid Data has been entered into the Length textbox.");
                }
                else
                    MessageBox.Show("Invalid Data has been entered into the Destination Zipcode textbox.");
            }
            else
                MessageBox.Show("Invalid Data has been entered into the Origin Zipcode textbox.");
        }


        // Precondition:  An item in the list box must be selected in order to run
        // Postcondition: shows the details of a package after a price has been selected

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            int notSelected = -1; //the value is set up here so that it can later be determined if a price is selected

            //tests if an item in the listbox is selected
            if (priceListBox.SelectedIndex == notSelected)
            { 
                MessageBox.Show("No package selected.");
            }
            else
            {
                int index = priceListBox.SelectedIndex; //stores the index postion of the price in listbox so it can be used in the package list
                MessageBox.Show(packageList[index].ToString());
            }

        }

        // Precondition:  An item in the list box must be selected in order to run
        // Postcondition: Updates the price of the package by setting the originzip to uofl zip

        private void sendToBtn_Click(object sender, EventArgs e)
        {
            int notSelected = -1; //the value is set up here so that it can later be determined if a price is selected

            //tests if an item in the listbox is selected
            if (priceListBox.SelectedIndex == notSelected)
            {
                MessageBox.Show("No package selected.");
            }
            else
            {
                double price; //stores the final cost of the package
                int index = priceListBox.SelectedIndex; //stores the index postion of the price in listbox so it can be used in the package list
                
                //updates the price of the packages
                packageList[index].OriginZip = uoflZip;
                price = packageList[index].CalcCost;

                //updates the listbox
                priceListBox.Items.RemoveAt(index);
                priceListBox.Items.Insert(index, price.ToString("C"));
            }
        }


        // Precondition:  An item in the list box must be selected in order to run
        // Postcondition: Updates the price of the package by setting the destinationzip to uofl zip
        private void sendFromBtn_Click(object sender, EventArgs e)
        {
            int notSelected = -1; //the value is set up here so that it can later be determined if a price is selected

            //tests if an item in the listbox is selected
            if (priceListBox.SelectedIndex == notSelected)
            {
                MessageBox.Show("No package selected.");
            }
            else
            {
                double price; //stores the final cost of the package
                int index = priceListBox.SelectedIndex; //stores the index postion of the price in listbox so it can be used in the package list
                
                //updates the price of the package
                packageList[index].DestinationZip = uoflZip;
                price = packageList[index].CalcCost;

                //updates the listbox
                priceListBox.Items.RemoveAt(index);
                priceListBox.Items.Insert(index, price.ToString("C"));
            }
        }



        
    }
}

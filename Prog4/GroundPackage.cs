// GroundPackage Class
// CIS 199-01/-75
// Due: 4/24/2016
// By: Spencer G. Duncan

//Class that contains a single consturctor and has six parameters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class GroundPackage
    {
        const int ZIP_CODE = 10000; //stores the validation number for the zipcode
        const int DEMINTION_MIN = 1; //stores the minimum acceptable demintion for the package
        const int ZIP_MIN = 0; //stores the mimimum number for the zipcode
        const int ZIP_MAX = 10; //stores the max number for the zipcode
        
        //backing fields
        private int _originzip;  //>=0
        private int _destinationzip;  //>=0
        private double _length;   //>0
        private double _width;   //>0
        private double _height;   //>0
        private double _weight;   //>0

        public GroundPackage(int o, int d, double l, double wi, double h, double we)//Consturctor
        {
            //validation in the sets
            OriginZip = o;
            DestinationZip = d;
            Length = l;
            Width = wi;
            Height = h;
            Weight = we;
        }

        public int OriginZip
        {
            // Precondition:  None
            // Postcondition: The origin zip has been returned
            get
            {
                return _originzip;
            }

            // Precondition:  1 <= value/10,000 < 10
            // Postcondition: The originzip has been set to the specified value
            set
            {
                int testVariable = value / ZIP_CODE; // stores the zipcode in a form that it can be validated

                //validates the origin zipcode
                if (testVariable >= ZIP_MIN && testVariable < ZIP_MAX)
                    _originzip = value;
            }
        }

        public int DestinationZip
        {
            // Precondition:  None
            // Postcondition: The destination zip has been returned
            get
            {
                return _destinationzip;
            }

            // Precondition:  1 <= value/10,000 < 10
            // Postcondition: The destzip has been set to the specified value
            set
            {
                int testVariable = value / ZIP_CODE;// stores the zipcode in a form that it can be validated

                //validates the destination zipcode
                if (testVariable >= ZIP_MIN && testVariable < ZIP_MAX)
                    _destinationzip = value;
            }
        }

        public double Length
        {
            // Precondition:  None
            // Postcondition: The length has been returned
            get
            {
                return _length; 
            }


            // Precondition:  1 <= value 
            // Postcondition: The length has been set to the specified value
            set 
            {
                //validates the length
                if (value >= DEMINTION_MIN)
                    _length = value;
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: The width has been returned
            get
            {
                return _width;
            }


            // Precondition:  1 <= value
            // Postcondition: The width has been set to the specified value
            set
            {
                //validates the width
                if (value >= DEMINTION_MIN)
                    _width = value;
            }
        }

        public double Height
        {
            // Precondition:  None
            // Postcondition: The weight has been returned
            get
            {
                return _height;
            }


            // Precondition:  1 <= value 
            // Postcondition: The height has been set to the specified value
            set
            {
                //validates the height
                if (value >= DEMINTION_MIN)
                    _height = value;
            }
        }

        public double Weight
        {
            // Precondition:  None
            // Postcondition: The weight has been returned
            get
            {
                return _weight;
            }


            // Precondition:  1 <= value 
            // Postcondition: The weight has been set to the specified value
            set
            {
                //validates the weight
                if (value >= DEMINTION_MIN)
                    _weight = value;
            }
        }

        public int ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The distance between the two zipcodes is determined and returned
            get 
            {
                return Math.Abs((OriginZip / ZIP_CODE) - (DestinationZip / ZIP_CODE));
            }
        }

        public double CalcCost
        {
            // Precondition:  None
            // Postcondition: The pacakge price is determined and returned
            get 
            {
                return (.20 * (Length + Width + Height) + .5 * (ZoneDistance + 1) * (Weight));
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the date in US format
        public override string ToString()
        {
            string result; // builds the output for for the date

            return result = "Origin Zip: " + OriginZip.ToString("D5") + System.Environment.NewLine +
                            "Destination Zip: " + DestinationZip.ToString("D5") + System.Environment.NewLine +
                            "Length: " + Length.ToString() + System.Environment.NewLine + 
                            "Width: "  + Width.ToString() + System.Environment.NewLine +
                            "Height: " + Height.ToString() + System.Environment.NewLine +
                            "Weight " + Weight.ToString();

        }
    }
}

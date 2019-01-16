using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review
{
    public class Die
    {
        //use the System.Random class for my random number generator 
        //the instance will be static so all instances of Die will use 
        // the same generator
        // the instance of random will be created when the first instance 
        // of die is created and be destroyed when the lsat instance of Die is destroyed 
        //Data Members
        // This is the physical storage area for data values
        // These are usually private 
        public static Random rnd = new Random();


        private int _Sides;
        private string _Color;
        
        //Properties 
        // Properties are public 
        // is used as an interface for the class user to accesss a data member
        // Accessing a data member can include a get and set
        //  A get returns the value of the data member
        //  A set accepts a value and assigns the value to the data member

        // A property returns a specific datatype
        // aA property does NOT have a parameter list
        //Fully Implemented Property
        public int Sides
        {
            get
            {
                //returns the current value of the data member
                return _Sides;
            }

            set
            {
                // can be private 
                // it accepts a value and assigns it to the data member
                // the value is stored in a keyword: value
                // the datatype of value is the return datatype of the property
                // validation can be done on the value 
                if (value >= 6 && value <= 20)
                {
                    _Sides = value;
                }
                else
                {
                    throw new Exception("Die cannot have " + value.ToString() + "sides. Die can have 6 - 20 sides");
                }
                _Sides = value;
            }
            
        }

        public string Colours
        {
            get
            {

                return _Color;
            }

            set
            {
            
                if(string.IsNullOrWhiteSpace(value))
                {

                    throw new Exception("Die cannot be " + value + "please select a colour");
                }
                else
                {

                    _Color = value;
                }

            }


        }

        //Auto Imnplemented Property
        // there is no defined data member for this type of property
        //instead the system creates an internal storage area of the 
        //property data type and manages the area for your code.
        //typically this type of property is commonly used when no validation is required for the data.

        public int FaceValue { get; private set; }

        public string Color { get; set; }

        //CONSTRUCTORS
        //optionally 
        //if you do not include a constructor for your class, then when an instance of the class is created, 
        //the system will assign the normal default values of that datatype to the appropriate data member.

        //if you declare a constructor within your class definition, then,
        //you are responsibile for all constructors for the class. 
        // constructors are not called directly by the user of the class
        // the constructor wull be called wgeb you ask the system to create an instane of the class


        //syntax public classname([ list of parameters ]) { }

        //DEFAULT CONSTRUCTORS
        //this is similar to having a system constructor
        //it has no parameters 

        public Die ()
        {
            //typically this contructor (default) will have no code.
            //it will use the system default. 

            //you could assign your own defaults. 

            _Sides = 6;
            Color = "White";
            Roll();
        }


        //GREEDY CONSTRUCTORS 
        //takes in values for each of your data members/auto properties
        //this allows the outside "users" wants to specify the values at time
        // of creation for the instance. 
        public Die(int sides, string colour, int facevalue)
        {

            Sides = sides;
            Color = colour;
            FaceValue = facevalue;

        }

        //Behaviour (methods)
        // a method will allow the user to:
        //a) manipulate the data of the instance 
        //b) use the data of the instance to generate some other information 
        
        public void Roll()
        {
            //will generate a random value for facevalue
            FaceValue = rnd.Next(1, Sides + 1);
        }
    }
}

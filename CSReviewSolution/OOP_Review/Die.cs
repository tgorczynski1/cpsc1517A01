using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Review
{
    public class Die
    {
        //Data Members 
        // This is the physical storage area for data values
        // These are usually private 

        private int _Sides;
        private string _Color;
        private int _FaceValue;
        private List<int> _ValidList;
        
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

        //Auto Imnplemented Property

    }
}

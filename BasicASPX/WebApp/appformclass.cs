using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class appformclass
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Streetaddress1 { get; set; }
        private string _Streetaddress2; 
        public string City { get; set; }
        public string Province { get; set; }
        public string Postalcode { get; set; }
        public string Email { get; set; }


        public string Streetaddress2
        {
            get
            {
                return _Streetaddress2;
            }
            set
            {
                _Streetaddress2 = string.IsNullOrEmpty(value.Trim()) ? null : value;
            }

        }

        public appformclass()
        {

        }

        public appformclass(string firstname, string lastname, string streetaddress1, string streetaddress2, string city, string province, string postalcode, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Streetaddress1 = streetaddress1;
            Streetaddress2 = streetaddress2;
            City = city;
            Province = province;
            Postalcode = postalcode;
            Email = email;

        }
    }
}
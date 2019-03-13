using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        //the only reason we are using this List<T> is because we do not have a database to store our data. We are also NOT using 
        //  ViewState, cookies or session variables
        public static List<appformclass> gvcontestcollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";

            if (!Page.IsPostBack)
            {
                //first time page is processed
                gvcontestcollection = new List<appformclass>();
            }
            else
            {

            }

        }

        
        protected void Submit_Click(object sender, EventArgs e)
        {
            //validate the incoming data 
            if (Page.IsValid)
            {
                //validate that the terms were accepted
                if (Terms.Checked)
                {
                    //  yes: create/load entry; add to storage; display entries
                    Message.Text = "good";
                }
                else
                {
                    //  no: rejection message
                    Message.Text = "You did not accept the terms of the contest. Entry Rejected!";
                }

            }
            
            //  Validation~~ 
            //  Required: Ensures that the user supplied data
            //  Range: Ensures that the supplied data values are in a lower-high range of numbers or characters
            //  RegularExpression: Ensures that the supplied data value matches a given pattern
            //  Custom: Calls a user programmed server side method
            //  Compare: i) Datatype check, data? currency? integer?
            //           ii) check the entered vale against a constant value
            //           iii) check one data control against a second data control
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            Province.SelectedIndex = 0;
            PostalCode.Text = "";
            EmailAddress.Text = "";
            Terms.Checked = false;

        }

    }
}
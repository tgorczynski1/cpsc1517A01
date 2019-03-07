﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //we could retrieve data from a stored variable that is part of the web page saved under the ViewState
        //instead, we will use a static List<T> for THIS EXAMPLE
        //normally your data would be coming from the database

        public static List<DDLClass> DataCollection;

        protected void Page_Load(object sender, EventArgs e)
        {
            //this method is executed automatically on EACH and EVERY pass of the page 
            //this method is executed before any event method 

            //this method is an excellent place to do page initialization 

            //clear any old messages 
            OutputMessage.Text = "";

            //you can test the post back of the page (Razor IsPost) by 
            //check the Page.IsPostBack property 
            if (!Page.IsPostBack)
            {
                //the first time the page is processed

                //create an instance of the List<T> 
                DataCollection = new List<DDLClass>();

                //load the collection with a series of DDLClass instances
                //create the instances using the greedy constructor

                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(3, "DMIT2018"));
                DataCollection.Add(new DDLClass(4, "DMIT1508"));

                //use the list<T> method called .Sort to sort the content of the list 
                //(x,y) the x and y represent any two instances at any time in your collection 
                //x.field compared to y.field (ascending)
                //y.field compared to x.field (descending)
                DataCollection.Sort((x, y) => x.DisplayField.CompareTo(y.DisplayField));
                                        //lambda operator
                //load your data collection to the asp control you are interested in: DropDownList
                //a) assign your data collection to the control
                CollectionList.DataSource = DataCollection;

                //b) setup any necessary properties on your asp control that are required to properly work
                //the dropdown list will generate the html select tag code 
                //thus we need two properties to be set 
                //  i) the value property
                //  ii) the display property DataTextField
                //the properties are setup by assigning the data collection field name to the control property
                CollectionList.DataValueField = "ValueField";
                CollectionList.DataTextField = nameof(DDLClass.DisplayField);

                //c) bind your data to the control
                CollectionList.DataBind();

                //what about prompts?
                //manually place a line item at the beginning of your control
                CollectionList.Items.Insert(0, "select.....");

            }
        }

        protected void SubmitChoice_Click(object sender, EventArgs e)
        {
            //how does one retrieve or assign data to an asp control
            //retrieving or assigning data to a control iss dependent on the specific control

            //for TextBox, Label, Literial use .Text
            //for Checkbox (boolean) use .Checked 
            //for positioning in a list control (DropDownList, RadioButtonList, CheckBoxList)
            //  a).SelectedValue    for the datavalue
            //  b).SelectedIndex    for the physical index location in the list 
            //  c).SelectedItem     for the display text

            //most data from the controls will be strings the exception is the boolean type controls (true/false)

            string submitchoice = TextBoxNumericChoice.Text;

            //you can do any type of validation against your code
            if (string.IsNullOrEmpty(submitchoice))
            {
                OutputMessage.Text = "Enter a course choice between 1 and 4";
            }
            else
            {
                //for the RadioButtonList we could use: .SelectedIndex, .SelectedValue or .SelectedItem
                //we want the associated value for the button
                RadioButtonListChoice.SelectedValue = submitchoice;

                //checkbox (boolean)
                if(submitchoice.Equals("2") || submitchoice.Equals("3"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                //position in the dropdownlist using the value in the submitchoice
                //remember SelectedIndex is the physical index location of an item in the list. It is NOT the associate value 
                CollectionList.SelectedValue = submitchoice;

                //use the 4 properties for a list control as a demo
                DisplayDataReadOnly.Text = CollectionList.SelectedItem.Text + " at index " + 
                    CollectionList.SelectedIndex + " has a value of " + CollectionList.SelectedValue;
            }


        }
    }
}
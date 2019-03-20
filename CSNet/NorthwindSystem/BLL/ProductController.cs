﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using NorthwindSystem.Data; //the .Data class
using NorthwindSystem.DAL;//the DAL context class
#endregion

namespace NorthwindSystem.BLL
{

    //the classes within the BLL are refered to as your interface
    //these classes will be called by your webapp
    //for ease of maintence, each class will represent a specific data class  i.e. Product
    public class ProductController
    {
        //create a method to find a specific record on the SQL table
        //this will be done by the primary key
        //input: search argument value 
        //output: results of the search -> a single product record
        //this method is public
        public Product Product_Get(int productid)
        {
            //connect to the appropriate context class to access the database 
            //create an instance of the appropriate context class 
            //accessing the appropriate DbSet<T>, issue a request for execution 
            //  against the SQL table
            //the appropriate request return data will be received
            //return these results 
            //the request will be done in a transaction
            //this lookup is by PRIMARY KEY
            using (var context = new NorthwindContext())
            {
                return context.Products.Find(productid);
            }
        }

        //obtain a list of all table records
        //input: nothing
        //output: List<T> where <T> is the appropriate data class (Product)
        public List<Product> Product_List()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }

    }
}

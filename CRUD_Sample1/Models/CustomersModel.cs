using CRUD_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Sample1.Models
{
    public class CustomersModel
    {
        private NorthwindEntities db = new NorthwindEntities();

        public List<Customers> CustomersList { get; set; }

        public CustomersModel()
        {
            CustomersList = new List<Customers>();
        }

        public List<Customers> GetCustomersList()
        {
            return db.Customers.ToList();
        }
    }
}
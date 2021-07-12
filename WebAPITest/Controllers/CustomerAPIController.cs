using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class CustomerAPIController : ApiController
    {
        APIExDBEntities db = new APIExDBEntities();
        [HttpGet]
        public IHttpActionResult  GetCustomers()
        {
            return Ok(db.CustomerTbls.ToList());
        }

        //[HttpGet]
        //public IEnumerable<CustomerTbl> GetCustomers(int id)
        //{
        //    var query = from p in db.CustomerTbls
        //                where p.CustomerCategoriesID == id
        //                select p;
        //    var customers = query.ToList();
        //    return customers;
        //}
        [HttpGet]
        public IHttpActionResult GetCustomers(int id)
        {
            var customers = (from p in db.CustomerTbls
                        where p.CustomerCategoriesID == id
                        select new
                        { 
                            CustomerID=p.CustomerID,
                            CustomerName=p.CustomerName,
                            PrimaryContact=p.PrimaryContact,
                           PhoneNumber=p.PhoneNumber,
                            CustomerCategoriesName=p.CustomerCategoriesTbl.CustomerCategoriesName
                        }).ToList();         
            return Ok(customers);
        }
    }
}

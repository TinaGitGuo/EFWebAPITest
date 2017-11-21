using System;
using System.Collections.Generic;

namespace EFWebAPITest.Models
{
    public partial class CustomerCustomerDemo
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public Customers Customer { get; set; }
        public CustomerDemographics CustomerType { get; set; }
    }
}

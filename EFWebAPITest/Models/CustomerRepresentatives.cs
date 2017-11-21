using System;
using System.Collections.Generic;

namespace EFWebAPITest.Models
{
    public partial class CustomerRepresentatives
    {
        public int RepresentativeId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
    }
}

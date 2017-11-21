using System;
using System.Collections.Generic;

namespace EFWebAPITest.Models
{
    public partial class ProductLang
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int LanguageId { get; set; }
        public string ProductName { get; set; }
    }
}

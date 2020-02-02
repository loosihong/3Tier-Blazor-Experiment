using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModelLibrary.ViewModel
{
    class Company
    {
        public Guid CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAttDoc { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}

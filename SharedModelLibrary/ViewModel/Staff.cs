using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModelLibrary.ViewModel
{
    class Staff
    {
        public Guid StaffID { get; set; }
        public string StaffName { get; set; }
        public string EmailAddr { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Photo { get; set; }

    }
}

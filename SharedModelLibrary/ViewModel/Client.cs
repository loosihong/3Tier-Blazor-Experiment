using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModelLibrary.ViewModel
{
    class Client
    {
        public Guid ClientID { get; set; }
        public string Name { get; set; }
        public string EmailAddr { get; set; }
        public string Password { get; set; }

    }
}

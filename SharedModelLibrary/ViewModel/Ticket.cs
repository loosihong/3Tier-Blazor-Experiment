using System;
using System.Collections.Generic;
using System.Text;

namespace SharedModelLibrary.ViewModel
{
    class Ticket
    {
        public Guid TicketID { get; set; }
        public string TicketTitle { get; set; }
        public string Attachment { get; set; }
        public string Resolution { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateResolved { get; set; }
        public string SLA { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.Shared.Model {
    public class ContactDetail {
        public int ContactDetailId { get; set; }
        public string Description { get; set; }
        public ContactType ContactTypeId { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}

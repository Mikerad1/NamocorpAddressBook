using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook.Shared.Model {
    public class Contact {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        List<ContactDetail> ContactDetails { get; set; }
    }
}

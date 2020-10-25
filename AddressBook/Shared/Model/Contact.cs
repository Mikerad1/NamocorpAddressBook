using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Shared.Model {
    public class Contact {
        public int ContactId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public List<ContactDetail> ContactDetails { get; set; }
    }
}

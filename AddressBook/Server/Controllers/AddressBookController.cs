using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AddressBook.Server.Data;
using AddressBook.Shared.Model;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Server.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase {
        private readonly ApplicationDbContext _db;
        public AddressBookController(ApplicationDbContext db) {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<Contact> Get() {
            return _db.Contacts;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Contact contact){
            try
            {
                _db.Contacts.Add(contact);
                _db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return Ok("An error occured while adding contact to the database");
            }
        }

        [HttpDelete]
        public void Delete(int id){
            Contact contextContact = _db.Contacts.Find(id);
            foreach (ContactDetail detail in contextContact.ContactDetails)
            {
                contextContact.ContactDetails.Remove(detail);
            }
            _db.Contacts.Remove(contextContact);
            _db.SaveChanges();
        }
    }
}

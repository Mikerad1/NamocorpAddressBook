using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AddressBook.Server.Data;
using AddressBook.Shared.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public ContactDetailsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            ContactDetail contactDetail = _db.ContactDetails.Find(id);
            _db.ContactDetails.Remove(contactDetail);
            _db.SaveChanges();
        }
        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            try
            {
                Contact contextContact = _db.Contacts.Find(contact.ContactId);
                contextContact.ContactDetails.Add(contact.ContactDetails[^1]);
                _db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return Ok("An error occured while adding contact detail to the database");
            }
        }
    }
}

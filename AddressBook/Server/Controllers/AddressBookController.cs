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
    }
}

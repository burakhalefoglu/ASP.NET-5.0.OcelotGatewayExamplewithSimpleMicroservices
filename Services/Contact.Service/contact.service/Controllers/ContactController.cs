using contact.Business.Abstract;
using Contact.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace contact.service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public ActionResult<MessageModel> getbyid(MessageModel messageModel)
        {
            var result = _contactService.AddContactMessage(messageModel);
            return Ok(result);
        }
    }
}

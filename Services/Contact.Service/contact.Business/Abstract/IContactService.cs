using Contact.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact.Business.Abstract
{
    public interface IContactService
    {
        string AddContactMessage(MessageModel messageModel);
    }
}

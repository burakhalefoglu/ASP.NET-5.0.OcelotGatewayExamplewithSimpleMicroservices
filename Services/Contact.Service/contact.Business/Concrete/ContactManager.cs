using contact.Business.Abstract;
using Contact.DataAccess.Abstract;
using Contact.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contact.Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public string AddContactMessage(MessageModel messageModel)
        {
            return _contactDal.add(messageModel);
        }
    }
}

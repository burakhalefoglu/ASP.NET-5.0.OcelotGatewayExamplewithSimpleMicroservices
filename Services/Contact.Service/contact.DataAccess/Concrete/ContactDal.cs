using Contact.DataAccess.Abstract;
using Contact.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.DataAccess.Concrete
{
    public class ContactDal : IContactDal
    {
        public string add(MessageModel model)
        {
            return "Mesaj eklendi!";
        }


    }
}

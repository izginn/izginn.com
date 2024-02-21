using BusinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactServices
    {
        IContact _icontact;

        public ContactManager(IContact icontact)
        {
            _icontact = icontact;
        }

        public void TAdd(Contact t)
        {
            _icontact.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _icontact.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _icontact.GetById(id);
        }

        public List<Contact> TGetList()
        {
            return _icontact.GetList();
        }

        public void TUpdate(Contact t)
        {
            _icontact.Update(t);
        }
    }
}

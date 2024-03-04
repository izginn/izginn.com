using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace izginn.ViewComponents.Contact
{
    public class ContactList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ContactManager contactmanager = new ContactManager(new EfContact());
            var value = contactmanager.TGetList();
            return View(value);
        }
    }
}

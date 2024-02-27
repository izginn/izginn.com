using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace izginn.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ServiceManager service = new ServiceManager(new EfService());
            var values = service.TGetList();
            return View(values);
        }
    }
}

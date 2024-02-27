using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace izginn.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AboutManager about = new AboutManager(new EfAbout());
            var values = about.TGetList();
            return View(values);
        }
    }
}

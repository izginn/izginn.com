using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace izginn.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ExperienceManager experiencemanager = new ExperienceManager(new EfExperience());
            var values = experiencemanager.TGetList();
            return View(values);
        }
    }
}

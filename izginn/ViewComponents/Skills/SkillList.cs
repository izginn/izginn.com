using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace izginn.ViewComponents.Skills
{
    public class SkillList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SkillManager skills = new SkillManager(new EfSkill());
            var value= skills.TGetList();
            return View(value);
        }
    }
}

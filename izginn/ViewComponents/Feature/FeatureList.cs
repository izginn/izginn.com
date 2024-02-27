using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace izginn.ViewComponents.Feature
{
    public class FeatureList: ViewComponent
    {
        public IViewComponentResult Invoke() {
            FeatureManager fm = new FeatureManager(new EfFeature());
            var values = fm.TGetList();
            return View(values);
        }
    }
}

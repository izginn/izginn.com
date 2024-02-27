using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace izginn.ViewComponents.Portfolio
{
    public class PortfolioList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            PortfolioManager portfolio = new PortfolioManager(new EfPortfolio());
            var value=portfolio.TGetList();
            return View(value);
        }
    }
}

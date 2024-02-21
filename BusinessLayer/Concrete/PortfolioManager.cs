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
    public class PortfolioManager : IPortfolioServices
    {
        IPortfolio _iportfolio;

        public PortfolioManager(IPortfolio iportfolio)
        {
            _iportfolio = iportfolio;
        }

        public void TAdd(Portfolio t)
        {
            _iportfolio.Insert(t);
        }

        public void TDelete(Portfolio t)
        {
           _iportfolio?.Delete(t);  
        }

        public Portfolio TGetById(int id)
        {
            return _iportfolio.GetById(id);
        }

        public List<Portfolio> TGetList()
        {
            return _iportfolio.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            _iportfolio.Update(t);
        }
    }
}

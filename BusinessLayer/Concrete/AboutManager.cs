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
    public class AboutManager : IAboutServices
    {
        IAbout _iabout;

        public AboutManager(IAbout iabout)
        {
            _iabout = iabout;
        }

        public void TAdd(About t)
        {
            _iabout.Insert(t);
        }

        public void TDelete(About t)
        {
            _iabout.Delete(t);
        }

        public About TGetById(int id)
        {
           return _iabout.GetById(id);
        }

        public List<About> TGetList()
        {
           return _iabout.GetList();
        }

        public void TUpdate(About t)
        {
            _iabout.Update(t);
        }
    }
}

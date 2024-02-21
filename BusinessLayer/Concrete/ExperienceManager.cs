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
    public class ExperienceManager : IExperienceServices
    {
        IExperience _iexperience;

        public ExperienceManager(IExperience iexperience)
        {
            _iexperience = iexperience;
        }

        public void TAdd(Experience t)
        {
            _iexperience.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _iexperience.Delete(t);
        }

        public Experience TGetById(int id)
        {
            return _iexperience.GetById(id);
        }

        public List<Experience> TGetList()
        {
            return _iexperience.GetList();
        }

        public void TUpdate(Experience t)
        {
            _iexperience.Update(t);
        }
    }
}

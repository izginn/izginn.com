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
    public class SocailMediaManager : ISocialMediaServices
    {
        ISocialMedia _isocailmedia;

        public SocailMediaManager(ISocialMedia isocailmedia)
        {
            _isocailmedia = isocailmedia;
        }

        public void TAdd(SocialMedia t)
        {
            _isocailmedia.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _isocailmedia.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return _isocailmedia.GetById(id);
        }

        public List<SocialMedia> TGetList()
        {
           return _isocailmedia.GetList();
        }

        public void TUpdate(SocialMedia t)
        {
            _isocailmedia.Update(t);
        }
    }
}

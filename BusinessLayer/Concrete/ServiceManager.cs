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
    public class ServiceManager : IServiceServices
    {
        IService _iservice;

        public ServiceManager(IService iservice)
        {
            _iservice = iservice;
        }

        public void TAdd(Service t)
        {
            _iservice.Insert(t);
        }

        public void TDelete(Service t)
        {
            _iservice.Delete(t);
        }

        public Service TGetById(int id)
        {
           return _iservice.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _iservice.GetList();
        }

        public void TUpdate(Service t)
        {
            _iservice.Update(t);
        }
    }
}

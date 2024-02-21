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
    public class FeatureManager : IFeatureServices
    {
        IFeature _ifeature;

        public FeatureManager(IFeature ifeature)
        {
            this._ifeature = ifeature;
        }

        public void TAdd(Feature t)
        {
            _ifeature.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _ifeature.Delete(t);
        }

        public Feature TGetById(int id)
        {
            return _ifeature.GetById(id);
        }

        public List<Feature> TGetList()
        {
            return _ifeature.GetList();
        }

        public void TUpdate(Feature t)
        {
            _ifeature.Update(t);
        }
    }
}

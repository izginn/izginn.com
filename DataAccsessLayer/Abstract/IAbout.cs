using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IAbout
    {
        void Insert(About p);
        void Delete(About p);
        void Update(About p);
        List<About> GetList();
    }
}

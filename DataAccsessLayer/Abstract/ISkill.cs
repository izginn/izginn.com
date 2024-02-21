using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface ISkill
    {
        void Insert(Skill p);
        void Update(Skill p);
        void Delete(Skill p);
        List<Skill> GetList();
    }
}

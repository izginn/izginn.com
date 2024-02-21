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
    public class SkillManager : ISkillServices
    {
        ISkill _iskill;

        public SkillManager(ISkill iskill)
        {
            _iskill = iskill;
        }

        public void TAdd(Skill t)
        {
            _iskill.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _iskill.Delete(t);
        }

        public Skill TGetById(int id)
        {
            return _iskill.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _iskill.GetList();
        }

        public void TUpdate(Skill t)
        {
            _iskill.Update(t);
        }
    }
}

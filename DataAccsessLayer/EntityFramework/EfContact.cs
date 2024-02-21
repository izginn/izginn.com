using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccsessLayer.EntityFramework
{
    public class EfContact: GenericRepository<Contact>, IContact
    {
    }
}

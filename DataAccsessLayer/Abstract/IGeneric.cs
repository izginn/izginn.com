﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IGeneric<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById (int id);
    }
}

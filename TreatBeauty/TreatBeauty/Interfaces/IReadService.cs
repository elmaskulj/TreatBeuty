﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreatBeauty.Interfaces
{
    public interface IReadService<T,TSearch> where T : class where TSearch : class
    {
        public IEnumerable<T> Get(TSearch search = null);
        public T GetById(int Id);

    }
}

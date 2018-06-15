using Source;
using System;
using System.Collections.Generic;
using System.Text;

namespace Access
{
    interface IRepository<T>
    {
        List<T> Items { get; }
        void LoadData();
        void Add(T t);
        
        
        
    }
}

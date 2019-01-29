using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    interface IRepository
    {
       // object[] All();
        List<object> All();
        void Insert(object item);
        object GetById(Guid id);
        bool Delete(Guid id);
        void Update(Guid id, object item);
    }
}

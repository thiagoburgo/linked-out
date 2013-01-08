using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Qualiti.LinkedOut.BusinessDataLayerContracts {
    public interface IDataService<T>
    {
        List<T> List();
        void Delete(object key);
        void Delete(T entity);
        void Update(object keyForUpdate, T newEntity);
        object Create(T newEntity);
    }
}

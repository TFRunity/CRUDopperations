using SiteCtor.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteCtor.Interfaces
{
    public interface IDBMethods<T> where T: class
    {
        public void CreateObj(T modelclass);
        public void DeleteObj(T modelclass);
        public T GetObj(T modelclass);
        public List<T> GetAllObj();
        public void UpdateObj(T updatingmodel, T oldmodel);
    }
}

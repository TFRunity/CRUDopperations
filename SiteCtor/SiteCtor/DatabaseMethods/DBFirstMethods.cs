using Microsoft.EntityFrameworkCore;
using SiteCtor.DataBase;
using SiteCtor.Interfaces;
using SiteCtor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteCtor.DatabaseMethods
{
    public class DBFirstMethods<T> : IDBMethods<T> where T: FirstSiteModel
    {
        private readonly AppDBContext _appDBContext;
        public DBFirstMethods(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public void CreateObj(T copyFirstModel)
        {
            _appDBContext.FirstSiteModels.Add(copyFirstModel);
            _appDBContext.SaveChanges();
        }
        public void DeleteObj(T copyFirstModel)
        {
            _appDBContext.FirstSiteModels.Remove(copyFirstModel);
            _appDBContext.SaveChanges();
        }
        public T GetObj(T copyFirstModel)
        {
            int _id = copyFirstModel.Id;
            T currentObj = (T)_appDBContext.FirstSiteModels.ElementAt(_id);
            return currentObj;
        }
        public List<T> GetAllObj()
        {
            List<T> AllFirstSiteModels = new List<T>();
            foreach(T model in _appDBContext.FirstSiteModels)
            {
                AllFirstSiteModels.Add(model);
            }
            return AllFirstSiteModels;
        }
        public void UpdateObj(T updatingmodel, T oldmodel)
        {
            oldmodel.Name = updatingmodel.Name;
            oldmodel.Description = updatingmodel.Description;
            _appDBContext.Entry(oldmodel).State = EntityState.Modified;
            _appDBContext.SaveChanges();
        }
    }
}

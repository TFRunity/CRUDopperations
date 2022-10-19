using SiteCtor.DataBase;
using SiteCtor.Interfaces;
using SiteCtor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SiteCtor.DatabaseMethods
{
    public class DBSecondMethods<T> : IDBMethods<T> where T : SecondSiteModel
    {
        private readonly AppDBContext _appDBContext;
        public DBSecondMethods(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public void CreateObj(T copySecondModel)
        {
            _appDBContext.SecondSiteModels.Add(copySecondModel);
            _appDBContext.SaveChanges();
        }
        public void DeleteObj(T copySecondModel)
        {
            _appDBContext.SecondSiteModels.Remove(copySecondModel);
            _appDBContext.SaveChanges();
        }
        public T GetObj(T copySecondModel)
        {
            int _id = copySecondModel.Id;
            T currentObj = (T)_appDBContext.SecondSiteModels.ElementAt(_id);
            return currentObj;
        }
        public List<T> GetAllObj()
        {
            List<T> AllSecondSiteModels = new List<T>();
            foreach (T model in _appDBContext.SecondSiteModels)
            {
                AllSecondSiteModels.Add(model);
            }
            return AllSecondSiteModels;
        }
        public void UpdateObj(T updatingmodel, T oldmodel)
        {
            if (updatingmodel != null)
            {
                oldmodel.Name = updatingmodel.Name;
                _appDBContext.Entry(oldmodel).State = EntityState.Modified;
                _appDBContext.SaveChanges();
            }
        }
    }
}

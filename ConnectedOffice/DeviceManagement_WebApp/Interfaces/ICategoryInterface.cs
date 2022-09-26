using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Interfaces
{
    interface ICategoryInterface
    {
        IEnumerable<Category> GetAll();
        Category GetByID(Guid? id);
        void Insert(Category categoryobj);
        void Update(Category categoryobj);
        void Delete(Guid? id);
        void SaveChanges();
    }
}

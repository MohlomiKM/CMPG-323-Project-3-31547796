using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Interfaces;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public class CategoriesClass:ICategoryInterface
    {
        protected readonly ConnectedOfficeContext _context = null;

        public CategoriesClass()
        {
            this._context = new ConnectedOfficeContext();
        }

        public CategoriesClass(ConnectedOfficeContext _context)
        {
            this._context = _context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Category.ToList();
        }

        public Category GetByID(Guid? id)
        {
            return _context.Category.Find(id);
        }

        public void Insert(Category obj)
        {
            _context.Category.Add(obj);
        }

        public void Update(Category obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Guid? id)
        {
            Category existing = _context.Category.Find(id);
            _context.Category.Remove(existing);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

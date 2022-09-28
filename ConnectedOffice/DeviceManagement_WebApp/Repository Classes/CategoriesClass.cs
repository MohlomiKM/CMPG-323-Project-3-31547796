using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Interface;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository_Classes
{
    public class CategoriesClass:ICategoriesInterface
    {
        private ConnectedOfficeContext _context;

        /*public CategoriesClass()
        {
            this._context = new ConnectedOfficeContext();
        }*/

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

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

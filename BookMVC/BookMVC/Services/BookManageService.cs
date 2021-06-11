using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMVC.Models;

namespace BookMVC.Services
{
    public class BookManageService
    {
        private readonly List<BookModel> _entities = new List<BookModel>();
        public async Task<int> CreateAsync(string title, string desc)
        {
            return await Task.Run(() =>
            {
                var id = 1;
                _entities.Add(new BookModel()
                {
                    Id = id,
                    Title = title,
                    Description = desc
                });
                return id;
            });
        }

        public async Task<bool> UpdateAsync(int id, string title, string desc)
        {
            return await Task.Run(() =>
            {
                var entity = _entities.FirstOrDefault(f => f.Id == id);
                if (entity == null)
                {
                    return false;
                }

                entity.Title = title;
                entity.Description = desc;
                return true;
            });
        }

        public async Task<bool> DeleteAsync(int id)
        {
            if (id == 0)
            {
                return false;
            }

            return await Task.Run(() =>
            {
                var entity = _entities.FirstOrDefault(f => f.Id == id);
                if (entity == null)
                {
                    return false;
                }

                return _entities.Remove(entity);
            });
        }

        public async Task<BookModel> GetByIdAsync(int id)
        {
            return await Task.Run(() =>
            {
                return _entities.FirstOrDefault(f => f.Id == id);
            });
        }
    }
}

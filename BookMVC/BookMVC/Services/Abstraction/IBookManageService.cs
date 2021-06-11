using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMVC.Models;

namespace BookMVC.Services.Abstraction
{
    public interface IBookManageService
    {
        Task<int> CreateAsync(string title, string description);
        Task<bool> UpdateAsync(int id, string title, string description);
        Task<bool> DeleteAsync(int id);
        Task<BookModel> GetByIdAsync(int id);
    }
}

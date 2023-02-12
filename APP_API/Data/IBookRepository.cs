using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APP_API.Model;
using APP_API.ViewModel;
using APP_API.Helpers;

namespace APP_API.Data
{
    public interface IBookRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<book>> GetListBooks(Params prm);
        Task<book> GetBookById(string id);
    }
}
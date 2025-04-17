﻿using TaskAppCrudLast.Models;

namespace TaskAppCrudLast.Repositories
{
    public interface IUserRepository
    {
        IQueryable<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}

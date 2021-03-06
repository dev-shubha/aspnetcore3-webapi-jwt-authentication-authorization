﻿using AspNetCore3_WebAPI_JWT.Models;

namespace AspNetCore3_WebAPI_JWT.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public User Login(string username, string password);
    }
}

﻿using ApiTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTemplate.Data
{
    public interface IAuthRepository
    {
        Task<User> Regiser(User user, string password);
        Task<User> Login(string username, string pasword);
        Task<bool> UserExists(string username);
    }
}

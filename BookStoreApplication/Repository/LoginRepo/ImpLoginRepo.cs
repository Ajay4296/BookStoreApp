﻿using Model.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Repository.DBContext;
using BookStoreRepositoryLayer.Common;

namespace Repository.LoginRepo
{
    public class ImpLoginRepo : ILoginRepo
    {
        /// <summary>
        /// The user database context
        /// </summary>
        private readonly UserDbContext userDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginRepositoryImpl"/> class.
        /// </summary>
        /// <param name="userDbContext">The user database context.</param>
        public ImpLoginRepo(UserDbContext userDbContext)
        {
            this.userDbContext = userDbContext;
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns>
        /// It return 1 if user added successfully
        /// </returns>
        public Task<int> AddUser(User user)
        {
            var encriptPWd = EncriptAndDecript.base64Encode(user.Password);
            user.Password = encriptPWd;
            this.userDbContext.Users.Add(user);
            var result = this.userDbContext.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Logins the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// It return true if Login successful.
        /// </returns>u
        public bool Login(User userChanges)
        {
            var decriptPWD = EncriptAndDecript.base64Decode(userChanges.Password);
            var result = this.userDbContext.Users.Where(id => id.Email == userChanges.Email && id.Password == userChanges.Password).FirstOrDefault();
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


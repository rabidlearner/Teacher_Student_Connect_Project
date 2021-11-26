﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Data;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;

        public UserRepository(IMapper mapper, ApplicationDbContext dbContext)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;
        }

        public void ChangePassword(ChangePasswordViewModel model)
        {
            User user = new User();
            user = dbContext.Users.FirstOrDefault(m => m.UserId == model.UserId);
            user.Password = model.Password;
            dbContext.Users.Update(user);
            dbContext.SaveChanges();

        }

        public string GetRole(string userId)
        {
            User user = new User();
            user = dbContext.Users.FirstOrDefault(m => m.UserId == userId);
            return user.Role;
        }

        public string GetUserId(ForgotUserIdViewModel model)
        {
            User user = new User();
            user = dbContext.Users.FirstOrDefault(m => m.PhoneNumber == model.PhoneNumber
            );
            if (user != null)
            {
                if (user.Answer1 == model.Answer1 && user.Answer2 == model.Answer2 && user.Answer3 == model.Answer3)
                {
                    return user.UserId;
                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }
        }

        public bool IsCorrect(ForgotPasswordViewModel model)
        {
            User user = new User();
            user = dbContext.Users.FirstOrDefault(m => m.UserId == model.UserId);

            if (user != null)
            {
                if (user.Answer1 == model.Answer1 && user.Answer2 == model.Answer2 && user.Answer3 == model.Answer3)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public string PostUser(UserViewModel userViewModel)
        {
            User user = new User();
            user = mapper.Map<User>(userViewModel);

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

            return user.UserId;

        }

        public bool UserExists(string userId)
        {
            User user = new User();
            user = dbContext.Users.FirstOrDefault(m => m.UserId == userId);
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UserExists(string userId, string password)
        {
            User user = new User();
            user = dbContext.Users.FirstOrDefault(m => m.UserId == userId && m.Password == password);
            if (user != null)
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

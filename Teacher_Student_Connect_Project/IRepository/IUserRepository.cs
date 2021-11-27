using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.IRepository
{
    public interface IUserRepository
    {
        string PostUser(UserViewModel userViewModel);
        bool UserExists(string userId);
        bool UserExists(string userId, string password);
        string GetRole(string userId);
        List<User> GetUsers();
        string GetUserId(ForgotUserIdViewModel model);
        bool IsCorrect(ForgotPasswordViewModel model);
        void ChangePassword(ChangePasswordViewModel model);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IControllerServices;

namespace Teacher_Student_Connect_Project.ControllerServices
{
    public class UserServices : IUserServices
    {
        public string GetUserId(string name, string phoneNumber)
        {
            return name.Substring(0, 3) + phoneNumber.Substring(0, 3);
        }
    }
}

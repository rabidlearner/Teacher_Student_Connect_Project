using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teacher_Student_Connect_Project.IControllerServices
{
    public interface IUserServices
    {
        string GetUserId(string name, string phoneNumber);
    }
}

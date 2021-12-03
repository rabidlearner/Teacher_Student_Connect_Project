using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.IControllerServices
{
    public interface IAdminServices
    {
        AdminViewModel Create();
        void PostAdmin(AdminViewModel admin);
        List<AdminDataViewModel> GetAdmins(int id);
        //AddDocuments GetDocuments();
        void PostAddDocuments(AddDocuments addDocuments);
    }
}

using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.IControllerServices;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.ControllerServices
{
    public class AdminServices:IAdminServices
    {
        private readonly IAdminRepository adminRepository;
        private readonly IUserRepository userRepository;
        private readonly IDocumentRepository documentRepository;
        private readonly IMapper mapper;
        public AdminServices(IUserRepository userRepository,IAdminRepository adminRepository,IMapper mapper,IDocumentRepository documentRepository)
        {
            this.mapper = mapper;
            this.adminRepository = adminRepository;
            this.userRepository = userRepository;
            this.documentRepository = documentRepository;
        }
        /* public AddDocuments GetDocuments()
         {
             AddDocuments addDocuments = new AddDocuments();
             addDocuments.Admin = 
         }*/
        public void PostAddDocuments(AddDocuments addDocuments)
        {
            Document document = new Document();
            document = mapper.Map<Document>(addDocuments);
            adminRepository.PostAddDocuments(document);
        }
        public AdminViewModel Create()
        {
            AdminViewModel adminModel = new AdminViewModel();
            adminModel.DocumentList = documentRepository.GetDocuments();
            return adminModel;
        }
        public List<AdminDataViewModel> GetAdmins(int id)
        {
            List<AdminDataViewModel> adminDataViewModels = new List<AdminDataViewModel>();
            Admin admin = new Admin();
            admin = adminRepository.GetAdminByUserId(id);
            Document document = new Document();
            document = documentRepository.GetDocument(document.Id);
            User user = new User();
            user = userRepository.GetUserById(id);

            AdminDataViewModel adminData = new AdminDataViewModel()
            {
                Id = admin.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Dob = user.Dob,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
                Website = user.Email,
            };
            adminDataViewModels.Add(adminData);
            return adminDataViewModels;
        }
        public void PostAdmin(AdminViewModel adminViewModel)
        {
            Admin admin = new Admin();

            admin = mapper.Map<Admin>(adminViewModel);
            adminRepository.PostAdmin(admin);
        }
    }
}

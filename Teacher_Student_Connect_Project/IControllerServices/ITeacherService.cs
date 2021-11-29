using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.ViewModels;

namespace Teacher_Student_Connect_Project.IControllerServices
{
    public interface ITeacherServices
    {
        TeacherViewModel Create();
        void PostTeacher(TeacherViewModel teacher);
        List<TeacherDataViewModel> GetTeachers();
    }
}

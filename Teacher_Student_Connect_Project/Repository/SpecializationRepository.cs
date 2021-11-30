using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Data;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.Repository
{
    public class SpecializationRepository: ISpecializationRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;
        public SpecializationRepository(IMapper mapper, ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public List<Specialization> GetSpecializations()
        {
            List<Specialization> specializations = new List<Specialization>();
            specializations = dbContext.Specializations.ToList();
            return specializations;

        }
        public Specialization GetSpecialization(int id)
        {
            Specialization specialization = new Specialization();
            specialization = dbContext.Specializations.FirstOrDefault(m => m.Id == id);
            return specialization;
        }
        public void PostSpecializations(Specialization specialization)
        {
            dbContext.Specializations.Add(specialization);
            dbContext.SaveChanges();
        }
    }
}

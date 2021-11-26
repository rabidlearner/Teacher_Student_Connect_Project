﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Data;
using Teacher_Student_Connect_Project.IRepository;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.Repository
{
    public class BatchRepository:IBatchRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;
        public BatchRepository(IMapper mapper, ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public List<Batch> GetBatches()
        {
            List<Batch> batches = new List<Batch>();
            batches = dbContext.Batches.ToList();
            return batches;

        }
        public Batch GetBatches(int id)
        {
            Batch batch= new Batch();
            batch = dbContext.Batches.FirstOrDefault(m => m.Id == id);
            return batch ;
        }
        public void PostBatches(Batch batch)
        {
            dbContext.Batches.Add(batch);
            dbContext.SaveChanges();
        }
    }
}

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
    public class DocumentRepository:IDocumentRepository
    {
        private readonly IMapper mapper;
        private readonly ApplicationDbContext dbContext;
        public DocumentRepository(IMapper mapper, ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public List<Document> GetDocuments()
        {
            List<Document> documents = new List<Document>();
            documents = dbContext.Documents.ToList();
            return documents;
        }
        public Document GetDocument(int id)
        {
            Document document= new Document();
            document = dbContext.Documents.FirstOrDefault(m => m.Id == id);
            return document;
        }
        public void PostDocuments(Document document)
        {
            dbContext.Documents.Add(document);
            dbContext.SaveChanges();
        }
       
    }
    
}

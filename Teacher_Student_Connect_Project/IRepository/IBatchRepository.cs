using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teacher_Student_Connect_Project.Models;

namespace Teacher_Student_Connect_Project.IRepository
{
    public interface IBatchRepository
    {
        List<Batch> GetBatches();
        Batch GetBatch(int id);
        void PostBatches(Batch batch);
    }
}

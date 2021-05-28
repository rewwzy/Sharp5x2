using CSharp5Lap45.Data.EF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5Lap45.Service.IServices
{
    public interface IClassService 
    {
        Task<List<FClass>> GetAllClassModel();
        Task<bool> IsValid(int id);
        Task<FClass> Detail(int id);
        Task<int> Edit(FClass fStudent);
        Task<int> Add(FClass fStudent);
        Task<int> Delete(FClass fStudent);
    }
}

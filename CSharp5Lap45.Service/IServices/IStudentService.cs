using CSharp5Lap45.Data.EF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5Lap45.Service.IServices
{
    public interface IStudentService
    {
        Task<List<FClass>> GetAllClassModel();
        Task<List<FStudent>> GetAllStudenModel();
        Task<bool> IsValid(int id);
        Task<FStudent> Detail(int id);
        Task<int> Edit(FStudent fStudent);
        Task<int> Add(FStudent fStudent);
        Task<int> Delete(FStudent fStudent);
    }
}

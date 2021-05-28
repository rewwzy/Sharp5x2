using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET105_Tutorial_DI_DepedencyInjection.Services.Services
{
    public class StudentService : IServices.IStudentService
    {
        public List<Dtos.StudentModel> GetAllStudents()
        {
            return new List<Dtos.StudentModel>
            {
                new Dtos.StudentModel { ID=1,Msv="PH100329",Ten="Nguyễn Văn A"},
                new Dtos.StudentModel { ID=2,Msv="PH100123",Ten="Nguyễn Văn B"},
                new Dtos.StudentModel { ID=3,Msv="PH100442",Ten="Nguyễn Văn C"},
                new Dtos.StudentModel { ID=4,Msv="PH100512",Ten="Nguyễn Văn D"},
                new Dtos.StudentModel { ID=5,Msv="PH100662",Ten="Nguyễn Văn E"},
                new Dtos.StudentModel { ID=6,Msv="PH100578",Ten="Nguyễn Văn F"}
            };
        }
    }
}

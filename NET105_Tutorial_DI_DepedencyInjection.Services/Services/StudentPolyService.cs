using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET105_Tutorial_DI_DepedencyInjection.Services.Services
{
    public class StudentPolyService : IServices.IStudentService
    {
        public List<Dtos.StudentModel> GetAllStudents()
        {
            return new List<Dtos.StudentModel>
            {
                new Dtos.StudentModel { ID=1,Msv="PH100329",Ten="Nguyễn Văn X"},
                new Dtos.StudentModel { ID=2,Msv="PH100123",Ten="Nguyễn Văn M"},
                new Dtos.StudentModel { ID=3,Msv="PH100442",Ten="Nguyễn Văn N"},
                new Dtos.StudentModel { ID=4,Msv="PH100512",Ten="Nguyễn Văn L"},
                new Dtos.StudentModel { ID=5,Msv="PH100662",Ten="Nguyễn Văn O"},
                new Dtos.StudentModel { ID=6,Msv="PH100578",Ten="Nguyễn Văn P"}
            };
        }
    }
}

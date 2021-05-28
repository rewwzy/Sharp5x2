using CSharp5Lap45.Data.EF.DBContext;
using CSharp5Lap45.Data.EF.Entity;
using CSharp5Lap45.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5Lap45.Service.Services
{
    public class StudentService : IStudentService
    {
        public DBContextFPOLY _context;
        public StudentService(DBContextFPOLY contextFPOLY)
        {
            _context = contextFPOLY;
        }
        public Task<List<FClass>> GetAllClassModel()
        {
            List<FClass> classes = new List<FClass>();
            var data = _context.FClasses.ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    classes.Add(item);
                }
            }
            return Task.FromResult(classes);
        }

        public Task<List<FStudent>> GetAllStudenModel()
        {
            List<FStudent> classes = new List<FStudent>();
            var data = _context.FStudents.ToList();
            if (data != null)
            {
                foreach (var item in data)
                {
                    classes.Add(item);
                }
            }
            return Task.FromResult(classes);
        }
        public async Task<bool> IsValid(int id)
        {
            FStudent data =  _context.FStudents.Where(x=>x.StId == id).FirstOrDefault();
            if(data!= null)
            {
                return true;
            }
            return false;
        }
        public async Task<FStudent> Detail(int id)
        {
            FStudent result = _context.FStudents.Where(x => x.StId == id).FirstOrDefault();
            return result;
        }
        public async Task<int> Edit(FStudent fStudent)
        {
            try
            {
                _context.FStudents.Update(fStudent);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<int> Add(FStudent fStudent)
        {
            try
            {
                _context.FStudents.Add(fStudent);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<int> Delete(FStudent fStudent)
        {
            try
            {
                _context.FStudents.Remove(fStudent);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}

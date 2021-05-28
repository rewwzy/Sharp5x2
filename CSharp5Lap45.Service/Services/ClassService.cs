using CSharp5Lap45.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp5Lap45.Data.EF.DBContext;
using CSharp5Lap45.Data.EF.Entity;
using Microsoft.EntityFrameworkCore;

namespace CSharp5Lap45.Service.Services
{
    public class ClassService : IClassService
    {
        private DBContextFPOLY _context;
        public ClassService(DBContextFPOLY contextFPOLY)
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
        public async Task<bool> IsValid(int id)
        {
            FClass data = _context.FClasses.Where(x => x.IdClass == id).FirstOrDefault();
            if (data != null)
            {
                return true;
            }
            return false;
        }
        public async Task<FClass> Detail(int id)
        {
            FClass result = _context.FClasses.Where(x => x.IdClass == id).FirstOrDefault();
            return result;
        }
        public async Task<int> Edit(FClass fClass)
        {

            try
            {
                _context.FClasses.Update(fClass);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<int> Add(FClass fClass)
        {
            try
            {
                _context.FClasses.Add(fClass);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<int> Delete(FClass fclass)
        {

            try
            {
                _context.FClasses.Remove(fclass);
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

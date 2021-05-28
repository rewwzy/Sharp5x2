using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5Lap45.Data.EF.Entity
{
    public class FClass
    {
        public int IdClass { get; set; }
        public string NameClass { get; set; }
        public List<FStudent> FStudents { get; set; }
    }
}


namespace CSharp5Lap45.Data.EF.Entity
{
    public class FStudent
    {
        public int StId { get; set; }
        public string Name { get; set; }
        public float Mark { get; set; }
        public string Email { get; set; }
        public int IdClass { get; set; }
        public FClass FClass { get; set; }
    }
}

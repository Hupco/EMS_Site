using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Training
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

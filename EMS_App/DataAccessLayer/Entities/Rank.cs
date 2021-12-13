using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class Rank
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public int StudentName { get; set; }
        public int Address { get; set; }
    }
}
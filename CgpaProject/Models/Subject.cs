using System.ComponentModel.DataAnnotations;

namespace CgpaProject.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string SubjectName { get; set; }
    }
}

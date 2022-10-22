using System.ComponentModel.DataAnnotations;

namespace CgpaProject.Models
{
    public class SecondSubject
    {
        [Key]
        public int Id { get; set; }
        public string SecondSubjectName { get; set; }
    }
}


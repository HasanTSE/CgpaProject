using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CgpaProject.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
       
        [Display(Name = "Student Serial-Number")]
        public string SerialNumber { get; set; }
        
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }



        [Display(Name = "First Subject")]
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }



        // public string FirstSubject { get; set; }
        [Display(Name = "Number")]
        public decimal? FirstNumber { get; set; } = 0;

        [Display(Name = "Grade")]
        public string FirstNumberGrade { get; set; }

        [Display(Name = "Point")]
        public decimal? FirstNumberPoint { get; set; } = 0;

        [Display(Name = "Second Subject")]
        public int SecondSubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public SecondSubject? SecondSubject { get; set; }
        //  public string SecondSubject { get; set; }

        [Display(Name = "Number")]
        public decimal? SecondNumber { get; set; } = 0;

        [Display(Name = "Grade")]
        public string SecondNumberGrade { get; set; }

        [Display(Name = "Point")]
        public decimal? SecondNumberPoint { get; set; } = 0;


        [Display(Name = "Total Number")]
        public decimal? TotalNumber { get; set; } = 0;
        [Display(Name = "Total Point Average")]
        public decimal? TotalPoint { get; set; } = 0;
        [Display(Name = "Total Grade Average")]
        public string TotalGrade { get; set; }
        public string Status { get; set; }
    }
}

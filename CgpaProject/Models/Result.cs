using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CgpaProject.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string StudentName { get; set; }


      
        
        public int SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }

         

       // public string FirstSubject { get; set; }

        public decimal? FirstNumber { get; set; }

        public string FirstNumberGrade { get; set; }

        public decimal? FirstNumberPoint { get; set; }


        public int SecondSubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public SecondSubject? SecondSubject { get; set; }
        //  public string SecondSubject { get; set; }

        public decimal? SecondNumber { get; set; }

        public string SecondNumberGrade { get; set; }

        public decimal? SecondNumberPoint { get; set; }



        public decimal? TotalNumber { get; set; }
        public decimal? TotalPoint { get; set; }
        public string TotalGrade { get; set; }
        public string Status { get; set; }
    }
}

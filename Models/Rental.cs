using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Video.Models
{
    public class Rental
    {
        [Key]
        public string RentalID { get; set; }

        // MemberID FK 
        public string? MemberID { get; set; }
        [ForeignKey("MemberID")] // fk declaration 
        public Member? Member { get; set; }  // parent table 


        // movie ID fk 
        public string? MovieID { get; set; }
        [ForeignKey("MovieID")]
        public Movie? Movie { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRented { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReturned { get; set; }
    }
}
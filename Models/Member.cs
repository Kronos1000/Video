using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Video.Models
{
    public class Member
    {
        [Key] // Primary Key declaration  
        public string MemberID { get; set; }

        // FK Realations 
        public List<Member>? Members { get; set; }

        [Required, MaxLength(40)]
        public string FirstName { get; set; }

        [Required, MaxLength(40)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        public string? MobileNumber { get; set; }


        [Required, EmailAddress]
        public string Email { get; set; }


    }
}

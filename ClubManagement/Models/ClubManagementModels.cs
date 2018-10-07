using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClubManagement.Models
{
    public class ClubCenter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClubCenterId { get; set; }

        public string Location { get; set; }

        public Club Club { get; set; }
    }

    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClubId { get; set; }

        public string ClubName { get; set; }

        public DateTime OpenDate { get; set; }

        [Required]
        public ClubCenter ClubCenter { get; set; }
        
        public ICollection<Membership> Memberships { get; set; }
        public ICollection<Manager> Managers { get; set; }
    }

    public class Manager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ManagerId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Phone { get; set; }
        
        public ICollection<Club> Clubs { get; set; }
    }

    public class Membership
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MembershipId { get; set; }

        public int ClubId { get; set; }

        public int PersonId { get; set; }

        public DateTime ExpireDate { get; set; }

        public decimal RegistrationFee { get; set; }

        [Required]
        public Person Person { get; set; }

        [Required]
        public Club Club { get; set; }
    }

    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        public String LastName { get; set; }

        public String FirstName { get; set; }

        public String Phone { get; set; }

        public String Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        [ForeignKey("MembershipId")]
        public ICollection<Membership> Memberships { get; set; }
    }
}
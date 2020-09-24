using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
    public class Coach
    {
        public int id { get; set; }
        [Key]
        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "UserName")]
        public String UserName { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Pasword")]
        public String Password { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Name")]
        public String Name { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Age")]
        public String Age { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Email")]
        public String Email { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Phone")]
        public String Phone { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Address")]
        public String Address { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Designation")]
        public String Designation { get; set; }

        [ Display(Name = "Salary")]
        public Double Salary { get; set; }

        [Column(TypeName = "varchar"), StringLength(200), Display(Name = "Image")]
        public String Image { get; set; }

        //public IEnumerable<Notification> Notications { get; set; }

       

        public Admin SignUp { get; set; }

    }
}
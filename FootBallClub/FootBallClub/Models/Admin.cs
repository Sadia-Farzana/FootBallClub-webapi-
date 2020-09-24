using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
    public class Admin
    {
        public int id { get; set; }
      
        [Key]
        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name can not be empty")]
        public string userName { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Name")]
        [Required(ErrorMessage = "Name can not be empty")]
        public string name { get; set; }

        [Column(TypeName = "varchar"), StringLength(11), Display(Name = "Password")]
        [Required(ErrorMessage = "Password can not be empty")]
        public string password { get; set; }

        

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Email")]
        [Required(ErrorMessage = "Email can not be empty")]
        public string email { get; set; }


        [Column(TypeName = "int"), Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone can not be empty")]
        public int phone { get; set; }

        [ Display(Name = "Salary")]

        public double salary { get; set; }


        [Column(TypeName = "varchar"), Display(Name = "Image")]
        public string image { get; set; }

    }
}
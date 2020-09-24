using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FootBallClub.Models
{
    public class Player
    {
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

        [Column(TypeName = "int"), Display(Name = "Age")]
        [Required(ErrorMessage = "Age can not be empty")]
        public int age { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Email")]
        [Required(ErrorMessage = "Email can not be empty")]
        public string email { get; set; }


        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Address")]
        [Required(ErrorMessage = "Address can not be empty")]
        public string address { get; set; }

        [Column(TypeName = "int"), Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone can not be empty")]
        public int phone { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Position")]
        [Required(ErrorMessage = "Position can not be empty")]
        public string position { get; set; }


        [Column(TypeName = "float"), Display(Name = "Salary")]
        [Required(ErrorMessage = "Salary Fees can not be empty")]
        public int salary { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Type")]
        [Required(ErrorMessage = "Type can not be empty")]
        public string type { get; set; }

        [Column(TypeName = "varchar"), Display(Name = "Image")]
        public string image { get; set; }
    }
}
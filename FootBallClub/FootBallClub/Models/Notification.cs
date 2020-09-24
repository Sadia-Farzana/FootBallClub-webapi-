using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
    public class Notification
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "Title")]
        public string title { get; set; }

        [Column(TypeName = "varchar"), StringLength(50)]

        public string description { get; set; }

        [Column(TypeName = "varchar"), StringLength(50), Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name can not be empty")]
        public string userName { get; set; }

        public DateTime date { get; set; }

        //public Player Player { get; set; }

    }
}
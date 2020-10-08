using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Requests
{
    public class KupacInsertRequest
    {
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public string BrojMobitela { get; set; }

        [Required]
        public int GradId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

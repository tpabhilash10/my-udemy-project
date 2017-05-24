using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VandanamVillas.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter your Name")]
        [StringLength(200)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Email")]
        [EmailAddress(ErrorMessage = "Invalid Email ID")]
        [StringLength(200)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Mobile No.")]
        [StringLength(15)]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Please select Check in Date")]
        [Display(Name = "Check in Date")]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "Please enter Number of Days")]
        [Display(Name = "Number of Days")]
        public int NumberofDays { get; set; }

        [Required(ErrorMessage = "Please enter your Requirements")]
        public string  Message { get; set; }

        [Required]
        public DateTime CDate { get; set; }

    }
}
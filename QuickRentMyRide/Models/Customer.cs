﻿using System.ComponentModel.DataAnnotations;

namespace QuickRentMyRide.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string Full_Name { get; set; }

        public string Phone_Number { get; set; }

        public string Address { get; set; }

        public string DOB { get; set; }

        public string License_Photo { get; set; }

        public string IC_Number { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}

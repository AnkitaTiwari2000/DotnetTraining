﻿using System.ComponentModel.DataAnnotations;

namespace ContactAPI.Model
{
    public class Contact
    {
      
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


    }
}

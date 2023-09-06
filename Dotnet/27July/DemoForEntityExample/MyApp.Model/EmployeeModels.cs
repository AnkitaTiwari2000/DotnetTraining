﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Model
{
    public class EmployeeModels
    {
       
            public int id { get; set; }
        [Required]
            public string FirstName { get; set; }
        [Required]
            public string LastName { get; set; }
        [EmailAddress]
            public string Email { get; set; }
            public int? AddressId { get; set; }
        [Required]
            public string Code { get; set; }

            public  AddressModel Address { get; set; }
        }
    }


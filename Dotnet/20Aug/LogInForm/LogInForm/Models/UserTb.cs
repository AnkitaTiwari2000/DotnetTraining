﻿using System;
using System.Collections.Generic;

namespace LogInForm.Models
{
    public partial class UserTb
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}

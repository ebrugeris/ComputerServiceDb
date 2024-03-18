﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDb.Models
{
    public class Staff:BaseModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Position { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime? StartDate { get; set; }
    }
}

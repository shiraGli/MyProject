﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class LoginDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.CodeFirst.Models
{
    public class Cover
    {
        public int Id { get; set; }
        public Course Course { get; set; }
    }
}

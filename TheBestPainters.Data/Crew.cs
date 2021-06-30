﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    public class Crew
    {
        [Key]
        public int CrewId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string CrewName { get; set; }
        public virtual List<Job> Jobs { get; set; } = new List<Job>();
    }
}
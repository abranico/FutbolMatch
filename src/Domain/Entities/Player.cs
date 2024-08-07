﻿using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Player : User
    {        
        public string? Description { get; set; }
        public PreferredFoot? PreferredFoot {  get; set; }
        public Position? Position { get; set; }
        public ICollection<Team> Teams { get; set; } = new List<Team>();
        public bool isCaptain { get; set; } = false;
    }
}

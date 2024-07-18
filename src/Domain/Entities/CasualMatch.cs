﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CasualMatch : Match
    {
        public int Admin {  get; set; }
        public string JoinCode {  get; set; }
        public List<string> Players { get; set; } = new List<string>();
        public bool Open { get; set; } = true;
    }
}





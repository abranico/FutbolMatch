﻿using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string? Picture { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public bool IsPremium { get; set; } = false;
        public Role Role { get; set; }

    }
}

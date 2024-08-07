﻿using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CasualMatchDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Schedule { get; set; }
        public string MatchFormat { get; set; }
        public string MatchMode { get; set; }
        public string Admin { get; set; }
        public string JoinCode { get; set; }
        public List<string> Players { get; set; }
        public bool Open { get; set; }

        public static CasualMatchDto FromEntity(CasualMatch match)
        {
            return new CasualMatchDto
            {
                Id = match.Id,
                Name = match.Name,
                Country = match.Country,
                City = match.City,
                Schedule = match.Schedule.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("es-ES")),
                MatchFormat = match.MatchFormat.ToString(),
                MatchMode = match.MatchMode.ToString(),
                Admin = match.Admin.Username,
                JoinCode = match.JoinCode,
                Players = match.Players.Select(p => p.Username).ToList(),
                Open = match.Open
            };
        }
    }
}

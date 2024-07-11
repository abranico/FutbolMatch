﻿using Application.Models.Requests;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICasualMatchService
    {
        List<CasualMatch> GetAll();
        CasualMatch? GetById(int id);
        CasualMatch Create(CasualMatchCreateRequest request, Player player);
        void Delete(int id);
        string GenerateRandomCode(int length);
    }
}
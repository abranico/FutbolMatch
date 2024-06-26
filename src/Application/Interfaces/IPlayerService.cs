﻿using Application.Models.Requests;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPlayerService
    {
        List<Player> GetAll();
        Player? GetById(int id);
        Player Create(PlayerCreateRequest request);
        void Update(int id, PlayerUpdateRequest request);
        void Delete(int id);
    }
}
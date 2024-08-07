﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ILeagueRepository : IRepositoryBase<League>
    {
        League? GetByJoinCode(string code);
    }
}

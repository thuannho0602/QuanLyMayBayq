﻿using DoAnCB.DataAccess;
using DoAnCB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCB.Repository.Implementations
{
    public class MayBayRepository : RepositoryBase<MayBay, ApplicationDbContext>, IMayBayRepository
    {
        public MayBayRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

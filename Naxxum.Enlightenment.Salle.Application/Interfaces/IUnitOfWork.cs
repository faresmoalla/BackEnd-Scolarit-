﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.Enlightenment.Salle.Application.Interfaces;
public interface IUnitOfWork
{
    Task<int> SaveChangesAsync();
}

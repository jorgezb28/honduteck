﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Honduteck.Models;
using Honduteck._1._1_Domain.Repositories.Generic;
using Honduteck._1._2_Infraestructure;

namespace Honduteck._1._1_Domain.Repositories.EntitiesRepositories
{
    public class PrestamoRepository : Repository<Prestamo> ,IPrestamoRepository
    {
        public PrestamoRepository(IUnitofWork unitofWork):base(unitofWork)
        {
            
        }
    }
}

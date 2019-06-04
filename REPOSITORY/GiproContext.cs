using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace REPOSITORY
{
    public class GiproContext
    {
        public GiproContext(DbContextOptions<GiproContext> options) :
            base(options)
            {

            }



    }
}

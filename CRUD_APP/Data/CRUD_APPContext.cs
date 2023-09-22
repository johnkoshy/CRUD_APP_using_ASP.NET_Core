using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_APP.Model;

namespace CRUD_APP.Data
{
    public class CRUD_APPContext : DbContext
    {
        public CRUD_APPContext (DbContextOptions<CRUD_APPContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_APP.Model.User> User { get; set; } = default!;
    }
}

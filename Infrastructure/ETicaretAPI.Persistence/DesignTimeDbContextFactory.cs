using ETicaretAPI.Persistence.Contex;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    {
        public ETicaretAPIDbContext CreateDbContext(string[] args)
        {
            //DesignTime sınıfı PowerShell üzerinden migration yapmak için gereklidir. PMC üstünden migration yapılıyorsa gerek yok.

            DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
            //dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);

            return new(dbContextOptionsBuilder.Options);
        }
    }
}

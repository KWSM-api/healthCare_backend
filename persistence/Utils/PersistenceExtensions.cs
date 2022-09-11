using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persistence.Utils
{
    public static class PersistenceExtensions
    {

        public static void AddAppDbContext(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AppDbContext>(
                 options => options.UseSqlServer("Server=DESKTOP-6H6EI1H\\SQLEXPRESS;Database=healthCare;Trusted_Connection=True;MultipleActiveResultSets=true")
                ) ;
        }


    }
}

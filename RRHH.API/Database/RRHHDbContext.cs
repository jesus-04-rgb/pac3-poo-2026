using Microsoft.EntityFrameworkCore;
using RRHH.API.Entities;

namespace RRHH.API.Database
{
    public class RRHHDbContext : DbContext
    {
        public RRHHDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<EmployeeEntity> Employees { get; set; }

       public DbSet<FeedbackTypeEntity>? FeedbackTypes { get; set; }
        
        public DbSet<FeedbackEntity>? Feedbacks { get; set; }
    }

   
}
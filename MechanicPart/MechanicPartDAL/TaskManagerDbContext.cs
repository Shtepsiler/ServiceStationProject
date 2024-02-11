using MechanicPartDAL.Config;
using MechanicPartDAL.Entitys;
using Microsoft.EntityFrameworkCore;

namespace MechanicPartDAL
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> contextOptions) : base(contextOptions)
        {
            Database.EnsureCreated();
        }


        public DbSet<Job> Jobs { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<MechanicsTasks> MechanicsTasks { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new JobConfiguration());
            modelBuilder.ApplyConfiguration(new MechanicConfiguration());
            modelBuilder.ApplyConfiguration(new MechanicsTasksConfiguration());


        }

    }
}

using DeviceInfoAPI;
using Microsoft.EntityFrameworkCore;

namespace DATA
{
    public class DeviceContext : DbContext
    {

        public DeviceContext(DbContextOptions<DeviceContext> options) 
            :base(options)
        {
            
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Partition> Partitions { get; set; }
        public DbSet<ProcessInfo> ProcessInfos { get; set; }
        public DbSet<ProcessInfoDetails>   ProcessInfoDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
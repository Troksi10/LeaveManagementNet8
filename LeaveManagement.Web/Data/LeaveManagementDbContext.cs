using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace LeaveManagement.Web.Data
{
    public class LeaveManagementDbContext : DbContext
    {
        public LeaveManagementDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}

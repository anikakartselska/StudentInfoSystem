using System.Data.Entity;

namespace UserLogin
{
    public class LogsContext : DbContext
    {
        public DbSet<Logs> Logs { get; set; }

        public LogsContext() : base(Properties.Settings.Default.DbConnect)
        {
        }
    }
}
namespace ArchiveApp.DataAccess
{
    using ArchiveApp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AppContext : DbContext
    {
        public AppContext()
            : base("name=AppContext")
        {
        }
        
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
    }

}
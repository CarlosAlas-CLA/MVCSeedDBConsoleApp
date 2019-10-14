using System.Data.Entity;

namespace ContactSInformation
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ContactManagerCustomerInfo")
        {
            Database.SetInitializer<DatabaseContext>(new CreateDatabaseIfNotExists<DatabaseContext>());
            Database.SetInitializer<DatabaseContext>(new DropCreateDatabaseIfModelChanges<DatabaseContext>());


        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EmailAddresses> EmailAddresses { get; set; }

    }


}

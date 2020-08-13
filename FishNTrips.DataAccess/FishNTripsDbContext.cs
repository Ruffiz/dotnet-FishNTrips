using System;
using System.Data.SqlClient;

using FishNTrips.Model;

using Microsoft.EntityFrameworkCore;

namespace FishNTrips.DataAccess
{

    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class FishNTripsDbContext : DbContext
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FishNTripsDbContext"/> class.
        /// </summary>
        public FishNTripsDbContext() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FishNTripsDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public FishNTripsDbContext(DbContextOptions<FishNTripsDbContext> options) : base(options) { }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        public DbSet<Comment> Comments { get; set; }
        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        /// <value>
        /// The locations.
        /// </value>
        public DbSet<Location> Locations { get; set; }
        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public DbSet<Image> Images { get; set; }

        /// <summary>
        /// <para>
        /// Override this method to configure the database (and other options) to be used for this context.
        /// This method is called for each instance of the context that is created.
        /// The base implementation does nothing.
        /// </para>
        /// <para>
        /// In situations where an instance of <see cref="T:Microsoft.EntityFrameworkCore.DbContextOptions" /> may or may not have been passed
        /// to the constructor, you can use <see cref="P:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured" /> to determine if
        /// the options have already been set, and skip some or all of the logic in
        /// <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" />.
        /// </para>
        /// </summary>
        /// <param name="optionsBuilder">A builder used to create or modify options for this context. Databases (and other extensions)
        /// typically define extension methods on this object that allow you to configure the context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {

                DataSource = "(localdb)\\MSSQLLocalDB",
                //DataSource = "Donau.hiof.no",
                UserID = "Ruffy",
                Password = "Dockport1",
                InitialCatalog = "FishNTripsDBOne",
                MultipleActiveResultSets = true,
                IntegratedSecurity = true,
                //ConnectionString = "server=donau.hiof.no;database=rolfhk;user=rolfhk;password=F2nLww6S",
                ConnectionString = "server=localhost;port=3306;database=fishntripsdbone;user=Ruffy;password=Dockport1",

            };

            optionsBuilder.UseSqlServer(builder.ConnectionString.ToString());
        }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Location)
                .WithMany(l => l.Comments)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Image>()
                .HasOne(i=>i.LocationImg)
                .WithMany(l => l.ImageUrl);
        }
    }
}

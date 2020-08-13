using System;
using System.Linq;

using FishNTrips.DataAccess;
using FishNTrips.Model;

namespace FishNTrips.DatabaseMigrate.ConsoleApp
{
    class Program
    {
        //Made a test user for when setting up database..
        static void Main(string[] args)
        {
            User kanon = new User
            {
                UserName = "kanon",
                UserPassword = "kula"
            };

            using (var db = new FishNTripsDbContext()) {
                db.Users.Add(kanon);
                db.SaveChanges();
            }
        }
    }
}

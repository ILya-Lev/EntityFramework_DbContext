using Model;
using System;
using System.Data.Entity;
using System.Diagnostics;

namespace DataAccess
{
	public class BreakAwayContext : DbContext
	{
		public DbSet<Destination> Destinations { get; set; }
		public DbSet<Lodging> Lodgings { get; set; }
		public DbSet<Trip> Trips { get; set; }
		public DbSet<Person> People { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<Activity> Activities { get; set; }

		public BreakAwayContext() : base("BreakAwayDatabase")
		{
			Database.Log = Console.WriteLine;
			Database.Log += message => Debug.WriteLine(message);
		}
	}
}
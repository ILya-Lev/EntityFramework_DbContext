﻿using System.Data.Entity;
using DataAccess;

namespace BreakAwayConsole
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Database.SetInitializer(new InitializeBagaDatabaseWithSeedData());

			// Call the latest example method here

			// NOTE: Some examples will change data in the database. Ensure that you only call the
			//       latest example method. The InitializeBagaDatabaseWithSeedData database initializer
			//       (registered above) will take care of resetting the database before each run.
		}

		// Add example methods here
	}
}
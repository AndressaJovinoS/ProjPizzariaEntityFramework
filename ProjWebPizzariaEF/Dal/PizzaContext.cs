using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjWebPizzariaEF.Models;

namespace ProjWebPizzariaEF.Dal
{
	public class PizzaContext : DbContext
	{
		public PizzaContext() : base("PizzaContext")
		{
		}

		public DbSet<Pizza> Pizzas { get; set; }
	}
}
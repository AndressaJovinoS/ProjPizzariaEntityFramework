using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjWebPizzariaEF.Models;

namespace ProjWebPizzariaEF.Dal
{
	public class PizzaInitializer : DropCreateDatabaseIfModelChanges<PizzaContext>
	{
		protected override void Seed(PizzaContext context)
		{
			var pizzas = new List<Pizza>
			{
				new Pizza{Id = 1, Descricao = "Moda da Casa", Valor = 50},
				new Pizza{Id = 2, Descricao = "Nordestina", Valor = 45},
			};
			pizzas.ForEach(p => context.Pizzas.Add(p));
			context.SaveChanges();
		} 
	}
}
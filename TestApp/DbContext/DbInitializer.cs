using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestApp.Models;

namespace TestApp {
	public class DbInitializer : DropCreateDatabaseIfModelChanges<AppContext> {

		protected override void Seed(AppContext context) {
			base.Seed(context);
			context.Todos.Add(new TodoItem { Content = "Todo1 Content", Title = "Todo1" });
			context.Todos.Add(new TodoItem { Content = "Todo2 Content", Title = "Todo2" });
			context.Todos.Add(new TodoItem { Content = "Todo3 Content", Title = "Todo3" });
			context.Todos.Add(new TodoItem { Content = "Todo4 Content", Title = "Todo4" });
			context.Todos.Add(new TodoItem { Content = "Todo5 Content", Title = "Todo5" });
			context.Todos.Add(new TodoItem { Content = "Todo6 Content", Title = "Todo6" });
			context.SaveChanges();
		}

	}
}
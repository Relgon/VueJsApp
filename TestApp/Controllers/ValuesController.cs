using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApp.Models;

namespace TestApp.Controllers {
	public class TodosController : ApiController {

		private AppContext _db;

		public TodosController() {
			_db = new AppContext();
		}
		// GET api/values
		public IEnumerable<TodoItem> Get() {
			return _db.Todos;
		}

		// GET api/values/5
		public TodoItem Get(int id) {
			var todo = _db.Todos.SingleOrDefault(t => t.Id == id);
			return todo ?? null;
		}

		// POST api/values
		public void Post([FromBody]TodoItem todoItem) {
			_db.Todos.Add(todoItem);
			_db.SaveChanges();
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]TodoItem item) {
			var todo = _db.Todos.SingleOrDefault(t => t.Id == item.Id);
			if (todo != null) {
				todo.Content = item.Content;
				todo.Title = item.Title;
				_db.SaveChanges();
			}
		}

		// DELETE api/values/5
		public void Delete(int id) {
			var todo = _db.Todos.SingleOrDefault(t => t.Id == id);
			_db.Todos.Remove(todo);
		}
	}
}

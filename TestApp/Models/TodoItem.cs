using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models {
	public class TodoItem : BaseModel {

		public string Title { get; set; }
		public string Content { get; set; }
	}
}
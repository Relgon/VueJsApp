Vue.component('detailsDisplay', {
	template: '#details-template'
});

var app = new Vue({
	el: '#app',
	data: {
		todos: [
			{ id: 1, title: 'todo1', content: 'todo 1 content', showDetails: false },
			{ id: 2, title: 'todo2', content: 'todo 2 content', showDetails: true },
			{ id: 3, title: 'todo3', content: 'todo 3 content', showDetails: false }
		]
	},
	methods: {
		getShowDetails: function(id) {
			var todo = this.todos.filter(function(elem) {
				return elem.id === id;
			});
			return todo.showDetails;
		},
		togleShowDetails: function(id) {
			var todo = this.todos.find(function(elem) {
				return elem.id === id;
			});
			todo.showDetails = !todo.showDetails;
		}
	}
});


new Vue({
	el: '#app',
  data: {
  	hello: 'Hello, World!',
    message: 'Message',
  	title: 'Title',
    link: 'http://google.com',
    finishedLink: '<a href="http://google.com">Google</a>'
  },
  methods: {
  	changeMessage: function(event) {
    	this.message = event.target.value;
    },
    sayHello: function() {
    	return this.hello;
    }
  }
});

new Vue({
	el: '#exercise',
  data: {
  	name: 'Ryan',
    age: 26,
    kitten: 'https://www.pets4homes.co.uk/images/articles/1646/large/kitten-emergencies-signs-to-look-out-for-537479947ec1c.jpg'
  },
  methods: {
  	multiplyAge: function() {
    	return this.age * 3;
    },
    randomFloat: function() {
    	return Math.floor(Math.random() * 101);
    },
    changeName: function() {
    	this.name = event.target.value;
    }
  }
});
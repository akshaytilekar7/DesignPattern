/*
 
 HTTP Request

	Client	   
			Http Req
				GET/api/evemts?page=2
				Host: akshay.com
				User-agent
				Cookies
					
	Server
			HTTP
			ContentType format of data
			Content-Length : len of data


*/


fetch('api/events')
	.then(res => res.json())
	.then(data => console.log(data));

// url , hashtables

fetch('api/events', {
	method: 'POST',
	headers: {
		'Content-Type': 'application/json'
	},
	body: JSON.stringify({ id: 1, quantity: 10 })
}).then(res => {
	if (res.status != 200) {
		console.log(res);
	}
});

// 2 POST and then GET
fetch('api/events', {
	method: 'POST',
	headers: {
		'Content-Type': 'application/json'
	},
	body: JSON.stringify({ id: 1, quantity: 10 })
}).then(res => {
	if (res.status == 200) {
		fetch('api/cart')
			.then(res => res.json())
			.then(cart => updateCart(cart));
	}
});

let url = '';
// Abort Request
const controller = new AbortController(); // Object fopr aborting request
const singal = controller.signal;  // Object for communication with request
fetch(url, { singal: singal });
controller.abort(); // Abort request


// USE





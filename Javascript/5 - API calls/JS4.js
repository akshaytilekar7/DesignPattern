
/*
    XMLHttpRequest (XHR) / AJAX - asyn js 
    Not usefull I guess
    Discarded

*/ 

/*
    Websocket
         -  protocol to exchange data between slient and server. 
         -  bi-directional


ws.onmessage = (e) => {
            updateCart(JSON.parse(e.data));
        };

// use full - dig more

*/

fetch('api/events')
    .then(response => {
        if (response.status !== 200) {
            showError('Something went wrong.');
        }
        return response.json();
    })
    .then(events => {
        showEvents(events);
        events.forEach(async event => {
            let controller = new AbortController();
            controllers.push(controller);
            const response = await fetch(`api/cover/${event.id}`, {
                signal: controller.signal
            });

            const reader = response.body.getReader();
            const total = response.headers.get('Content-Length') || 0;

            let chunks = [];
            let received = 0;
            while (true) {
                const { done, value } = await reader.read();
                if (value) {
                    chunks.push(value);
                    received += value.length;

                    showProgress(total === 0 ? 'N/A' : Math.ceil(100 * received / total) + ' %', event.id);
                }

                if (done) break;
            }
            removeProgress(event.id);

            var img = decodeChunks(chunks);
            showImage(img, event.id);
        });

        const ws = new WebSocket('ws://localhost:3000');
        ws.onmessage = (e) => {
            updateCart(JSON.parse(e.data));
        };
    });

function abort() {
    controllers.forEach(controller => controller.abort());
}

function addToCart(id, quantity) {
    fetch('api/cart', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ id: id, quantity: quantity })
    })
        .then(response => {
            if (response.status === 200) {
                fetch('api/cart')
                    .then(response => response.json())
                    .then(cart => updateCart(cart));
            }
        });
}
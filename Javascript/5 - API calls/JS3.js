/*
    
    AXIOS
        -   Promise based HTTP client for browser and node  
        -   Open source
        -   npm install axios 
        -   impoet axios from 'axios'    // package manager and IMPORT
            or
            axios = require('axios')     // package manager and Require
            or
            <script src="axios.js">      // JS file
                

*/

// parsing is done by library

axios.get('api/events')
    .then(response => showEvents(response.data));     // response.data

axios({
    method: 'POST',
    url: 'api/cart',
    headers: {
        'Content-Type': 'application/json'
    },
    data: {
        id: id,
        quantity: quantity
    }
}).then(response => {
    if (response.status === 200) {
        axios({
            method: 'GET',
            url: 'api/cart'
        }).then(response => updateCart(response.data));
    }
});

/*
Error handling is different call catch block ->
    -   all http code outside 200 - 299  error, 
    -   no response from server 
    -   malform JSON , json is invalid

*/
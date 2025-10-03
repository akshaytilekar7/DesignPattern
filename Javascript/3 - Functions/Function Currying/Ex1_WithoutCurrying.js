/*

Problem Without Currying : API Fetcher in a React E-Commerce App
Context: A React e-commerce app needs to fetch data (products, orders, cart) from a backend API.
Each call requires a base URL and auth token. 
Without currying, you repeat configs; with it, you streamline and scale.

*/
// API library
async function fetchApi(baseUrl, token, endpoint, options = {}) {
    const response = await fetch(`${baseUrl}${endpoint}`, {
        headers: {
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json',
        },
        ...options,
    });
    if (!response.ok) throw new Error(`API Error: ${response.status}`);
    return response.json();
}

const API_BASE = 'https://api.ecom.com';
const token = localStorage.getItem('token');


// Use of it
async function getProducts() {
    return fetchApi(API_BASE, token, '/products', { method: 'GET' });
}

async function getOrders(status) {
    return fetchApi(API_BASE, token, '/orders', {
        method: 'POST',
        body: JSON.stringify({ status }),
    });
}

async function loadData() {
    try {
        const products = await getProducts(); // Repeat token/URL
        const orders = await getOrders('pending'); // Again!
        console.log(products, orders);
    } catch (err) {
        console.error(err);
    }
}
/*

Problem Without Currying : API Fetcher in a React E-Commerce App
Context: A React e-commerce app needs to fetch data (products, orders, cart) from a backend API.
Each call requires a base URL and auth token. 
Without currying, you repeat configs; with it, you streamline and scale.

cross q - we can garcode base url and token inside fetchAPi so no need of cur
RIGHT BUT - it may create some issues
    -   Static Configs Don’t Scale
    -   Env Switching: Hardcoding API_BASE breaks when you need to swap URLs
    -   Testing Nightmare
    -   No Reusability
*/
// API library

// Curried fetcher: Lock in config step-by-step
const createApiFetcher = (baseUrl) => (token) => async (endpoint, options = {}) => {
    const response = await fetch(`${baseUrl}${endpoint}`, {
        headers: {
            Authorization: `Bearer ${token}`,
            'Content-Type': 'application/json',
        },
        ...options,
    });
    if (!response.ok) throw new Error(`API Error: ${response.status}`);
    return response.json();
};

// Initialize once (e.g., in app bootstrap)
const API_BASE = 'https://api.ecom.com';
const api = createApiFetcher(API_BASE)(localStorage.getItem('token'));

// Derive specialized fetchers
const fetchProducts = () => api('/products', { method: 'GET' });
const fetchOrders = (status) => api('/orders', {
    method: 'POST',
    body: JSON.stringify({ status }),
});
const updateCart = (cartId, updates) => api(`/cart/${cartId}`, {
    method: 'PATCH',
    body: JSON.stringify(updates),
});

// Usage in React: Clean, no repetition
async function loadData() {
    try {
        const products = await fetchProducts(); // No URL/token needed!
        const orders = await fetchOrders('pending');
        console.log(products, orders);
    } catch (err) {
        console.error(err);
    }
}

// Testing: Easy to mock
const testApi = createApiFetcher('https://mock-api.com')('fake-token');
const testProducts = () => testApi('/products', { method: 'GET' });
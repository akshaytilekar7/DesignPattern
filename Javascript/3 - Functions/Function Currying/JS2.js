
/*

Scenario: 
    In enterprise apps, we often load configurations based on environment (dev, prod) 
    and feature flags (e.g., A/B testing, experimental features).
    -   Solution: We use Currying to modularize configuration loading dynamically
*/

function loadConfig(env) {
    return function (feature) {
        return function (key) {
            const configs = {
                dev: {
                    featureX: { apiUrl: "https://dev-api.example.com", debug: true },
                    featureY: { apiUrl: "https://dev-featureY.example.com" },
                },
                prod: {
                    featureX: { apiUrl: "https://api.example.com", debug: false },
                    featureY: { apiUrl: "https://featureY.example.com" },
                },
            };

            return configs[env]?.[feature]?.[key] || "Config not found";
        };
    };
}


const getDevConfig = loadConfig("dev");
const getProdConfig = loadConfig("prod");

const getFeatureXConfig = getProdConfig("featureX");

console.log(getFeatureXConfig("apiUrl")); // Output: "https://api.example.com"
console.log(getDevConfig("featureX")("debug")); // Output: true

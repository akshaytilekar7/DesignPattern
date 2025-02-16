function withRateLimit(handler, limit = 5, timeWindow = 60000) {
    let requestCount = 0;
    let startTime = Date.now();

    return async function (req, res) {
        const currentTime = Date.now();

        if (currentTime - startTime > timeWindow) {
            requestCount = 0;
            startTime = currentTime;
        }

        if (requestCount >= limit) {
            return res.status(429).json({ error: "Too many requests, please try again later." });
        }

        requestCount++;
        console.log(`[${new Date().toISOString()}] ${req.method} ${req.url} - Request #${requestCount}`);

        return handler(req, res); // Call the original API handler
    };
}


async function getUserData(req, res) {
    console.log(req);
    await new Promise(resolve => setTimeout(resolve, 100));
    res.json({ userId: 1, name: "Pooja", role: "Software Engineer" });
}

const limitedGetUserData = withRateLimit(getUserData, 10, 30000); // Max 10 requests per 30 sec

const express = require("express");
const app = express();
app.get("/user", limitedGetUserData);

app.listen(3000, () => console.log("Server running on port 3000"));

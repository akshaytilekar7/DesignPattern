// Use Case: Configurable Logging System (MUST Use Currying)

/*

You are building a logging utility where logs can have different log levels (INFO, WARN, ERROR).

    Each log entry should automatically include a prefix ([INFO], [WARN], [ERROR]).
    The function should be reusable across the entire application.
    It should allow dynamic logging, without repeating the same logic.

*/

function createLogger(leval) {
    return function (message) {
        console.log(`[${leval.toUpperCase() } : ${message}]`)
    }
}

// Create specific loggers
const infoLogger = createLogger("info");
const warnLogger = createLogger("warn");
const errorLogger = createLogger("error");

// Usage as many time as you can
infoLogger("Server started successfully.");  // [INFO] Server started successfully.
warnLogger("Memory usage is high!");         // [WARN] Memory usage is high!
errorLogger("Database connection failed!");  // [ERROR] Database connection failed!

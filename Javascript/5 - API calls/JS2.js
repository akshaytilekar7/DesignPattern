// ABORT

import { request } from "https";

let arr = [];

fetch('api/events')
    .then(response => response.json())
    .then(events => {
        events.forEach(event => {

            let controller = new AbortController();
            arr.push(controller);

            fetch(`api/cover/${event.id}`, {
                signal: controller.signal
            }).then(response => response.text())
              .then(img => showImage(img, event.id))
              .catch((ex) => console.log(ex));
        });
    });

function abort() {
    arr.forEach(ctr => ctr.abort());
}

// when we call abort it abort fetch api cover call


// Download progress - Redable stream

// CROSS ORIGIN RESOURSE SHARING (CORS)


/*
    CORS


    client app              GET/api/events
                            HOST -- api.example.com          server
    app.example.com         -------------->                  api.example.com
                            <--------------
                            HTTP 200 ok
                            but JS cant see these response


client cant do anything
API can greenlight that request by 
    access-control-allow-origin : app.example.com
    value => origin of the client app


 
*/ 
// import events module
var events = require('events');

// create an eventEmitter object
var sukien = new events.EventEmitter();

// create an event handler as follows

var hamxuly_sk_hello = function () {
    
    console.log('sk hello succesful');
    
    // fire the sk_hello event
    sukien.emit('sk_bye');
}

// bind the hello event with the handler
sukien.on('sk_hello',hamxuly_sk_hello);

sukien.on('sk_bye', function () {
   console.log('bye bye succesful'); 
});


sukien.emit('sk_hello');

console.log('Program Ended');

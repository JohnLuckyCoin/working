//import events module
var events = require('events');

// create an eventEmitter object
var eventEmitter = new events.EventEmitter();

// create an event handler as follows
var connectHandler = function connected(){
    console.log("Connection succesful.");
    
    // fire the data_received event
    eventEmitter.emit('data_received');
    
}

//bind the connection event with the handler
eventEmitter.on('connection',connectHandler);

//bind the data_received event with the anonymous function 

eventEmitter.on('data_received', function(){
   console.log('data received succesfully'); 
});

eventEmitter.emit('connection');
console.log("Program Ended");
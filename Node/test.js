var http = require("http");
http.createServer(function(request, response) {
    // send the HTTP header
    // HTTP Status: 200 : OK
    // Content Type: text/plain
    
    response.writeHead(200, {"Content-Type": "Text/plain"});
    
    // send the response body as "Hello HUTECH"
    response.end("Hello HUTECH");
}).listen(8081);

//Console will print the message
console.log("Server running at http://127.0.0.1:8081");
var fs = require('fs');
// implement with non-block process (default in NodeJS)
fs.readFile('d:/git/node/input.txt',function(err, data){
    if (err) return
        console.error(err);
    console.log(data.toString());
} );

console.log("Program ended");
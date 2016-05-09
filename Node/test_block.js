var fs = require('fs');
// call block mode when read text file
var data = fs.readFileSync("d:/git/node/input.txt");
console.log(data.toString());
console.log("Program ended");
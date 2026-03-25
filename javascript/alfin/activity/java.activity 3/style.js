var city=("kochi");
console.log(city);

let age = 25;
console.log(age);  

age = 26;
console.log(age);  

const pi = 3.14159;
console.log(pi);  

pi = 3.14;  
console.log(pi);

var name = ("Alfin Jijo");
console.log(name);

let score = 50;  
console.log(score);

score = 75;   
console.log(score);

const country = ("India");
console.log(country);

let temperature =30;
let oldtemperature=temperature;
temperature=32;
console.log("The temperature changed from " , oldtemperature , " to " , temperature);
{
 let x = 10;
 const y = 20;
 console.log(x,y);
}
 console.log(x,y);

function testScope() {
var message =("Hello from function scope!");
console.log(message);
}
testScope();
console.log(message);



var globalvar = ("I am global");
function showGlobal() {
    console.log(globalvar);
}
showGlobal();
console.log(globalvar);
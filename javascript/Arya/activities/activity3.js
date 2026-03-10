// console.log('Hello world');
// let name= 'Arya';
// let age=22;
// console.log(name,age);

var city = "kochi";
console.log(city);

// let age = 25;
// console.log("Initial age:", age);

age = 26;
console.log("Updated age:", age);


const pi=(3.1459);
// pi=(2.356);
    console.log(pi);



    let temperature=30


    let x = 30, y = 40;
    { 
	   let x = 10;
 	   const y = 20; 
	   console.log(x,y); // inside block 
	} 
    console.log(x, y); // outside block


function testScope() 
	  {
    	    var message = "Hello from function scope!";
    	    console.log(message);
	  }
	testScope();
	// console.log(message); // outside function



    var globalVar = "I am global!";
  function showGlobal() 
   {
     console.log("Function call",globalVar);
   }
//   showGlobal();
  console.log(globalVar);
{
    console.log("block",globalVar);
}
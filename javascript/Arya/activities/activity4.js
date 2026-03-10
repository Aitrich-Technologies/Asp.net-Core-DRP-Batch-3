var num = 20
console.log("value:",num);
console.log("Type:",typeof num);

var str = "Hello";
console.log("value:",str);
console.log("Type:",typeof str);

var bool = true;
console.log("value:",bool);
console.log("Type:",typeof bool);

var undef ;
console.log("value:",undef);
console.log("Type:",undef);

var n = null;
console.log("value:",null);
console.log("value:",typeof null);

let fruits = ["Apple","Strawberry","cherry","Litchi","Mango"];
console.log("First fruit",fruits[0]);
console.log("Last fruit",fruits[fruits.length - 1]);

fruits.push("Pineapple");
console.log(" adding a fruit:", fruits);

fruits.pop();
console.log(" removing the last fruit:", fruits);

let student = {
    Name:"Arya",
    grade:"A"
    };
    console.log("Student Name:", student.Name);
    student.grade = "A+";
    console.log("Updated Grade:", student.grade);
    student.city = "Thrissur";
    console.log("Student Object:", student);

let s1 = Symbol("id");
let s2 = Symbol("id");
console.log(s1===s2);


var obj1 = { value: 10 };
var obj2 = obj1;     
obj2.value = 50;  
console.log(obj1.value);
console.log(obj2.value);

var a = 10;   
var b = a;    
b = 20; 
console.log(a);
console.log(b);





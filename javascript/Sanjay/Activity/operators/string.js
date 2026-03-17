// let str = "javascript";
// for(let i = 0; i <str.length; i++) {
//     console.log(str[i]);
// }



// let str = "hello";
// for (let char of str) {
//     console.log(char);
// }


// let str = "world";
// Array.from(str).forEach(function(char) {
//     console.log(char);
// });



let arr = [10, 20, 30, 40];

arr.forEach(function(element) {
    console.log(element);
});




// let str = "Programming";
// let count = 0;

// for (let i = 0; i < str.length; i++) {
//     count++;
// }

// console.log("Total characters:", count);



// let str = "India";

// for (let i = str.length - 1; i >= 0; i--) {
//     console.log(str[i]);
// }


// let str = "JavaScript";

// for (let i = 0; i < str.length; i++) {
//     if (i % 2 === 0) {
//         console.log(str[i]);
//     }
// }



// let str = "banana";
// let count = 0;

// for (let i = 0; i < str.length; i++) {
//     if (str[i] === "a") {
//         count++;
//     }
// }

// console.log("Number of 'a':", count);






// let arr = [5, 10, 15];
// let sum = 0;

// arr.forEach(function(element) {
//     sum += element;
// });

// console.log("Sum is:", sum);



//print only even numbers

// let arr = [1, 2, 3, 4, 5, 6];

// arr.forEach(function(element) {
//     if (element % 2 === 0) {
//         console.log(element);
//     }
// });



// let arr = [10, 20, 30, 40];

// for (let value of arr) {
//     console.log(value);
// }



//Find the largest

// let arr = [12, 45, 7, 89, 23];

// let largest = arr[0];   // assume first element is largest

// for (let value of arr) {
//     if (value > largest) {
//         largest = value;
//     }
// }

// console.log("Largest number is:", largest);



//CountVowel

// let arr = [12, 45, 7, 89, 23];

// let largest = arr[0];   // assume first element is largest

// for (let value of arr) {
//     if (value > largest) {
//         largest = value;
//     }
// }

// console.log("Largest number is:", largest);





//Print index value
// let arr = ["apple", "banana", "mango"];

// for (let index in arr) {
//     console.log(index);
// }


//print index and element together
// let arr = ["apple", "banana", "mango"];

// for (let index in arr) {
//     console.log("Index:", index, "Element:", arr[index]);
// }


//find index of 25

// let arr = [10, 15, 25, 30];

// for (let index in arr) {
//     if (arr[index] === 25) {
//         console.log("Index of 25 is:", index);
//     }
// }



// //count the total elements

// let arr = [10, 20, 30, 40];

// let count = 0;

// for (let index in arr) {
//     count++;
// }

// console.log("Total elements:", count);



//print only elements at even index
// let arr = ["a", "b", "c", "d", "e"];

// for (let index in arr) {
//     if (index % 2 == 0) {
//         console.log(arr[index]);
//     }
// }



//new array with square values
// let arr = [2, 3, 4];

// let squared = arr.map(num => num * num);

// console.log(squared);



//convert all names into uppercase
// let arr = ["john", "mary", "alex"];

// let upperNames = arr.map(name => name.toUpperCase());

// console.log(upperNames);


//add 5 to each number
// let arr = [10, 20, 30];

// let updated = arr.map(num => num + 5);

// console.log(updated);



//convert number to string
// let arr = [1, 2, 3];

// let stringArray = arr.map(num => num.toString());

// console.log(stringArray);


//filter only even numbers
// let arr = [1, 2, 3, 4, 5, 6];

// let even = arr.filter(num => num % 2 === 0);

// console.log(even);



//filter number greater than 20
// let arr = [10, 25, 30, 15];

// let greater = arr.filter(num => num > 20);

// console.log(greater);


//filter words linger than 4 letters
// let arr = ["cat", "elephant", "dog", "tiger"];

// let longWords = arr.filter(word => word.length > 4);

// console.log(longWords);



//filter student above age 18
// let arr = [
//   { name: "A", age: 16 },
//   { name: "B", age: 22 },
//   { name: "C", age: 19 }
// ];

// let adults = arr.filter(student => student.age > 18);

// console.log(adults);
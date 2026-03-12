// let str = "javascript";
// for (let i = 0;i <str.length; i++ ) {
//     console.log(str[i]);
// }

// let str = "Hello";
// for (let letter of str){
//     console.log(letter);
// }

// let str ="world";
// let arr = [...str];
// arr.forEach(function ( letter) {
//     console.log(letter);

// });

// let str = "Programming";
// let count = 0;

// for (let char of str) {
//   count++;
// }

// console.log("Total characters:", count);

// let str = "India";

// for (let i = str.length - 1; i >= 0; i--) {
//   console.log(str[i]);
// }

// let str = "india"
// for (let i = 0;i < str.length;i +=2){
//     console.log(str[i]);
// }

// let str = "banana";
// let count = 0;

// for (let letter of str) {
//   if (letter === "a") {
//     count++;
//   }
// }

// console.log("times of a:", count);

// let arr = [10, 20, 30, 40];

// arr.forEach(function(num) {
//   console.log(num);
// });

// let arr = [5, 10, 15];
// let sum = 0;

// arr.forEach(function(num) {
//   sum += num;
// });

// console.log("Sum:", sum);

// let arr = [1, 2, 3, 4, 5, 6];

// arr.forEach(function(num) {
//   if (num % 2 === 0) {
//     console.log(num);
//   }
// });

// let arr = [20,40,60,80];

// for (let num of arr) {
//   console.log(num);
// }

// let arr = [12, 45, 89, 23];
// let largest = arr[0];

// for (let num of arr) {
//   if (num > largest) {
//     largest = num;
//   }
// }

// console.log("Largest:", largest);

// let arr = ["a", "b", "e", "g", "i"];
// let count = 0;

// for (let vowels of arr) {
//   if ("aeiou".includes(vowels)) {
//     count++;
//   }
// }

// console.log("Vowel count:", count);

// let arr = ["apple", "banana", "mango"];

// for (let index in arr) {
//   console.log(index);
// }

// let arr = ["apple", "banana", "mango"];

// for (let index in arr) {
//   console.log(index, arr[index]);
// }

// let arr = [10, 15, 25, 30];

// for (let index in arr) {
//   if (arr[index] === 25) {
//     console.log("Index of 25:", index);
//   }
// }

// let arr = [10, 20, 30, 40];
// let count = 0;

// for (let index in arr) {
//   count++;
// }

// console.log("Total elements:", count);


// let arr = ["a", "b", "c", "d", "e"];

// for (let index in arr) {
//   if (index % 2 == 0) {
//     console.log(arr[index]);
//   }
// }

// let arr = ["john", "mary", "alex"];

// let result = arr.map(function(name) {
//   return name.toUpperCase();
// });

// console.log(result);

// let arr = [2, 3, 4];

// let result = arr.map(function(num) {
//   return num * num;
// });

// console.log(result);

// let arr = [1, 2, 3];

// let result = arr.map(function(num) {
//   return num + 5;
// });

// console.log(result);

// let arr = [1, 2, 3];

// let result = arr.map(function(num) {
//   return num.toString();
// });

// console.log(result);

// let arr = [1, 2, 3, 4, 5, 6];

// let result = arr.filter(function(num) {
//   return num % 2 === 0;
// });

// console.log(result);

// let arr = [10, 25, 30, 15, 5];

// let result = arr.filter(function(num) {
//   return num > 20;
// });

// console.log(result);

// let arr = ["cat", "elephant", "dog", "tiger"];

// let result = arr.filter(function(word) {
//   return word.length > 4;
// });

// console.log(result);

// let arr = [
//   {name: "Arya", age: 16},
//   {name: "Anjitha", age: 22},
//   {name: "Arch", age: 19}
// ];

// let result = arr.filter(function(student) {
//   return student.age > 18;
// });

// console.log(result);

// while loop

// let i  = 1;
// while (i<=10) {
//   console.log(i);i++;

// }

let i = 2;

while (i <= 20) {
  console.log(i);
  i += 2;
}


// let i = 10;

// while (i >= 1) {
//   console.log(i);
//   i--;
// }

// let i = 1;
// let sum = 0;

// while (i <= 5) {
//   sum += i;
//   i++;
// }

// console.log(sum);

// let i = 1;

// while (i <= 10) {
//   console.log("5 x " + i + " = " + (5 * i));
//   i++;
// }

// let i = 1;

// do {
//   console.log(i);
//   i++;
// } while (i <= 5);

// let i = 5;

// do {
//   console.log(i);
//   i--;
// } while (i >= 1);

// let i = 1;

// do {
//   console.log(i);
//   i += 2;
// } while (i <= 15);
// let x=10;
// x +=5;
// console.log(x);

// let a = 5;
// let b = 3;
// let c = 2;
// let d = 1;
// let e = 8;
// console.log("5 & 3", a & b);
// console.log("5 | 2", a | c);
// console.log("5 ^ 1", a ^ d);
// console.log("5 << 1", a << 1);
// console.log("8 >> 1", e >> 1);

// let result = (10 > 20) ? "Yes" : "No";
// console.log(result);

// let mark = 50;
//    result =  (mark >= 50) ? "Pass" : "Fail";
//         console.log(result);

// let x = "Hello";
// let y = 100;
// console.log(typeof(x));
// console.log(typeof(y));
// let count=0;
// while(count<4){
//         console.log(count)
//         count++;
// }
// do{
// console.log(count)
//         count++;
// }
// while(count<4);\
// let day=1;
// let dayname;
// switch (day){
//         case 1:
//                 dayname= "monday";
//                 break;
//                 case 2:
//                 dayname="tuesday";
//                 break;
//                 case 3:
//                  dayname= "wednesday";
//                 break;
//                 case 4:
//                  dayname= "thursday";
//                 break;
//                 default:
//                         dayname="unknown";
// }
// console.log(dayname);


// let i=1;
// while(i<=10){
//         console.log(i);
//         i++;
// }

// let i=2;
// while(i<=20){
//         console.log(i);
//         i+=2;
// }
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

// console.log("Sum:", sum);


// let i = 1;

// while (i <= 10) {
//     console.log("5 * " + i + " = " + (5 * i));
//     i++;
// }

// let num=1;
// do{
//     console.log(num);
//     num++;
// }
// while(num<=5);

// let num=5;
// do{
//     console.log(num);
//     num--;
// } while(num>=1);

// let num=1;
// do{
//     console.log(num);
//     num+=2;
// }while(num<=15);

/*let day=1;
let dayname;
switch (day){
    case 1:
    dayname="monday";
    break; 
    case 2:
    dayname="tuesday";
    break;
    case 3:
    dayname="wednesday";
    break;
    case 4:
    dayname="thursday";
    break;
    case 5:
    dayname="friday";
    break;
    case 6:
    dayname="saturday";
    break;
    case 7:
    dayname="sunday";
    break; 
    default:dayname("invalid day"); 
}console.log(dayname);*/

// let num1=10;
// let num2=5;
// let operator="*";
// let result;
// switch(operator){
//     case"+":
//     result=num1+num2;
//     break;
//      case"-":
//     result=num1-num2;
//     break;
//      case"*":
//     result=num1*num2;
//     break;
//      case"/":
//     result=num1/num2;
//     break;
//     default:result("invali operator");
// }console.log(result);


// let grade="A";
// let gradename;
// switch(grade) {
//     case 'A':
//     gradename =("excellent");
//     break;
//     case 'B':
//     gradename =("good");
//     break;
//     case 'C':
//     gradename =("average");
//     break;
//     case 'D':
//     gradename =("poor");
//     break;
//     default:gradename("invalid grade");

// }console.log(gradename);

// let month=2;
// let monthname;
// switch(month){
//     case 1:
//     monthname="january";
//      case 3:
//     monthname="march";
//      case 5:
//     monthname="may";
//      case 7:
//     monthname="july";
//      case 8:
//     monthname="august";
//      case 10:
//     monthname="october";
//      case 12:
//     monthname="december";
//     break;
//      case 4:
//     monthname="april";
//      case 6:
//     monthname="june";
//      case 9:
//     monthname="september";
//      case 11:
//     monthname="november";
//     break;
//     case 2:
//         monthname="february"
//         break;
//         default:("invalid month");
// }
// console.log(monthname);
// function addnumbers(num1,num2){
//     let sum=num1+num2;
//     console.log(sum);
// }
// addnumbers(5,6);
// function addnumbers(a,b){
//     return a+b;

// }
// const sum=addnumbers(5,6);
// console.log(sum);


// function addnumber(num1,num2){
//     return num1+num2;
// }const sum=addnumber(5,6);
// console.log(sum);

// function multiplynumber(num1,num2){
//     let sum=num1*num2;
//     console.log(sum);
// }multiplynumber(5,6);

// function greet(name){
//     let Name=name;
//     console.log("hello"+Name);
// }
// greet("Sunjay");

// function oddoreven(num){
// if(num % 2===0){
//     return "even";

// }
// else{
//     return"odd";
// }
// }
// console.log(oddoreven(6));

function larger(num1,num2){
    if (num1<num2){
        return num2 ,"is larger";
    }else{
        return num1 ,"is larger";
    }
}
console.log(larger(5,4));


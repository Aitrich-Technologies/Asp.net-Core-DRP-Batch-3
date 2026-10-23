// 1
let age:number = 65;
let amount:number = 6000;
if (age >= 60 && amount >= 5000)
 {
    console.log("customer is eligible for discount");
} else
{
  console.log("customer is not eligible for discount");
}
// 2
let password:string = "arya123";
let confirmpassword:string = "arya123";

if (password === "" || confirmpassword === "") {
    console.log("Password fields cannot be empty");
} else if (password === confirmpassword) {
    console.log("Password matched");
} else {
    console.log("Password does not match");
}
// 3

let Amount: number = 8000;
let discount: number;

if (Amount < 5000) {
    discount = 5;
} else if (Amount <= 10000) {
    discount = 10;
} else {
    discount = 15;
}

let discountAmount: number = Amount * discount / 100;
let finalAmount: number = Amount - discountAmount;

console.log("Discount:", discount + "%");
console.log("Discount amount:", discountAmount);
console.log("Final amount:", finalAmount);

// // 4
// let Age = 22;
// let seats = 5;
// let payment = true;

// if (Age >= 18) {
//     if (seats > 0) {
//         if (payment == true) {
//             console.log("Booking confirmed");
//         } else {
//             console.log("Pay first");
//         }
//     } else {
//         console.log("No seats");
//     }
// } else {
//     console.log("Age must be 18");
// }
// 5
let Status = "Confirmed";
let Payments = true;

if (Status == "Invalid") {
    console.log("Invalid booking");
} else if (Status == "Pending") {
    console.log("Booking pending");
} else if (Status == "Cancelled") {
    console.log("Booking cancelled");
} else if (Status == "Confirmed" && payments) {
    console.log("Booking confirmed");
} else {
    console.log("Payment incomplete or invalid status");
}

// 6
let Seats = 5;
let amounts = 25000;

if (Seats >= 5 && amounts > 20000) {
    console.log("Group discount available");
} else {
    console.log("No group discount");
}
// 7
let option = 2;

switch (option) {
    case 1:
        console.log("Goa - 5000");
        break;
    case 2:
        console.log("Manali - 8000");
        break;
    case 3:
        console.log("Dubai - 25000");
        break;
    default:
        console.log("Invalid option");
}
// 8
let STATUS = 2;

switch (STATUS) {
    case 1:
        console.log("Pending");
        break;
    case 2:
        console.log("Confirmed");
        break;
    case 3:
        console.log("Cancelled");
        break;
    case 4:
        console.log("Completed");
        break;
    default:
        console.log("Invalid status");
}
// // 9
// let type = "Domestic";
// let price = 0;

// switch (type) {
//     case "Domestic":
//         price = 5000;
//         break;
//     case "International":
//         price = 25000;
//         break;
//     case "Adventure":
//         price = 10000;
//         break;
//     default:
//         console.log("Invalid tour type");
// }

// console.log("Price:", price);
// 10
let options= 1;

switch (options) {
    case 1:
        console.log("Book tour");
        break;
    case 2:
        console.log("Cancel booking");
        break;
    case 3:
        console.log("View bookings");
        break;
    case 4:
        console.log("Exit");
        break;
    default:
        console.log("Invalid option");
}
// for loop
// 11
let prices = [2000, 3000, 4000];
let sum = 0;

for (let i = 0; i < prices.length; i++) {
    sum = sum + prices[i];
}

console.log("Total:", sum);
// 12
let a = [10, 40, 20, 50, 30];
let largest = a[0];
let second = -Infinity;

for (let i = 1; i < a.length; i++) {
    if (a[i] > largest) {
        second = largest;
        largest = a[i];
    } else if (a[i] > second && a[i] < largest) {
        second = a[i];
    }
}

console.log("Second largest:", second);
// 13
for (let i = 1; i <= 100; i++) {
    if (i % 5 == 0) {
        continue;
    }
    console.log(i);
}
// 14
let n = ["Goa", "Manali", "Goa", "Dubai"];

for (let i = 0; i < a.length; i++) {
    for (let j = i + 1; j < n.length; j++) {
        if (n[i] == n[j]) {
            console.log("Duplicate:", n[i]);
        }
    }
}
// 15
for (let i = 1; i <= 5; i++) {
    let s = "";

    for (let j = 1; j <= i; j++) {
        s = s + "*";
    }

    console.log(s);
}
// 16
let d = [10, 20, 30, 40];
let g = [];

for (let i = d.length - 1; i >= 0; i--) {
    g.push(d[i]);
}

console.log(g);
// 17
let u = [5000, 2000, 8000, 1500];

let high = u[0];
let low = u[0];

for (let i = 1; i < u.length; i++) {
    if (u[i] > high) {
        high = a[i];
    }

    if (u[i] < low) {
        low = u[i];
    }
}

console.log("Highest:", high);
console.log("Lowest:", low);
// 18
let z = 1234;
let rev = 0;

while (z > 0) {
    let digit = z % 10;
    rev = rev * 10 + digit;
    z = Math.floor(z / 10);
}

console.log(rev);
// 19

let o = 12345;
let sums = 0;

while (o > 0) {
    sums = sums+ (o % 10);
    o= Math.floor(o / 10);
}

console.log(sums);

// 20
let t = 5;
let fact = 1;

while (t > 0) {
    fact = fact * t;
    t--;
}

console.log(fact);
// 21
let k = 56789;
let count = 0;

while (k > 0) {
    count++;
    k = Math.floor(k/ 10);
}

console.log("Digits:", count);

// 22
let OPTION = 1;

do {
    console.log("1. Book tour");
    console.log("2. Cancel booking");
    console.log("3. View bookings");
    console.log("4. Exit");

    OPTION = 4;

} while (OPTION != 4);

console.log("Exited");
// 23
let i = 0;

do {
    i++;
    console.log("Attempt:", i);
} while (i < 3);

console.log("Finished");
// 24
let choice = "yes";

do {
    let price = 5000;
    let persons = 2;

    console.log("Total:", price * persons);

    choice = "no";
} while (choice == "yes");
// 25
let S = ["Goa", "Manali", "Dubai"];
let search = "Dubai";

for (let i = 0; i < a.length; i++) {
    if (S[i] == search) {
        console.log("Found:", S[i]);
        break;
    }
}
// // 26
// let Price = [5000, 0, 8000, 0, 10000];

// for (let i = 0; i < Price.length; i++) {
//     if (Price[i] == 0) {
//         continue;
//     }

//     console.log(Price[i]);
// }
// 27
let l = [3000, 7000, 15000, 20000];

for (let i = 0; i < l.length; i++) {
    if (l[i] > 10000) {
        console.log(l[i]);
        break;
    }
}
// 28
for (let i = 1; i <= 50; i++) {
    if (i % 3 == 0 && i % 5 == 0) {
        continue;
    }

    console.log(i);
}
// 29
let B = [101, 102, 103, 102, 104];

for (let i = 0; i < B.length; i++) {
    for (let j = i + 1; j < B.length; j++) {
        if (B[i] == B[j]) {
            console.log("Duplicate:", B[i]);
            break;
        }
    }
}
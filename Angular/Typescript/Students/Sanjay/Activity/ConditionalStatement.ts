// let age: number = 22;
// let bookingAmount: number = 6000;

// if (age >= 60 && bookingAmount >= 5000) {
//     console.log("Eligible for senior citizen discount");
// } else if (age < 18 && bookingAmount >= 3000) {
//     console.log("Eligible for child discount");
// } else {
//     console.log("Not eligible for discount");
// }



// let password: string = "Tour@123";
// let confirmPassword: string = "Tour@123";

// if (password === "" || confirmPassword === "") {
//     console.log("Password fields cannot be empty");
// } else if (password === confirmPassword) {
//     console.log("Password confirmed successfully");
// } else {
//     console.log("Passwords do not match");
// }



// let amount: number = 12000;
// let discount: number;

// if (amount < 5000) {
//     discount = 5;
// } else if (amount <= 10000) {
//     discount = 10;
// } else {
//     discount = 15;
// }

// let discountAmount = amount * discount / 100;
// let finalAmount = amount - discountAmount;

// console.log("Discount:", discount + "%");
// console.log("Discount Amount: ₹" + discountAmount);
// console.log("Final Amount: ₹" + finalAmount);



// // neatedif

// let age: number = 25;
// let availableSeats: number = 10;
// let paymentCompleted: boolean = true;

// if (age >= 18) {
//     if (availableSeats > 0) {
//         if (paymentCompleted) {
//             console.log("Tour booking confirmed");
//         } else {
//             console.log("Please complete payment");
//         }
//     } else {
//         console.log("No seats available");
//     }
// } else {
//     console.log("Not eligible to book this tour");
// }


// let status: string = "Pending";
// let paymentCompleted: boolean = false;

// if (status === "Invalid") {
//     console.log("Invalid booking");
// } else if (status === "Cancelled") {
//     console.log("Booking cancelled");
// } else if (status === "Pending") {
//     if (paymentCompleted) {
//         console.log("Payment completed; booking awaiting confirmation");
//     } else {
//         console.log("Booking pending payment");
//     }
// } else if (status === "Confirmed") {
//     if (paymentCompleted) {
//         console.log("Booking confirmed");
//     } else {
//         console.log("Payment required before confirmation");
//     }
// } else {
//     console.log("Unknown booking status");
// }

// let seats: number = 6;
// let totalAmount: number = 25000;

// if (seats >= 5 && totalAmount > 20000) {
//     console.log("Eligible for group discount");
// } else {
//     console.log("Not eligible for group discount");
// }



// switch

// let option: number = 2;

// switch (option) {
//     case 1:
//         console.log("Destination: Munnar");
//         console.log("Price: ₹3000");
//         break;

//     case 2:
//         console.log("Destination: Goa");
//         console.log("Price: ₹7000");
//         break;

//     case 3:
//         console.log("Destination: Manali");
//         console.log("Price: ₹10000");
//         break;

//     default:
//         console.log("Invalid destination option");
// }


// let bookingStatus: number = 2;

// switch (bookingStatus) {
//     case 1:
//         console.log("Booking Pending");
//         break;

//     case 2:
//         console.log("Booking Confirmed");
//         break;

//     case 3:
//         console.log("Booking Cancelled");
//         break;

//     case 4:
//         console.log("Tour Completed");
//         break;

//     default:
//         console.log("Invalid booking status");
// }


// let tourType: string = "International";
// let basePrice: number = 5000;
// let totalPrice: number;

// switch (tourType) {
//     case "Domestic":
//         totalPrice = basePrice;
//         break;

//     case "International":
//         totalPrice = basePrice * 3;
//         break;

//     case "Adventure":
//         totalPrice = basePrice * 1.5;
//         break;

//     default:
//         totalPrice = 0;
//         console.log("Invalid tour type");
// }

// if (totalPrice > 0) {
//     console.log("Total Price: ₹" + totalPrice);
// }

// let option: number = 1;

// switch (option) {
//     case 1:
//         console.log("Book a tour selected");
//         break;

//     case 2:
//         console.log("Cancel a booking selected");
//         break;

//     case 3:
//         console.log("View all bookings selected");
//         break;

//     case 4:
//         console.log("Exiting application");
//         break;

//     default:
//         console.log("Invalid menu option");
// }


// for loop


// let prices: number[] = [3000, 5000, 7000, 2000];
// let sum: number = 0;

// for (let i = 0; i < prices.length; i++) {
//     sum += prices[i]!;
// }

// console.log("Total Tour Price: ₹" + sum);


// let numbers: number[] = [10, 50, 30, 80, 60];

// let largest = -Infinity;
// let secondLargest = -Infinity;

// for (let i = 0; i < numbers.length; i++) {
//     let current = numbers[i];

//     if (current > largest) {
//         secondLargest = largest;
//         largest = current;
//     } else if (current < largest && current > secondLargest) {
//         secondLargest = current;
//     }
// }

// if (secondLargest === -Infinity) {
//     console.log("No second-largest distinct number");
// } else {
//     console.log("Second Largest:", secondLargest);
// }



// for (let i = 1; i <= 100; i++) {
//     if (i % 5 === 0) {
//         continue;
//     }

//     console.log(i);
// }


// let destinations: string[] = [
//     "Munnar", "Goa", "Munnar", "Manali", "Goa"
// ];

// for (let i = 0; i < destinations.length; i++) {
//     for (let j = i + 1; j < destinations.length; j++) {
//         if (destinations[i] === destinations[j]) {
//             console.log("Duplicate:", destinations[i]);
//             break;
//         }
//     }
// }


// for (let i = 1; i <= 5; i++) {
//     let pattern = "";

//     for (let j = 1; j <= i; j++) {
//         pattern += "*";
//     }

//     console.log(pattern);
// }

// let arr: number[] = [10, 20, 30, 40, 50];
// let reversed: number[] = [];

// for (let i = arr.length - 1; i >= 0; i--) {
//     reversed.push(arr[i]);
// }

// console.log(reversed);


// let tourPrices: number[] = [5000, 2000, 8000, 3500, 10000];

// let highest = tourPrices[0];
// let lowest = tourPrices[0];

// for (let i = 1; i < tourPrices.length; i++) {
//     if (tourPrices[i] > highest) {
//         highest = tourPrices[i];
//     }

//     if (tourPrices[i] < lowest) {
//         lowest = tourPrices[i];
//     }
// }

// console.log("Highest Price: ₹" + highest);
// console.log("Lowest Price: ₹" + lowest);


// while loop

// let num: number = 12345;
// let reversedNumber: number = 0;

// while (num > 0) {
//     let digit = num % 10;
//     reversedNumber = reversedNumber * 10 + digit;
//     num = Math.floor(num / 10);
// }

// console.log("Reversed Number:", reversedNumber);


// let bookingId: number = 12345;
// let sumDigits: number = 0;

// while (bookingId > 0) {
//     sumDigits += bookingId % 10;
//     bookingId = Math.floor(bookingId / 10);
// }

// console.log("Sum of Digits:", sumDigits);


// let number: number = 121;
// let original = number;
// let reversed = 0;

// while (number > 0) {
//     let digit = number % 10;
//     reversed = reversed * 10 + digit;
//     number = Math.floor(number / 10);
// }

// if (original === reversed) {
//     console.log("Palindrome number");
// } else {
//     console.log("Not a palindrome");
// }

// let n: number = 5;
// let factorial: number = 1;
// let i: number = 1;

// while (i <= n) {
//     factorial *= i;
//     i++;
// }

// console.log("Factorial:", factorial);


// Do while loop

// let option: number = 1;

// do {
//     console.log("1. Book a Tour");
//     console.log("2. Cancel Booking");
//     console.log("3. View Bookings");
//     console.log("4. Exit");

//     console.log("Selected Option:", option);

//     option++;

//     if (option > 4) {
//         option = 4;
//     }
// } while (option !== 4);

// console.log("Application closed");


// let attempt: number = 1;
// let bookingSuccessful: boolean = false;

// do {
//     console.log("Booking Attempt:", attempt);

//     if (attempt === 3) {
//         bookingSuccessful = true;
//     }

//     attempt++;
// } while (attempt <= 3 && !bookingSuccessful);

// if (bookingSuccessful) {
//     console.log("Booking successful");
// } else {
//     console.log("Maximum attempts reached");
// }


// let continueBooking: string = "yes";
// let bookingCount: number = 0;

// do {
//     let price: number = 3000;
//     let persons: number = 2;
//     let total: number = price * persons;

//     console.log("Booking Total: ₹" + total);

//     bookingCount++;

//     continueBooking = "no";
// } while (continueBooking.toLowerCase() === "yes");

// console.log("Total Bookings:", bookingCount);



// break continue

// let places: string[] = ["Munnar", "Goa", "Manali", "Wayanad"];

// let searchDestination: string = "Manali";

// for (let i = 0; i < places.length; i++) {
//     if (places[i] === searchDestination) {
//         console.log("Destination found at index:", i);
//         break;
//     }
// }


// let pricesList: number[] = [3000, 5000, 7000, 9000];
// let available: boolean[] = [true, false, true, false];

// for (let i = 0; i < pricesList.length; i++) {
//     if (!available[i]) {
//         continue;
//     }

//     console.log("Available Tour Price: ₹" + pricesList[i]);
// }

// let payments: number[] = [3000, 7000, 15000, 20000];

// for (let i = 0; i < payments.length; i++) {
//     if (payments[i] > 10000) {
//         console.log("First payment above ₹10,000:", payments[i]);
//         break;
//     }
// }


// for (let i = 1; i <= 50; i++) {
//     if (i % 3 === 0 && i % 5 === 0) {
//         continue;
//     }

//     console.log(i);
// }


// let bookingIds: number[] = [101, 102, 103, 104, 102, 105];

// let duplicateFound: boolean = false;

// for (let i = 0; i < bookingIds.length; i++) {
//     for (let j = i + 1; j < bookingIds.length; j++) {
//         if (bookingIds[i] === bookingIds[j]) {
//             console.log("First duplicate booking ID:", bookingIds[i]);
//             duplicateFound = true;
//             break;
//         }
//     }

//     if (duplicateFound) {
//         break;
//     }
// }

// if (!duplicateFound) {
//     console.log("No duplicate booking IDs found");
// }
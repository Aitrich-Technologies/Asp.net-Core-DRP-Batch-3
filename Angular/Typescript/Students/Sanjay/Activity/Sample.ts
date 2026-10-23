let message: string = "Hello TypeScript";
console.log(message);

// let name1:string='remya';

// let name2:string="raju";

// console.log(name1);

// console.log(name2);

// class Person {

// private name: string;

// public constructor(name: string) {

// this.name = name;

// }

// public getName(): string {

// return this.name;

// }

// }

// const person = new Person("Jane");

// console.log(person.getName());


// let tourName: string = "Kerala Explorer";
// let destination: string = "Munnar";
// let days: number = 4;
// let price: number = 15000;
// let isAvailable: boolean = true;
// console.log(tourName);


// let Name:string = "Alfin";
// let Age:number = 23;
// let Phone:number = 9876543211;
// let Nationality:string = "India";

// console.log("Name:",Name);
// console.log("Age:",Age);
// console.log("Phone:",Phone);
// console.log("Nationality:",Nationality);

// let tourists: number = 4;
// let price: number = 5000;
// let total:number = tourists*price;
// console.log(total);

// let tours = [
//     {
//         name: "Kerala Explorer",
//         destination: "Kerala",
//         price: 15000,
//         seats: 20
//     },
//     {
//         name: "Goa Beach Tour",
//         destination: "Goa",
//         price: 12000,
//         seats: 15
//     },
//     {
//         name: "Rajasthan Heritage",
//         destination: "Rajasthan",
//         price: 20000,
//         seats: 10
//     }
// ];
// // console.log(tours);

// tours.forEach(tour => {
//     console.log(
//         `Name: ${tour.name}, Destination: ${tour.destination}, Price: ₹${tour.price}, Seats: ${tour.seats}`
//     );
// });

// let destination = "Goa";

// for (let tour of tours) {
//     if (tour.destination === destination) {
//         console.log( tour.name);
//     }
// }

// let cheapest = tours[0]!;

// for (let tour of tours) {
//     if (tour.price < cheapest.price) {
//         cheapest = tour;
//     }
// }

// console.log("Cheapest Tour:", cheapest.name);


// let tour = tours[0]!;

// console.log("Available seats:", tour.seats);


// let persons = 3;

// if (persons <= tour.seats) {
//     let cost = tour.price * persons;
//     console.log("Booking cost:", cost);
// } else {
//     console.log("Not enough seats");
// }
"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const prompt_sync_1 = __importDefault(require("prompt-sync"));
const prompt = (0, prompt_sync_1.default)();
let tourPackages = [];
let choice;
const username = "admin";
const password = "12345";
let isLoggedIn = false;
do {
    console.log("\n========= TRAVEL AGENCY =========");
    console.log("1. Login");
    console.log("2. Add Tour Package");
    console.log("3. View Tour Packages");
    console.log("4. Delete Tour Package");
    console.log("5. Exit");
    choice = Number(prompt("Enter your choice : "));
    switch (choice) {
        case 1:
            let user = prompt("Enter Username : ");
            let pass = prompt("Enter Password : ");
            if (user === username && pass === password) {
                isLoggedIn = true;
                console.log("Login Successful.");
            }
            else {
                console.log("Invalid Username or Password.");
            }
            break;
        case 2:
            if (!isLoggedIn) {
                console.log("Please Login First.");
                break;
            }
            let tour = {
                tourId: Number(prompt("Enter Tour ID : ")),
                tourTitle: prompt("Enter Tour Title : "),
                destination: prompt("Enter Destination : "),
                category: prompt("Enter Category : "),
                price: Number(prompt("Enter Price : ")),
                duration: Number(prompt("Enter Duration (Days) : ")),
                departureDate: prompt("Enter Departure Date : "),
                availableSeats: Number(prompt("Enter Available Seats : ")),
                requirements: prompt("Enter Requirements : ")
            };
            tourPackages.push(tour);
            console.log("Tour Package Added Successfully.");
            break;
        case 3:
            if (!isLoggedIn) {
                console.log("Please Login First.");
                break;
            }
            if (tourPackages.length == 0) {
                console.log("No Tour Packages Available.");
            }
            else {
                console.log("\n================ TOUR PACKAGE LIST ================");
                tourPackages.forEach((t) => {
                    console.log("---------------------------------------------");
                    console.log("Tour ID          :", t.tourId);
                    console.log("Title            :", t.tourTitle);
                    console.log("Destination      :", t.destination);
                    console.log("Category         :", t.category);
                    console.log("Price            :", t.price);
                    console.log("Duration         :", t.duration, "Days");
                    console.log("Departure Date   :", t.departureDate);
                    console.log("Available Seats  :", t.availableSeats);
                    console.log("Requirements     :", t.requirements);
                });
            }
            break;
        case 4:
            if (!isLoggedIn) {
                console.log("Please Login First.");
                break;
            }
            let deleteId = Number(prompt("Enter Tour ID : "));
            let index = tourPackages.findIndex(t => t.tourId === deleteId);
            if (index != -1) {
                tourPackages.splice(index, 1);
                console.log("Tour Package Deleted Successfully.");
            }
            else {
                console.log("Tour Package Not Found.");
            }
            break;
        case 5:
            console.log("Thank You...");
            break;
        default:
            console.log("Invalid Choice");
    }
} while (choice != 5);

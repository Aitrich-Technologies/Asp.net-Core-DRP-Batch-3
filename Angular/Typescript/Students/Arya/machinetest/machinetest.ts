
import promptSync from "prompt-sync";
const prompt = promptSync();

interface Tour {
    tourID: number;
    tourName: string;
    destination: string;
    numberofDays: number;
    price: number;
    availableSeats: number;
}

let tours: Tour[] = [];
let choice: number;

do {
    console.log("\n======= TOUR MANAGEMENT SYSTEM ======");
    console.log("1. Add Tour");
    console.log("2. View Tours");
    console.log("3. Search Tour");
    console.log("4. Delete Tour");
    console.log("5. Exit");

    choice = Number(prompt("\nEnter Your Choice: "));

    switch (choice) {

        case 1: {
            console.log("\n==== Add Tour ====");

            let tour: Tour = {
                tourID: Number(prompt("Enter Tour ID: ")),
                tourName: prompt("Enter Tour Name: "),
                destination: prompt("Enter Destination: "),
                numberofDays: Number(prompt("Enter No. of Days: ")),
                price: Number(prompt("Enter Price: ")),
                availableSeats: Number(prompt("Enter Available Seats: "))
            };

            tours.push(tour);
            console.log("Tour Added Successfully.");
            break;
        }

        case 2:
            if (tours.length === 0) {
                console.log("No Tours Available.");
            } else {
                tours.forEach((t) => {
                    console.log("\n------------------------------");
                    console.log("ID              :", t.tourID);
                    console.log("Tour Name       :", t.tourName);
                    console.log("Destination     :", t.destination);
                    console.log("Number of Days  :", t.numberofDays);
                    console.log("Price           :", t.price);
                    console.log("Available Seats :", t.availableSeats);
                });
            }
            break;

        case 3: {
            let searchName = prompt("Enter Tour Name: ");

            let found = tours.find(
                t => t.tourName.toLowerCase() === searchName.toLowerCase()
            );

            if (found) {
                console.log("\nTour Found:");
                console.log(found);
            } else {
                console.log("Tour Not Found.");
            }
            break;
        }

        case 4: {
            let id = Number(prompt("Enter Tour ID to Delete: "));

            let index = tours.findIndex(t => t.tourID === id);

            if (index !== -1) {
                tours.splice(index, 1);
                console.log("Tour Deleted Successfully.");
            } else {
                console.log("Tour Not Found.");
            }
            break;
        }

        case 5:
            console.log("Exiting Tour Management System.");7
            
            break;

        
    }

} while (choice !== 5);

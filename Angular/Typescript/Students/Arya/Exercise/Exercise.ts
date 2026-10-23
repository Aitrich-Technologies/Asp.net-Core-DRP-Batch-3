
import promptSync from "prompt-sync";
const prompt = promptSync();

interface Booking {
    BookingID: number;
    CustomerName: string;
    PhoneNumber: string;
    TourName: string;
    Destination: string;
    TravelDate: string;
    NumberofTravellers: number;
    PackagePrice: number;
    TotalAmount: number;
    BookingStatus: string;
}


let bookings: Booking[] = [];
let choice: number;
let continueChoice = "y";

do {
    console.log("\n========= BOOKING =========");
    console.log("1. New Booking");
    console.log("2. View Bookings");
    console.log("3. Cancel Booking");
    console.log("4. Search Booking");
    console.log("5. Exit");

    choice = Number(prompt("\nEnter your choice : "));

    switch (choice) {

        case 1: {
            console.log("\n------ New Booking ------");

            const bookingID = Number(prompt("Booking ID : "));
            const customerName = prompt("Customer Name : ");
            const phoneNumber = prompt("Phone Number : ");
            const tourName = prompt("Tour Name : ");
            const destination = prompt("Destination : ");
            const travelDate = prompt("Travel Date : ");
            const travellers = Number(prompt("Number of Travellers : "));
            const packagePrice = Number(prompt("Package Price : "));

            const totalAmount = travellers * packagePrice;

            const newBooking: Booking = {
                BookingID: bookingID,
                CustomerName: customerName,
                PhoneNumber: phoneNumber,
                TourName: tourName,
                Destination: destination,
                TravelDate: travelDate,
                NumberofTravellers: travellers,
                PackagePrice: packagePrice,
                TotalAmount: totalAmount,
                BookingStatus: "Confirmed"
            };

            bookings.push(newBooking);

            console.log("\nBooking Added Successfully.");
            console.log("Total Amount : ₹" + totalAmount);

            break;
        }

        case 2:
            if (bookings.length === 0) {
                console.log("\nNo Bookings Available.");
            } else {
                console.log("\n------ Booking List ------");

                bookings.forEach((b) => {
                    console.log("--------------------------------");
                    console.log("Booking ID : " + b.BookingID);
                    console.log("Customer Name : " + b.CustomerName);
                    console.log("Phone Number : " + b.PhoneNumber);
                    console.log("Tour Name : " + b.TourName);
                    console.log("Destination : " + b.Destination);
                    console.log("Travel Date : " + b.TravelDate);
                    console.log("Travellers : " + b.NumberofTravellers);
                    console.log("Package Price : " + b.PackagePrice);
                    console.log("Total Amount : " + b.TotalAmount);
                    console.log("Status : " + b.BookingStatus);
                });
            }
            break;

        case 3: {
            const id = Number(prompt("\nEnter Booking ID : "));

            const booking = bookings.find(
                b => b.BookingID === id
            );

            if (booking) {
                if (booking.BookingStatus === "Cancelled") {
                    console.log("\nBooking is already Cancelled.");
                } else {
                    booking.BookingStatus = "Cancelled";
                    console.log("\nBooking Cancelled Successfully.");
                }
            } else {
                console.log("\nBooking ID not found.");
            }

            break;
        }

        case 4: {
            const searchValue = prompt(
                "\nEnter Booking ID or Customer Name : "
            );

            const foundBooking = bookings.find(
                b =>
                    b.BookingID === Number(searchValue) ||
                    b.CustomerName.toLowerCase() ===
                    searchValue.toLowerCase()
            );

            if (foundBooking) {
                console.log("\n------ Booking Found ------");
                console.log("--------------------------------");
                console.log("Booking ID : " + foundBooking.BookingID);
                console.log("Customer Name : " + foundBooking.CustomerName);
                console.log("Phone Number : " + foundBooking.PhoneNumber);
                console.log("Tour Name : " + foundBooking.TourName);
                console.log("Destination : " + foundBooking.Destination);
                console.log("Travel Date : " + foundBooking.TravelDate);
                console.log("Travellers : " + foundBooking.NumberofTravellers);
                console.log("Package Price : " + foundBooking.PackagePrice);
                console.log("Total Amount : " + foundBooking.TotalAmount);
                console.log("Status : " + foundBooking.BookingStatus);
            } else {
                console.log("\nBooking Not Found.");
            }

            break;
        }

        case 5:
            console.log("\nThank You...");
            break;

        default:
            console.log("\nInvalid choice. Please enter 1 to 5.");
            break;
    }

    if (choice !== 5) {
        continueChoice = prompt(
            "\nDo you want to continue (y/n): "
        ).toLowerCase();
    }

} while (choice !== 5 && continueChoice === "y");

if (choice !== 5) {
    console.log("\nThank You...");
}

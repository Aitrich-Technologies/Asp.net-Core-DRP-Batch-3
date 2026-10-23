import PromptSync from "prompt-sync";
const prompt = PromptSync();

interface Tour {
    tourId: number
    tourName: string
    destination: string
    numberOfDays: number
    price: number
    availableSeats: number
}

// interface Booking {
//     tourId: number
//     tourName: string
//     destination: string
//     numberOfDays: number
//     price: number
//     availableSeats: number
// }

// let Bookings:Booking[] =[];


let Tours:Tour[] = [];
let choice: number;
do{
            console.log("1.Add Tour");
            console.log("2.View Tour");
            console.log("3.Search Tour");
            console.log("4.Update Tour");
            console.log("5.Delete Tour");
            console.log("6.Book Tour");
            console.log("7.Exit");

            choice = Number(prompt("Enter your choice : "));

    switch (choice){
        case 1:
            let tour:Tour = {
                tourId: Number(prompt("Enter tour Id : ")),
                tourName:prompt("ENter tour name : "),
                destination:prompt("ENter destination : "),
                numberOfDays:Number(prompt("Enter number of days :")),
                price:Number(prompt("ENter Price : ")),
                availableSeats:Number(prompt("Enter no.of seats :"))
            }

            Tours.push(tour);
            console.log("Tour Added Successfully");
            break;

        case 2:
            if(Tours.length == 0){
                console.log("No Tour Available");
            }
            else{
                
                Tours.forEach((t) => {
                console.log("tourid",t.tourId);
                console.log("tourName",t.tourName);
                console.log("Destination",t.destination);
                console.log("No Of Days",t.numberOfDays);
                console.log("Price",t.price);
                console.log("AvailableSeat",t.availableSeats);
                });
            }
            break;
            
        case 3:
            let seatchTour = prompt("Enter your tour name: ");  
            let findTour = Tours.find(t => t.tourName.toLowerCase() === seatchTour.toLowerCase());

            if(findTour)
                console.log(findTour)
            
            else{
                console.log("Tour Not found");
            }
            break;
            
        case 4:
            let update = prompt("Enter tour name to update : ");
            let checkTour  = Tours.find(t => t.tourName.toLowerCase() === update.toLowerCase());

            if(checkTour){
                checkTour.price = Number(prompt("ENter new price : ")),
                checkTour.numberOfDays = Number(prompt("Enter no.of days : ")),
                checkTour.availableSeats = Number(prompt("Enter available seats : "));

                console.log("Tour Updated Successfully");
            }
            else{
                console.log("No Tour Found");
            }    
            break;
            
        case 5:
            let deleteTour = prompt("Enter tour name : ");
            let deletetour = Tours.findIndex(t => t.tourName.toLowerCase() === deleteTour.toLowerCase());

            if(deletetour != -1){
                Tours.splice(deletetour, 1);
                console.log("Tour Deleted Successfully.");
            }
            else{
                console.log("Tour Not Found");
            }
            break;

        case 6:
            let BookTour = prompt("Enter tour name : ");
            let book = Tours.find(t => t.tourName.toLowerCase() === BookTour.toLowerCase());
            
            if(book){
                let seat = Number(prompt("Enter no of seats :"));
                if(seat > book.availableSeats){
                    console.log("No seats available")
                }
                else{
                    let sum = seat * book.price;
                    let Total = sum;
                    
                    // Bookings.push(book);
                    console.log("Booking Added");
                    console.log("Total :",Total);
                }
            }
            break;
        case 7:
            console.log("Exited");
            break; 
        default:
            console.log("Invalid Choice");
    }
}while (choice != 7);
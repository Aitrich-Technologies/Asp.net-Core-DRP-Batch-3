import promptSync from "prompt-sync";
const prompt = promptSync();

interface Destination {
    destinationId: number;
    destinationName: string;
    country: string;
    description: string;
    startingPrice: number;
    requirements: string;
}

let destinations: Destination[] = [];
let choice: number;

do {

    console.log("\n========= DESTINATION MANAGEMENT =========");
    console.log("1. Add Destination");
    console.log("2. View Destinations");
    console.log("3. Search Destination");
    console.log("4. Update Destination");
    console.log("5. Delete Destination");
    console.log("6. Exit");

    choice = Number(prompt("Enter your choice : "));

    switch (choice) {

        case 1:

            let destination: Destination = {
                destinationId: Number(prompt("Enter Destination ID : ")),
                destinationName: prompt("Enter Destination Name : "),
                country: prompt("Enter Country : "),
                description: prompt("Enter Description : "),
                startingPrice: Number(prompt("Enter Starting Price : ")),
                requirements: prompt("Enter Requirements : ")
            };

            destinations.push(destination);
            console.log("Destination Added Successfully.");
            break;

        case 2:

            if (destinations.length == 0) {
                console.log("No Destinations Available.");
            } else {

                console.log("\n========== DESTINATION LIST ==========");

                destinations.forEach((d) => {

                    console.log("----------------------------------");
                    console.log("ID          :", d.destinationId);
                    console.log("Name        :", d.destinationName);
                    console.log("Country     :", d.country);
                    console.log("Description :", d.description);
                    console.log("Price       :", d.startingPrice);
                    console.log("Requirements:", d.requirements);
                });
            }

            break;

        case 3:

            let searchName = prompt("Enter Destination Name : ");

            let found = destinations.find(
                d => d.destinationName.toLowerCase() === searchName.toLowerCase()
            );

            if (found) {
                console.log(found);
            } else {
                console.log("Destination Not Found.");
            }

            break;

        case 4:

            let updateName = prompt("Enter Destination Name : ");

            let updateDestination = destinations.find(
                d => d.destinationName.toLowerCase() === updateName.toLowerCase()
            );

            if (updateDestination) {

                updateDestination.startingPrice = Number(
                    prompt("Enter New Price : ")
                );

                updateDestination.description = 
                    prompt("Enter New Rating : ")
             
                updateDestination.requirements = 
                    prompt("Enter New Requirements : ")
             
                console.log("Destination Updated Successfully.");

            } else {

                console.log("Destination Not Found.");

            }

            break;

        case 5:

            let deleteName = prompt("Enter Destination Name : ");

            let index = destinations.findIndex(
                d => d.destinationName.toLowerCase() === deleteName.toLowerCase()
            );
            if (index != -1) {

                destinations.splice(index, 1);
                console.log("Destination Deleted Successfully.");

            } else {

                console.log("Destination Not Found.");

            }

            break;

        case 6:

            console.log("Thank You...");
            break;

        default:

            console.log("Invalid Choice");

    }

} while (choice != 6);
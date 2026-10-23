import PromptSync from "prompt-sync";
const prompt = PromptSync();

interface Person {
    FirstName:string;
    LastName:string;
    Email:string;
    Phone:number;
    Username:string;
    Password:string;    
}

let persons: Person[] = [];
let choice: number;

do {
    console.log("---------USER MANAGEMENT SYSTEM----------");
    console.log("1. Register");
    console.log("2. Login");
    console.log("3. View User");
    console.log("4. Exit");

    choice = Number(prompt("Enter your choice : "));

    switch (choice) {
        case 1:
            let person: Person = {
                FirstName: prompt("Enter first name : "),
                LastName: prompt("Enter your last name : "),
                Email: prompt("Enter your email : "),
                Phone:Number(prompt("Enter phone numer :")),
                Username:prompt("Enter username : "),
                Password:prompt("Enter password : "),
            };

            let email = persons.find(p => p.Email.toLowerCase() === person.Email.toLowerCase());
            let pass = person.Password.length > 8;

            

            if(email){
                console.log("Email Exist!");   
            }
           else if(!pass){
                console.log("Password must contain 8 character");
            }
            else{
                persons.push(person);
                console.log("Person Added Successfully");
            }
            break;

        case 2:
            
            let Username = prompt("Enter username : ");
            let Password = prompt("Enter password : ");
            
            let login = persons.find((d: Person) =>
                d.Username.toLowerCase() === Username.toLowerCase() &&
                d.Password === Password
            );

            if (login){
                console.log("Login Successfull");
            }
            else{
                console.log("Invalid Creditional");
            }
            break;

        case 3:
            if (persons.length == 0) {
                console.log("No Persons Available.");
            }
            else {
                console.log("\n========== User LIST ==========");

                persons.forEach((d) => {

                    console.log("----------------------------------");
                    console.log("FirstName  :", d.FirstName);
                    console.log("LastName   :", d.LastName);
                    console.log("Email      :", d.Email);
                    console.log("Username   :", d.Username);
                    console.log("Phone      :", d.Phone);
                    
                });
            }

            break;

        case 4:
             console.log("Thank You...");
            break;

        default:

            console.log("Invalid Choice");    
    }
}while (choice != 4);
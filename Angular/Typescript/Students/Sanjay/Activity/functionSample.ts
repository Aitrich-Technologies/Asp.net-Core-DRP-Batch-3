// function Tour_Booking(price:number, no_passengers:number): number {
//     return price * no_passengers;
// }
// console.log(Tour_Booking(200,4));


// function Tour_Availability(seats:number):string{
//     if(seats > 0){
//         return "Tour Available";
//     }
//     else{
//         return "Tour Full";
//     }
// }
// console.log(Tour_Availability(5));

// function person(name:string, age?:number):void {
//     console.log("Name : ",name);

//     if(age !== undefined){
//         console.log("Age :", age);
//     }
// }
// person("Arya");
// person("Arya",20);


// function person(name:string, age:number = 24):void {
//     console.log("Name : ",name);

//     if(age !== undefined){
//         console.log("Age :", age);
//     } 
// }
// person("Arya");
// // person("Arya",20);


// function person(name:string, ...mark:number[]):void {
//     console.log("Name : ",name);

//     if(mark !== undefined){
//         console.log("mark :", mark);
//     }
// }
// // person("Arya");
// person("Arya",20,23,24);